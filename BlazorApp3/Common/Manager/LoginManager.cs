using System;
using Enum;
using BlazorApp3.Common.Type;
using BlazorApp3.Protocol;

namespace BlazorApp3.Common.Manager;

public class LoginManager
{
    public static async Task LoginGoogleAsync()
    {
        Console.WriteLine("Protocol : Login/GoogleLogin");
        
        using (var client = new HttpClient())
        {
            LoginGoogleReq loginGoogleReq = new LoginGoogleReq();
            
            client.BaseAddress = new Uri(MyProjectInfoConfig.Instance.ServerAddress);
            await client.PostAsJsonAsync("/api/Login/GoogleLogin", loginGoogleReq);
        }
    }
}