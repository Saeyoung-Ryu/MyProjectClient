using System;
using Enum;
using BlazorApp3.Common.Type;
using BlazorApp3.Protocol;

namespace BlazorApp3.Common.Manager
{
    public class UserManager
    {
        public static async Task<UserInfo> GetUserAsync(String nickname)
        {
            Console.WriteLine("Protocol : GetUserInfo");
            
            using (var client = new HttpClient())
            {
                GetUserReq setTeamReq = new GetUserReq()
                {
                    NickName = nickname
                };
            
                client.BaseAddress = new Uri(MyProjectInfoConfig.Instance.ServerAddress);
                var response = await client.PostAsJsonAsync("/api/GetUserInfo", setTeamReq);
                var getUserRes = await response.Content.ReadFromJsonAsync<GetUserRes>();
                
                return getUserRes.UserInfo;
            }
        }
        
        public static async Task<UserInfo> GetUserApproximateAsync(String nickname) // 이름대충처도 찾음
        {
            Console.WriteLine("Protocol : GetUserInfoApproximate");
            
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
            Console.WriteLine("Protocol : SetNewUser");
            
            using (var client = new HttpClient())
            {
                SetNewUserReq setTeamReq = new SetNewUserReq()
                {
                    NickName = nickname
                };
                
                client.BaseAddress = new Uri(MyProjectInfoConfig.Instance.ServerAddress);
                var response = await client.PostAsJsonAsync("/api/SetNewUser", setTeamReq);
                var setNewUserRes = await response.Content.ReadFromJsonAsync<SetNewUserRes>();

                return setNewUserRes.IsSuccess;
            }
        }
        
        public static async Task<bool> SetUserNickNameAsync(UserInfo userInfo)
        {
            Console.WriteLine("Protocol : SetUserNickName");
            
            using (var client = new HttpClient())
            {
                SetUserNickNameReq setTeamReq = new SetUserNickNameReq()
                {
                    NickName = userInfo.UserName,
                    Seq = userInfo.Seq
                };
                
                client.BaseAddress = new Uri(MyProjectInfoConfig.Instance.ServerAddress);
                var response = await client.PostAsJsonAsync("/api/SetUserNickName", setTeamReq);
                var setUserNickNameRes = await response.Content.ReadFromJsonAsync<SetUserNickNameRes>();
                return setUserNickNameRes.IsDuplicatedNickName;
            }
        }
    }
}
