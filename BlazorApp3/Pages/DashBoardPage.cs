using MatBlazor;
using Microsoft.AspNetCore.Components;
using Protocol.Type;

namespace BlazorApp3.Pages;

public partial class DashBoardPage
{
    [Parameter]
    public string DashBoardName { get; set; }
    
    public int tabIndex = 0;
    public int rankTabIndex = 0;
    private bool showEditModal = false;
    
    public DashBoardInfo dashBoardInfo = new DashBoardInfo();


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
}