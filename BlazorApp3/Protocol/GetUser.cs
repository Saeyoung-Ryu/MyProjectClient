using BlazorApp3.Common.Type;

namespace BlazorApp3.Protocol;

public class GetUserRes
{
    public UserInfo UserInfo { get; set; }
}

public class GetUserReq
{
    public string NickName { get; set; }
    public bool IsApproximate { get; set; }
}