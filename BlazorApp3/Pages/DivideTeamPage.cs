using System.Text.Json;
using BlazorApp3.Common;
using BlazorApp3.Common.Manager;
using BlazorApp3.Common.Type;
using BlazorApp3.Protocol;
using Enum;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace BlazorApp3.Pages;

public partial class DivideTeamPage
{
    bool startBtnActive = true; 
    bool showAsSelect = true;
    bool panelOpenState = true;
    string NickName = "";
    List<UserTeamDivideInfo> userTeamDivideInfos = new List<UserTeamDivideInfo>();

    List<UserTeamDivideInfo> topUsers = new List<UserTeamDivideInfo>();
    List<UserTeamDivideInfo> jgUsers = new List<UserTeamDivideInfo>();
    List<UserTeamDivideInfo> midUsers = new List<UserTeamDivideInfo>();
    List<UserTeamDivideInfo> adcUsers = new List<UserTeamDivideInfo>();
    List<UserTeamDivideInfo> supUsers = new List<UserTeamDivideInfo>();
    
    bool dialogIsOpen = false;
    string nickNameToAdd = String.Empty;
    string newNickName = "";

    public TeamInfo team1Info = new TeamInfo();
    public TeamInfo team2Info = new TeamInfo();
    bool isLoading = false;
    async Task HandleKeyPress(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            await HandleButtonClick();
        }
    }

    async Task HandleButtonClick()
    {
        // Add your button click logic here
        await InsertBtnAsync();
    }
    
    public class TeamInfo
    {
        public int teamSide;
        
        public string topUser = string.Empty;
        public string jgUser = string.Empty;
        public string midUser = string.Empty;
        public string adcUser = string.Empty;
        public string supUser = string.Empty;

        public bool IsAllFilled()
        {
            if (topUser != String.Empty && jgUser != String.Empty && midUser != String.Empty && adcUser != String.Empty & supUser != String.Empty)
                return true;

            return false;
        }
    }

    protected override async Task OnInitializedAsync()
    {
        var storedData = await JSRuntime.InvokeAsync<string>("localStorage.getItem", "userTeamDivideInfos");

        if (!string.IsNullOrEmpty(storedData))
        {
            userTeamDivideInfos = JsonSerializer.Deserialize<List<UserTeamDivideInfo>>(storedData);
        }
    }

    private void ResetLists()
    {
        topUsers.Clear();
        jgUsers.Clear();
        midUsers.Clear();
        adcUsers.Clear();
        supUsers.Clear();
    }
    
    private void ResetObjects()
    {
        team1Info = new TeamInfo();
        team2Info = new TeamInfo();
    }

    private void TestPrint()
    {
        Console.WriteLine("TestPrint");
    }
    
    private async Task InsertBtnAsync()
    {
        if(userTeamDivideInfos.Count >= 10)
            return;
        
        // var user = await AccountDB.GetUserInfoAsync(NickName);
        UserTeamDivideInfo utd = new UserTeamDivideInfo();
        
        utd.UserInfo = await UserManager.GetUserApproximateAsync(NickName);
        
        if (userTeamDivideInfos.Select(e => e.UserInfo.UserName).Contains(utd.UserInfo.UserName)) 
            return;
        
        userTeamDivideInfos.Add(utd);
        await JSRuntime.InvokeVoidAsync("localStorage.setItem", "userTeamDivideInfos", JsonSerializer.Serialize(userTeamDivideInfos));

        NickName = String.Empty;
    }

    private async Task ResetUserListAsyncBtn()
    {
        userTeamDivideInfos.Clear();
        ResetLists();
        ResetObjects();
        
        startBtnActive = true;
        showAsSelect = true;
        await JSRuntime.InvokeVoidAsync("localStorage.clear");
    }

    private void SetAllPositionNoneBtn()
    {
        foreach (var teamDivideInfo in userTeamDivideInfos)
        {
            teamDivideInfo.LineType = LineType.Random;
            teamDivideInfo.ExceptionLine = LineType.None;
        }
        
        ResetLists();
        
        team1Info = new TeamInfo();
        team2Info = new TeamInfo();

        showAsSelect = true;
        startBtnActive = !startBtnActive;
    }
    
    private void DeleteUserInListBtnAsync(UserTeamDivideInfo user)
    {
        for (int i = 0; i < userTeamDivideInfos.Count; i++)
        {
            if(user.UserInfo.UserName == userTeamDivideInfos[i].UserInfo.UserName)
                userTeamDivideInfos.RemoveAt(i);
        }
    }

    private async Task DivideTeamBtn()
    {
        isLoading = true;
        var list = DivideTeamManager.DivideTeam(userTeamDivideInfos);
        list = list.OrderBy(e => e.LineType).ToList();
        userTeamDivideInfos = list;

        topUsers = userTeamDivideInfos.Where(e => e.LineType == LineType.Top).ToList();
        jgUsers = userTeamDivideInfos.Where(e => e.LineType == LineType.Jungle).ToList();
        midUsers = userTeamDivideInfos.Where(e => e.LineType == LineType.Mid).ToList();
        adcUsers = userTeamDivideInfos.Where(e => e.LineType == LineType.Adc).ToList();
        supUsers = userTeamDivideInfos.Where(e => e.LineType == LineType.Support).ToList();

        startBtnActive = !startBtnActive;
        showAsSelect = false;
        
        isLoading = false;
    }

    private async Task SetTeamBtn()
    {
        Random rand = new Random();
        int randomNumber = rand.Next(1, 3); // Generates a random number between 1 and 2 inclusive

        int otherNumber;
        if (randomNumber == 1)
            otherNumber = 2;
        else
            otherNumber = 1;

        team1Info.teamSide = randomNumber;
        team2Info.teamSide = otherNumber;

        List<TeamInfo> teams = new List<TeamInfo>() {team1Info, team2Info};

        var team1SetInfo = teams.First(e => e.teamSide == 1);
        var team2SetInfo = teams.First(e => e.teamSide == 2);

        LogMatchHistory logMatchHistory = new LogMatchHistory()
        {
            Team1Data = $"{team1SetInfo.topUser}, {team1SetInfo.jgUser}, {team1SetInfo.midUser}, {team1SetInfo.adcUser}, {team1SetInfo.supUser}",
            Team2Data = $"{team2SetInfo.topUser}, {team2SetInfo.jgUser}, {team2SetInfo.midUser}, {team2SetInfo.adcUser}, {team2SetInfo.supUser}",
            Team1Win = -1,
            Team2Win = -1
        };

        // await LogDB.InsertLogMatchHistoryAsync(logMatchHistory); 서버 이전
        using (var client = new HttpClient())
        {
            SetTeamReq setTeamReq = new SetTeamReq()
            {
                LogMatchHistory = logMatchHistory
            };
            
            client.BaseAddress = new Uri(MyProjectInfoConfig.Instance.ServerAddress);
            var response = await client.PostAsJsonAsync("/api/MatchHistory/SetTeam", setTeamReq);
            Console.WriteLine("Protocol : MatchHistory/SetTeam");
        }
        
    }
    
    private async Task SwapTeamBtnAsync()
    {
        (team1Info.teamSide, team2Info.teamSide) = (team2Info.teamSide, team1Info.teamSide);

        Console.WriteLine($"Team1Info Adc = {team1Info.adcUser} Team1Info sid = {team1Info.teamSide}");
        
        List<TeamInfo> teams = new List<TeamInfo>() {team1Info, team2Info};

        var team1SetInfo = teams.First(e => e.teamSide == 1);
        var team2SetInfo = teams.First(e => e.teamSide == 2);

        LogMatchHistory logMatchHistory = new LogMatchHistory()
        {
            Team1Data = $"{team1SetInfo.topUser}, {team1SetInfo.jgUser}, {team1SetInfo.midUser}, {team1SetInfo.adcUser}, {team1SetInfo.supUser}",
            Team2Data = $"{team2SetInfo.topUser}, {team2SetInfo.jgUser}, {team2SetInfo.midUser}, {team2SetInfo.adcUser}, {team2SetInfo.supUser}",
            Team1Win = -1,
            Team2Win = -1
        };

        // await LogDB.InsertLogMatchHistoryAsync(logMatchHistory); 서버이전
        
        using (var client = new HttpClient())
        {
            SetTeamReq setTeamReq = new SetTeamReq()
            {
                LogMatchHistory = logMatchHistory
            };
            
            client.BaseAddress = new Uri(MyProjectInfoConfig.Instance.ServerAddress);
            var response = await client.PostAsJsonAsync("/api/MatchHistory/SetTeam", setTeamReq);
            Console.WriteLine("Protocol : MatchHistory/SetTeam");
        }
    }

    // Team1 = 1팀, 2팀 랜덤선택된 그 팀
    private async Task Team1WinBtnAsync()
    {
        Console.WriteLine("1팀 승리");
    }

    private async Task Team2WinBtnAsync()
    {
        Console.WriteLine("2팀 승리");
    }
    
    void OpenDialog()
    {
        dialogIsOpen = true;
    }
 
    void CloseDialog()
    {
        dialogIsOpen = false;
    }
    
    public async Task AddNewUserAsyncBtn()
    {
        var userInfo = await UserManager.GetUserAsync(NickName);

        if (userInfo != null)
        {
            dialogIsOpen = false;
            return;
        }

        var isSuccess = await UserManager.SetNewUserAsync(newNickName);
        
        if (isSuccess == false)
        {
            dialogIsOpen = false;
            return;
        }
        
        newNickName = String.Empty;
        dialogIsOpen = false;
    }
}