namespace BlazorApp3.Common.Type;

public class UserWinRateHistory
{
    public int UserSeq { get; set; }
    public int LineType { get; set; }
    public int WinCount { get; set; }
    public int LoseCount { get; set; }

    public int GetWinRate()
    {
        if (WinCount + LoseCount == 0)
            return -1;
        
        return WinCount / (WinCount + LoseCount) * 100;
    }

    public int GetOverAllScore()
    {
        return WinCount * 12 - LoseCount * 10;
    }

    public async Task<string> GetNickNameAsync()
    {
        var userInfo = await AccountDB.GetUserInfoWithIdAsync(UserSeq);
        
        if(userInfo == null)
            return String.Empty;
        
        return userInfo.UserName;
    }
}