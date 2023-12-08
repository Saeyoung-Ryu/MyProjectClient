using BlazorApp3.Common.Type;

namespace BlazorApp3.Protocol;

public class SetNewUserRes
{
    public bool IsSuccess { get; set; }
}

public class SetNewUserReq
{
    public string NickName { get; set; }
}