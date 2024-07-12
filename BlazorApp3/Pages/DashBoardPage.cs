using MatBlazor;
using Microsoft.AspNetCore.Components;
using Protocol.Type;
using Microsoft.AspNetCore.Components.Web;
using MudBlazor;
using Protocol.Enum;
using System.Net.Http.Json;
using Protocol;


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
    
    private List<string> dashBoardMembers = new List<string> { "appleAAAAA", "bananaBBBBB" };
    private List<string> filteredSuggestions = new List<string>();

    private bool isDivideBtnClicked = false;

    private bool addNewMemberDialogIsOpen = false;
    private bool alreadyAddedMemberDialogIsOpen = false;

    private bool isLoading = false;
    
    protected override async Task OnInitializedAsync()
    {
        isLoading = true;
        dashBoardInfo = await GetDashBoardInfoAsync();

        if (dashBoardInfo == null)
        {
            ShowError(MatToastType.Warning, "DashBoard Not Found");
        }

        isLoading = false;
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
        var getDashBoardInfoReq = new GetDashBoardInfoReq()
        {
            ProtocolId = ProtocolId.GetDashBoardInfo,
            DashBoardName = DashBoardName
        };
        var res = await HttpManager.SendHttpServerRequestAsync(getDashBoardInfoReq);
        var getDashBoardInfoRes = (GetDashBoardInfoRes) res;

        return getDashBoardInfoRes.DashBoardInfo;

        /*return dashBoardInfo = new DashBoardInfo()
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
        };*/
    }
    
    private void ShowEditModal()
    {
        showEditModal = true;
    }
    
    private void AddNewUserBtn()
    {
        dashBoardMembers.Add(enteredNickName);
        
        AddUserDivideTeamList();
        addNewMemberDialogIsOpen = false;
    }

    private void CancelAddNewUserBtn()
    {
        addNewMemberDialogIsOpen = false;
    }

    private void AddUserDivideTeamListBtn()
    {
        if (enteredNickName == string.Empty)
            return;

        if (divideTeamList.Select(e => e.NickName).Contains(enteredNickName))
        {
            ShowError(MatToastType.Info, "이미 추가된 유저입니다.");
            enteredNickName = string.Empty;
            return;
        }
        
        if (!dashBoardMembers.Contains(enteredNickName))
            addNewMemberDialogIsOpen = true;
        else
        {
            AddUserDivideTeamList();
        }
    }

    private void AddUserDivideTeamList()
    {
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

    private void StartDivideRandomLineBtn()
    {
        isDivideBtnClicked = true;
    }

    private void SwapTeamBtn()
    {
        foreach (var item in _items)
        {
            if (item.Identifier == "블루")
                item.Identifier = "레드";
            else if (item.Identifier == "레드")
                item.Identifier = "블루";
        }
    }

    private void ResetDividedBtn()
    {
        foreach (var item in _items)
        {
            item.Identifier = "All";
        }
    }
    
    private void ItemUpdated(MudItemDropInfo<DropItem> dropInfo)
    {
        var item = dropInfo.Item;
        var targetZoneIdentifier = dropInfo.DropzoneIdentifier;
        
        var existingItem = _items.FirstOrDefault(x => x.Name != item.Name && x.LineType == item.LineType);

        if (existingItem == null)
            return;
            
        if (targetZoneIdentifier == "블루")
            existingItem.Identifier = "레드";
                
        if (targetZoneIdentifier == "레드")
            existingItem.Identifier = "블루";
                
        if (targetZoneIdentifier == "All")
            existingItem.Identifier = "All";
                
        item.Identifier = targetZoneIdentifier;
    }
    
    private List<DropItem> _items = new()
    {
        new DropItem(){ Name = "원딜11111", Identifier = "All", LineType = LineType.Adc },
        new DropItem(){ Name = "원딜22222", Identifier = "All", LineType = LineType.Adc },
        new DropItem(){ Name = "서폿11111", Identifier = "All", LineType = LineType.Support },
        new DropItem(){ Name = "서폿22222", Identifier = "All", LineType = LineType.Support },
        new DropItem(){ Name = "미드11111", Identifier = "All", LineType = LineType.Mid },
        new DropItem(){ Name = "미드22222", Identifier = "All", LineType = LineType.Mid },
        new DropItem(){ Name = "정글22222", Identifier = "All", LineType = LineType.Jungle },
        new DropItem(){ Name = "정글11111", Identifier = "All", LineType = LineType.Jungle },
        new DropItem(){ Name = "ㅌ11111", Identifier = "All", LineType = LineType.Top },
        new DropItem(){ Name = "ㅌ22222", Identifier = "All", LineType = LineType.Top },
    };
    
    public class DropItem
    {
        public string Name { get; init; }
        public LineType LineType { get; set; }
        public string Identifier { get; set; }
    }
}