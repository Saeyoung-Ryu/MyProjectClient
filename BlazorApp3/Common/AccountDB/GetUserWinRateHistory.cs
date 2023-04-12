using System.Data;
using BlazorApp3.Common;
using BlazorApp3.Common.Type;
using Dapper;
using MySqlConnector;

namespace BlazorApp3.Common
{
    public partial class AccountDB
    {
        public static async Task<List<UserWinRateHistory>> GetUserWinRateHistoryAsync(int seq)
        {
            await using (var conn = new MySqlConnection(Config.ConnectionString))
            {
                return await SpGetUserWinRateHistoryAsync(conn, null, seq);
            }
        }

        private static async Task<List<UserWinRateHistory>> SpGetUserWinRateHistoryAsync(MySqlConnection conn, MySqlTransaction trxn, int seq)
        {
            var parameters = new DynamicParameters();
            parameters.Add("_userSeq", seq);

            return (await conn.QueryAsync<UserWinRateHistory>("spGetUserWinRateHistory", parameters, trxn, commandType: CommandType.StoredProcedure)).ToList();
        }
    }
}




