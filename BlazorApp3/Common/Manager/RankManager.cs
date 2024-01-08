using BlazorApp3.Common.Type;
using BlazorApp3.Protocol;
using Enum;

namespace BlazorApp3.Common.Manager;

public class RankManager
{
    public static async Task<GetRankingRes> GetRankAsync()
    {
        Console.WriteLine("Protocol : Ranking/GetRanking");
        
        using (var client = new HttpClient())
        {
            GetRankingReq getRankingReq = new GetRankingReq();
            
            client.BaseAddress = new Uri(MyProjectInfoConfig.Instance.ServerAddress);
            var response = await client.PostAsJsonAsync("/api/Ranking/GetRanking", getRankingReq);
            
            return await response.Content.ReadFromJsonAsync<GetRankingRes>();
        }
    }
    
    public static async Task<ResetRankingRes> ResetRankAsync()
    {
        Console.WriteLine("Protocol : Ranking/ResetRanking");
        
        using (var client = new HttpClient())
        {
            ResetRankingReq resetRankingReq = new ResetRankingReq();
            
            client.BaseAddress = new Uri(MyProjectInfoConfig.Instance.ServerAddress);
            var response = await client.PostAsJsonAsync("/api/Ranking/ResetRanking", resetRankingReq);
            
            return await response.Content.ReadFromJsonAsync<ResetRankingRes>();
        }
    }

    public static async Task<GetUserWinRateHistoryRes> GetUserWinRateHistory(int userSeq)
    {
        Console.WriteLine("Protocol : GetUserWinRateHistory");
        
        using (var client = new HttpClient())
        {
            GetUserWinRateHistoryReq getUserWinRateHistoryReq = new GetUserWinRateHistoryReq()
            {
                Seq = userSeq
            };
            
            client.BaseAddress = new Uri(MyProjectInfoConfig.Instance.ServerAddress);
            var response = await client.PostAsJsonAsync("/api/GetUserWinRateHistory", getUserWinRateHistoryReq);
            var userWinRateHistory = await response.Content.ReadFromJsonAsync<GetUserWinRateHistoryRes>();

            if (userWinRateHistory.UserWinRateHistory == null || userWinRateHistory.UserWinRateHistory.Count == 0)
            {
                userWinRateHistory = new GetUserWinRateHistoryRes();
                List<UserWinRateHistory> list = new List<UserWinRateHistory>();

                for (int i = 1; i <= 5; i++)
                {
                    list.Add(new UserWinRateHistory()
                    {
                        LineType = i,
                        UserSeq = userSeq,
                        WinCount = 0,
                        LoseCount = 0
                    });
                }

                userWinRateHistory.UserWinRateHistory = list;
            }
            
            return userWinRateHistory;
        }
    }
    
    public static async Task SetUserWinRateHistory(List<UserWinRateHistory> list, int userSeq, string nickName)
    {
        Console.WriteLine("Protocol : SetUserWinRateHistory");
        
        using (var client = new HttpClient())
        {
            SetUserWinRateHistoryReq setUserWinRateHistoryReq = new SetUserWinRateHistoryReq()
            {
                UserWinRateHistory = list,
                Seq = userSeq,
                NickName = nickName
            };
            
            client.BaseAddress = new Uri(MyProjectInfoConfig.Instance.ServerAddress);
            await client.PostAsJsonAsync("/api/SetUserWinRateHistory", setUserWinRateHistoryReq);
        }
    }
}