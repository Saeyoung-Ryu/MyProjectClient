using Dapper;
using MySqlConnector;
using Newtonsoft.Json;

namespace BlazorApp3.Common;
public class MyProjectInfoConfig
{
    public static MyProjectInfoConfig Instance { get; set; }
    
    public string APIKey { get; set; }
    public string ConnectionString { get; set; }

    public static void Refresh()
    {
        var configurationPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MyProjectInfo.config");
        MyProjectInfoConfig myProjectInfo = JsonConvert.DeserializeObject<MyProjectInfoConfig>(File.ReadAllText(configurationPath));

        Instance = myProjectInfo;
    }
}