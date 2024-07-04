/*using BlazorApp3.Common;
using BlazorApp3.Common.Manager;
using BlazorApp3.Common.Type;
using BlazorApp3.Protocol;
using Microsoft.AspNetCore.Components;

namespace BlazorApp3.Pages;

public partial class LoginPage
{
    private NavigationManager Navigation;
    private LoginInfo loginInfo = new LoginInfo();
    string reEnterPassword = string.Empty;
    
    bool isRegister = false;
    private void NavigateToInitPage()
    {
        Navigation.NavigateTo("/Home");
    }

    private async Task LoginBtnAsync()
    {
        
    }
    
    private async Task RegisterBtnAsync()
    {
        await LoginManager.LoginGoogleAsync();
    }

    private void NeedToRegisterBtn()
    {
        isRegister = true;
    }
}*/