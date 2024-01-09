using BlazorApp3.Common.Type;
using BlazorApp3.Protocol;

namespace BlazorApp3.Common.Manager;

public class MatchHistoryManager
{
    public static async Task<GetMatchHistoryRes> GetMatchHistoryAsync()
    {
        Console.WriteLine("Protocol : GetMatchHistory");
        
        using (var client = new HttpClient())
        {
            GetMatchHistoryReq getMatchHistoryReq = new GetMatchHistoryReq();
            
            client.BaseAddress = new Uri(MyProjectInfoConfig.Instance.ServerAddress);
            var response = await client.PostAsJsonAsync("/api/GetMatchHistory", getMatchHistoryReq);
            return await response.Content.ReadFromJsonAsync<GetMatchHistoryRes>();
        }
    }

    public static async Task SetTeamWinAsync(LogMatchHistory logMatchHistory)
    {
        Console.WriteLine("Protocol : SetTeamWin");
        
        int winTeam = 0;
        if (logMatchHistory.Team1Win == 1)
            winTeam = 1;
        else if (logMatchHistory.Team2Win == 1)
            winTeam = 2;
        
        using (var client = new HttpClient())
        {
            SetTeamWinReq setTeamWinReq = new SetTeamWinReq()
            {
                LogMatchHistory = logMatchHistory,
                WinTeam = winTeam
            };
            
            client.BaseAddress = new Uri(MyProjectInfoConfig.Instance.ServerAddress);
            await client.PostAsJsonAsync("/api/SetTeamWin", setTeamWinReq);
        }
    }
}