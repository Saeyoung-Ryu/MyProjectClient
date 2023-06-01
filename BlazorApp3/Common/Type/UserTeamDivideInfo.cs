using BlazorApp3.Common.Enum;

namespace BlazorApp3.Common.Type;

public class UserTeamDivideInfo
{
    public UserInfo UserInfo { get; set; }
    public LineType LineType { get; set; } = LineType.Random;
    public LineType ExceptionLine { get; set; } = LineType.None;
}