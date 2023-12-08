using BlazorApp3.Common.Type;

namespace BlazorApp3.Protocol;

public class SetTeamWinRes
{
    
}

public class SetTeamWinReq
{
    public LogMatchHistory LogMatchHistory { get; set; }
    public int WinTeam { get; set; }
}