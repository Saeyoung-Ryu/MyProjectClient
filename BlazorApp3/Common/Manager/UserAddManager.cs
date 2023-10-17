using System;
using Enum;
using BlazorApp3.Common.Type;

namespace BlazorApp3.Common.Manager
{
    public class UserAddManager
    {
        public static async Task SetNewUserAsync(String nickname)
        {
            await AccountDB.SetUserInfoAsync(nickname);

            var userSeq = await AccountDB.GetUserInfoAsync(nickname);

            foreach (LineType lineType in System.Enum.GetValues(typeof(LineType)))
            {
                if(lineType == LineType.Random)
                    continue;
                
                UserWinRateHistory userWinRateHistory = new UserWinRateHistory()
                {
                    UserSeq = userSeq.Seq,
                    LineType = (int) lineType,
                    WinCount = 0,
                    LoseCount = 0
                };
                
                await AccountDB.SetUserWinRateHistoryAsync(userWinRateHistory);
            }
        }
    }
}
