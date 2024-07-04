using Microsoft.AspNetCore.Components;

namespace BlazorApp3.Pages;

public partial class DashBoardPage
{
    [Parameter]
    public string DashBoardName { get; set; }

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
                Navigation.NavigateTo("/Home");
            }
            
            // dashBoardName 존재하는지 찾기
        }
    }
}