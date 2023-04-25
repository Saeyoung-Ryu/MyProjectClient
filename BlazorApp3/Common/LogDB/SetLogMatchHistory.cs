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
                await SpSetLogMatchHistoryAsync(conn, null, matchHistory);
            }
        }

        private static async Task SpSetLogMatchHistoryAsync(MySqlConnection conn, MySqlTransaction trxn, LogMatchHistory matchHistory)
        {
            var parameters = new DynamicParameters();
            parameters.Add("_team1Data", matchHistory.Team1Data);
            parameters.Add("_team2Data", matchHistory.Team2Data);
            parameters.Add("_resulted", matchHistory.Resulted);

            await conn.ExecuteAsync("spInsertLogMatchHistory", parameters, trxn, commandType: CommandType.StoredProcedure);
        }
    }
}




