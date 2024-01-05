using BlazorApp3.Common.Type;
using BlazorApp3.Protocol;

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
}