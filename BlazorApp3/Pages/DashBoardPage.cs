using MatBlazor;
using Microsoft.AspNetCore.Components;
using Protocol.Type;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorApp3.Pages;

public partial class DashBoardPage
{
    [Parameter]
    public string DashBoardName { get; set; }
    
    private int tabIndex = 0;
    private int rankTabIndex = 0;
    private bool showEditModal = false;
    
    private DashBoardInfo dashBoardInfo = new DashBoardInfo();
    private string enteredNickName = string.Empty;

    private List<RiotPlayer> divideTeamList = new List<RiotPlayer>();
    
    private List<string> suggestions = new List<string> { "appleAAAAA", "bananaBBBBB" };
    private List<string> filteredSuggestions = new List<string>();

    protected override async Task OnInitializedAsync()
    {
        dashBoardInfo = await GetDashBoardInfoAsync();

        if (dashBoardInfo == null)
        {
            ShowError(MatToastType.Warning, "DashBoard Not Found");
        }
    }

    protected override void OnInitialized()
    {
        _showProgressBar = Toaster.Configuration.ShowProgressBar;
        _showCloseButton = Toaster.Configuration.ShowCloseButton;
        _maximumOpacity = Toaster.Configuration.MaximumOpacity.ToString();
 
        _showTransitionDuration = Toaster.Configuration.ShowTransitionDuration.ToString();
        _visibleStateDuration = Toaster.Configuration.VisibleStateDuration.ToString();
        _hideTransitionDuration = Toaster.Configuration.HideTransitionDuration.ToString();
 
        _requireInteraction = Toaster.Configuration.RequireInteraction;
        
        if (string.IsNullOrEmpty(DashBoardName))
        {
            var uri = Navigation.ToAbsoluteUri(Navigation.Uri);
            var segments = uri.AbsolutePath.Split('/');
            if (segments.Length > 2)
            {
                DashBoardName = segments[2];
            }
            
            if (string.IsNullOrEmpty(DashBoardName))
            {
                Navigation.NavigateTo("/");
            }
            
            // dashBoardName 존재하는지 찾기
        }
    }
    
    private async Task HandleKeyPress(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            await Task.Delay(100); // 빈값을 검색해버리는 이슈 수정

            AddUserDivideTeamListBtn();
        }
    }

    private async Task<DashBoardInfo> GetDashBoardInfoAsync()
    {
        return dashBoardInfo = new DashBoardInfo()
        {
            DashBoardSeq = 1,
            Name = DashBoardName,
            CreateTime = DateTime.UtcNow,
            MasterName = "Master1",
            ManagerNameList = new List<string>()
            {
                "Manager1",
                "Manager2",
                "Manager3",
            },
            MemberTotalRankOrderByName = new List<string>()
            {
                "Member1",
                "Member2",
                "Member3",
            },
            MemberSupRankOrderByName = new List<string>()
            {
                "Member1",
                "Member2",
                "Member3",
            },
            MemberAdcRankOrderByName = new List<string>()
            {
                "Member1",
                "Member2",
                "Member3",
            },
            MemberMidRankOrderByName = new List<string>()
            {
                "Member1",
                "Member2",
                "Member3",
            },
            MemberJgRankOrderByName = new List<string>()
            {
                "Member1",
                "Member2",
                "Member3",
            },
            MemberTopRankOrderByName = new List<string>()
            {
                "Member1",
                "Member2",
                "Member3",
            },
            Point = 100,
            Notification = "Notification Example 1234",
        };
    }
    
    private void ShowEditModal()
    {
        showEditModal = true;
    }

    private void AddUserDivideTeamListBtn()
    {
        if (enteredNickName == string.Empty)
            return;
        
        RiotPlayer riotPlayer = new RiotPlayer();
        riotPlayer.NickName = enteredNickName;
        divideTeamList.Add(riotPlayer);

        enteredNickName = string.Empty;
    }

    private void RemoveUserDivideTeamListBtn(string nickName)
    {
        divideTeamList.RemoveAll(e => e.NickName == nickName);
    }

    private void ResetListBtn()
    {
        divideTeamList.Clear();
    }

    private void DivideTeamBtn()
    {
        
    }
}