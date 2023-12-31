namespace BlazorApp3.Common.Type;

public class UserWinRateHistory
{
    public int UserSeq { get; set; }
    public int LineType { get; set; }
    public int WinCount { get; set; }
    public int LoseCount { get; set; }

    public double GetWinRate()
    {
        if (WinCount + LoseCount == 0)
            return -1;
        
        double value = (double) WinCount / (WinCount + LoseCount) * 100;
        value = Math.Round(value, 1);
        return value;
    }

    public int GetOverAllScore()
    {
        return WinCount * 12 - LoseCount * 10;
    }
}