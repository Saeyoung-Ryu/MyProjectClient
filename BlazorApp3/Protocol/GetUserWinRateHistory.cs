using BlazorApp3.Common.Type;

namespace BlazorApp3.Protocol;

public class GetUserWinRateHistoryRes
{
    public List<UserWinRateHistory> UserWinRateHistory { get; set; }
}

public class GetUserWinRateHistoryReq
{
    public int Seq { get; set; }
}