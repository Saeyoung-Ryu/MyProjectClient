using MatBlazor;
using Microsoft.AspNetCore.Components.Web;
using Protocol;
using Protocol.Enum;
using Protocol.Type;


namespace BlazorApp3.Pages;

public partial class Home
{
    private int tabIndex = 0;
    private List<DashBoardInfoLobby> dashBoardInfos = new List<DashBoardInfoLobby>();
    private LoadDataRes loadData = new LoadDataRes();
    
    private string searchedDashBoardName = String.Empty;

    private bool _initialized = false;
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender && !_initialized)
        {
            await PlayerService.InitializePlayerAsync();
            _initialized = true;
            StateHasChanged(); // Notify the component to re-render
            
            if (PlayerService.Player.Suid > 0)
            {
                var loadDataReq = new LoadDataReq()
                {
                    ProtocolId = ProtocolId.LoadData,
                    Suid = PlayerService.Player.Suid
                };
                
                var res = await HttpManager.SendHttpServerRequestAsync(loadDataReq);
                var loadDataRes = (LoadDataRes) res;

                if (loadDataRes.Result == Result.None)
                    loadData = loadDataRes;
            }
        }
    }
    
    protected override Task OnInitializedAsync()
    {
        _showProgressBar = Toaster.Configuration.ShowProgressBar;
        _showCloseButton = Toaster.Configuration.ShowCloseButton;
        _maximumOpacity = Toaster.Configuration.MaximumOpacity.ToString();
 
        _showTransitionDuration = Toaster.Configuration.ShowTransitionDuration.ToString();
        _visibleStateDuration = Toaster.Configuration.VisibleStateDuration.ToString();
        _hideTransitionDuration = Toaster.Configuration.HideTransitionDuration.ToString();
 
        _requireInteraction = Toaster.Configuration.RequireInteraction;
        
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
            Navigation.NavigateTo($"/DashBoardPage/{searchedDashBoardName}");
        }
        catch (Exception e)
        {
            ShowError(MatToastType.Warning, "잠시 후 다시 시도해주세요.");
        }
    }
}