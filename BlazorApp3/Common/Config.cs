using System.ComponentModel;

namespace BlazorApp3.Common;

public class Config
{
    public static string ConnectionString { get; set; }

    public static void Refresh()
    {
        // ConnectionString 가지고오기!!
        ConnectionString = "";
    }
}