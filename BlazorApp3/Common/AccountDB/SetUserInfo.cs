using System.Data;
using BlazorApp3.Common;
using Dapper;
using MySqlConnector;

namespace BlazorApp3.Common
{
    public partial class AccountDB
    {
        public static async Task SetUserInfoAsync(string nickName)
        {
            await using (var conn = new MySqlConnection(Config.ConnectionString))
            {
                await SpSetUserInfoAsync(conn, null, nickName);
            }
        }

        private static async Task SpSetUserInfoAsync(MySqlConnection conn, MySqlTransaction trxn, string nickName)
        {
            var parameters = new DynamicParameters();
            parameters.Add("_userName", nickName);

            await conn.ExecuteAsync("spInsertUserInfo", parameters, trxn, commandType: CommandType.StoredProcedure);
        }
    }
}




