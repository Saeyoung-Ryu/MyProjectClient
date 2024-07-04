/*using BlazorApp3.Common.Manager;
using BlazorApp3.Protocol;

namespace BlazorApp3.Pages;

public partial class RankingPage
{
    private GetRankingRes RankingInfo { get; set; }
    private bool isLoading = false;
    private int tabIndex = 0;
    
    protected override async Task OnInitializedAsync()
    {
        isLoading = true;
        RankingInfo = await RankManager.GetRankAsync();
        isLoading = false;
    }
    
    private async Task ResetRankingBtnAsync()
    {
        isLoading = true;
        
        var rankInfo = await RankManager.ResetRankAsync();
        
        RankingInfo.TotalRankList = rankInfo.TotalRankList;
        RankingInfo.TopRankList = rankInfo.TopRankList;
        RankingInfo.JgRankList = rankInfo.JgRankList;
        RankingInfo.MidRankList = rankInfo.MidRankList;
        RankingInfo.AdcRankList = rankInfo.AdcRankList;
        RankingInfo.SupRankList = rankInfo.SupRankList;

        isLoading = false;
    }
}*/