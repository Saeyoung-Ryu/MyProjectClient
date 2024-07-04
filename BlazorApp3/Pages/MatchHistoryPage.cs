/*using BlazorApp3.Common.Manager;
using BlazorApp3.Common.Type;

namespace BlazorApp3.Pages;

public partial class MatchHistoryPage
{
    List<LogMatchHistory> logMatchHistoryList = new List<LogMatchHistory>();
    bool canClick = true;
    bool isLoading = false;
    
    protected override async Task OnInitializedAsync()
    {
        isLoading = true;
        var matchHistoryRes = await MatchHistoryManager.GetMatchHistoryAsync();
        logMatchHistoryList = matchHistoryRes.LogMatchHistoryList.OrderByDescending(e => e.Time).ToList();
        isLoading = false;
    }
    
    private async Task Team1WinBtnAsync(LogMatchHistory logMatchHistory)
    {
        canClick = false;
        
        logMatchHistory.Team1Win = 1;
        await MatchHistoryManager.SetTeamWinAsync(logMatchHistory);
        
        canClick = true;
    }

    private async Task Team2WinBtnAsync(LogMatchHistory logMatchHistory)
    {
        canClick = false;
        
        logMatchHistory.Team2Win = 1;
        await MatchHistoryManager.SetTeamWinAsync(logMatchHistory);
        
        canClick = true;
    }
}*/