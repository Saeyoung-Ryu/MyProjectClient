namespace BlazorApp3.Common.Type;

public class UserWinRateHistory
{
    public int UserSeq { get; set; }
    public int LineType { get; set; }
    public int WinCount { get; set; }
    public int LoseCount { get; set; }

    public int GetWinRate()
    {
        return WinCount / (WinCount + LoseCount);
    }

    public int GetOverAllScore()
    {
        return WinCount * 12 - LoseCount * 10;
    }
}