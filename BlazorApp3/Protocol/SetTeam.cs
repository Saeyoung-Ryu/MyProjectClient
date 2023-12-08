using BlazorApp3.Common.Type;

namespace BlazorApp3.Protocol;

public class SetTeamRes
{
    public bool IsSuccess { get; set; }
}

public class SetTeamReq
{
    public LogMatchHistory LogMatchHistory { get; set; }
}