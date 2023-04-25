using System.Data;
using BlazorApp3.Common;
using BlazorApp3.Common.Type;
using Dapper;
using MySqlConnector;

namespace BlazorApp3.Common
{
    public partial class LogDB
    {
        public static async Task SetLogMatchHistoryAsync(LogMatchHistory matchHistory)
        {
            await using (var conn = new MySqlConnection(Config.ConnectionString))
            {
                await SetLogMatchHistoryAsync(conn, null, matchHistory);
            }
        }

        private static async Task SetLogMatchHistoryAsync(MySqlConnection conn, MySqlTransaction trxn, LogMatchHistory matchHistory)
        {
            var parameters = new DynamicParameters();
            parameters.Add("_time", matchHistory.Time);
            parameters.Add("_team1Win", matchHistory.Team1Win);
            parameters.Add("_team2Win", matchHistory.Team2Win);

            await conn.ExecuteAsync("spSetLogMatchHistory", parameters, trxn, commandType: CommandType.StoredProcedure);
        }
    }
}




