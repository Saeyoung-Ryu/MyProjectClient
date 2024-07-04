using Protocol.Type;

namespace BlazorApp3.Pages;

public partial class Home
{
    private int tabIndex = 0;
    private List<DashBoardInfo> dashBoardInfos = new List<DashBoardInfo>();

    protected override Task OnInitializedAsync()
    {
        dashBoardInfos.Add(new DashBoardInfo()
        {
            Name = "aaaa",
            MasterName = "Master1",
            Point = 100,
        });
        
        dashBoardInfos.Add(new DashBoardInfo()
        {
            Name = "bbbb",
            MasterName = "Master2",
            Point = 100,
        });
        
        dashBoardInfos.Add(new DashBoardInfo()
        {
            Name = "cccc",
            MasterName = "Master3",
            Point = 100,
        });
        
        dashBoardInfos.Add(new DashBoardInfo()
        {
            Name = "dddd",
            MasterName = "Master4",
            Point = 100,
        });
        
        dashBoardInfos.Add(new DashBoardInfo()
        {
            Name = "eeee",
            MasterName = "Master5",
            Point = 100,
        });
        
        return base.OnInitializedAsync();
    }
}