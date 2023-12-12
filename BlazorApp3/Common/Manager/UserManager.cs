using System;
using Enum;
using BlazorApp3.Common.Type;
using BlazorApp3.Protocol;

namespace BlazorApp3.Common.Manager
{
    public class UserManager
    {
        public static async Task<UserInfo> GetUserAsync(String nickname, bool isApproximate = true)
        {
            using (var client = new HttpClient())
            {
                GetUserReq setTeamReq = new GetUserReq()
                {
                    NickName = nickname
                };
            
                client.BaseAddress = new Uri(MyProjectInfoConfig.Instance.ServerAddress);
                var response = await client.PostAsJsonAsync("/api/GetUserInfo", setTeamReq);
                Console.WriteLine("Protocol : GetUserInfo");
                var getUserRes = await response.Content.ReadFromJsonAsync<GetUserRes>();
                
                return getUserRes.UserInfo;
            }
        }
        
        public static async Task<UserInfo> GetUserApproximateAsync(String nickname, bool isApproximate = true) // 이름대충처도 찾음
        {
            using (var client = new HttpClient())
            {
                GetUserReq setTeamReq = new GetUserReq()
                {
                    NickName = nickname
                };
            
                client.BaseAddress = new Uri(MyProjectInfoConfig.Instance.ServerAddress);
                var response = await client.PostAsJsonAsync("/api/GetUserInfoApproximate", setTeamReq);
                var getUserRes = await response.Content.ReadFromJsonAsync<GetUserRes>();
                
                return getUserRes.UserInfo;
            }
        }
        
        public static async Task<bool> SetNewUserAsync(String nickname)
        {
            using (var client = new HttpClient())
            {
                SetNewUserReq setTeamReq = new SetNewUserReq()
                {
                    NickName = nickname
                };
                
                client.BaseAddress = new Uri(MyProjectInfoConfig.Instance.ServerAddress);
                var response = await client.PostAsJsonAsync("/api/SetNewUser", setTeamReq);
                Console.WriteLine("Protocol : SetNewUser");
                var setNewUserRes = await response.Content.ReadFromJsonAsync<SetNewUserRes>();

                return setNewUserRes.IsSuccess;
            }
        }
    }
}
