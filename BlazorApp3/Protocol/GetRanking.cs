using BlazorApp3.Common.Type;

namespace BlazorApp3.Protocol;

public class GetRankingRes
{
    public List<RankInfo> TotalRankList { get; set; }
 
    public List<RankInfo> AdcRankList { get; set; }
    public List<RankInfo> SupRankList { get; set; }
    public List<RankInfo> MidRankList { get; set; }
    public List<RankInfo> JgRankList { get; set; }
    public List<RankInfo> TopRankList { get; set; }
}

public class GetRankingReq
{
    
}