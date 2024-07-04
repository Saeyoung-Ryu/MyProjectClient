using MatBlazor;
using Microsoft.AspNetCore.Components.Web;
using Protocol.Type;


namespace BlazorApp3.Pages;

public partial class Home
{
    private int tabIndex = 0;
    private List<DashBoardInfo> dashBoardInfos = new List<DashBoardInfo>();
    
    private string searchedDashBoardName = String.Empty;

    protected override Task OnInitializedAsync()
    {
        _showProgressBar = Toaster.Configuration.ShowProgressBar;
        _showCloseButton = Toaster.Configuration.ShowCloseButton;
        _maximumOpacity = Toaster.Configuration.MaximumOpacity.ToString();
 
        _showTransitionDuration = Toaster.Configuration.ShowTransitionDuration.ToString();
        _visibleStateDuration = Toaster.Configuration.VisibleStateDuration.ToString();
        _hideTransitionDuration = Toaster.Configuration.HideTransitionDuration.ToString();
 
        _requireInteraction = Toaster.Configuration.RequireInteraction;
        
        dashBoardInfos.Add(new DashBoardInfo()
        {
            Name = "aaaa",
            MasterName = "Master1",
            Point = 100,
        });
        
        dashBoardInfos.Add(new DashBoardInfo()
        {
            Name = "bbbb",
            MasterName = "Master2",
            Point = 100,
        });
        
        dashBoardInfos.Add(new DashBoardInfo()
        {
            Name = "cccc",
            MasterName = "Master3",
            Point = 100,
        });
        
        dashBoardInfos.Add(new DashBoardInfo()
        {
            Name = "dddd",
            MasterName = "Master4",
            Point = 100,
        });
        
        dashBoardInfos.Add(new DashBoardInfo()
        {
            Name = "eeee",
            MasterName = "Master5",
            Point = 100,
        });
        
        return base.OnInitializedAsync();
    }
    
    private async Task HandleKeyPress(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            await Task.Delay(100); // 빈값을 검색해버리는 이슈 수정
            PerformSearch();
        }
    }

    private void PerformSearch()
    {
        MoveToDashBoardPage();
    }

    private void MoveToDashBoardPage()
    {
        try
        {
            DashBoardInfo dashBoardInfo = null;

            if (dashBoardInfo == null)
            {
                ShowDashBoardNotExist(MatToastType.Secondary, "존재하지 않는 대시보드 입니다!");
                return;
            }
            
            Navigation.NavigateTo($"/DashBoardPage/{searchedDashBoardName}");
        }
        catch (Exception)
        {
            ShowError(MatToastType.Warning, "잠시 후 다시 시도해주세요.");
        }
    }
}