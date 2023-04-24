using System.Data;
using BlazorApp3.Common;
using BlazorApp3.Common.Type;
using Dapper;
using MySqlConnector;

namespace BlazorApp3.Common
{
    public partial class AccountDB
    {
        public static async Task<UserInfo> GetUserInfoAsync(string nickName)
        {
            await using (var conn = new MySqlConnection(Config.ConnectionString))
            {
                return await SpGetUserInfoAsync(conn, null, nickName);
            }
        }

        private static async Task<UserInfo> SpGetUserInfoAsync(MySqlConnection conn, MySqlTransaction trxn, string nickName)
        {
            var parameters = new DynamicParameters();
            parameters.Add("_userName", nickName);

            return await conn.QuerySingleOrDefaultAsync<UserInfo>("spGetUserInfo", parameters, trxn, commandType: CommandType.StoredProcedure);
        }
    }
}




