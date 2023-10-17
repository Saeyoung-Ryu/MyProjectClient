using System;
using System.Text.RegularExpressions;
using Enum;
using BlazorApp3.Common.Type;

namespace BlazorApp3.Common.Manager
{
    public class RankManager
    {
        public static async Task SetUserWinAsync(string teamData)
        {
            teamData = Regex.Replace(teamData, @",\s+", ",");
            string[] nickNameArray = teamData.Split(new char[] {','});
            
            if(nickNameArray.Length != 5)
                return;

            for (int i = 0; i < nickNameArray.Length; i++)
            {
                var user = await AccountDB.GetUserInfoAsync(nickNameArray[i]);

                if (i == 0)
                {
                    var userWinRateHistoryList = await AccountDB.GetUserWinRateHistoryAsync(user.Seq);
                    var userWinRateHistory = userWinRateHistoryList.FirstOrDefault(e => e.LineType == 5);
                    
                    if(userWinRateHistory == null)
                        return;
                    
                    userWinRateHistory.WinCount++;

                    await AccountDB.SetUserWinRateHistoryAsync(userWinRateHistory);
                }
                else if (i == 1)
                {
                    var userWinRateHistoryList = await AccountDB.GetUserWinRateHistoryAsync(user.Seq);
                    var userWinRateHistory = userWinRateHistoryList.FirstOrDefault(e => e.LineType == 4);
                    
                    if(userWinRateHistory == null)
                        return;
                    
                    userWinRateHistory.WinCount++;

                    await AccountDB.SetUserWinRateHistoryAsync(userWinRateHistory);
                }
                else if (i == 2)
                {
                    var userWinRateHistoryList = await AccountDB.GetUserWinRateHistoryAsync(user.Seq);
                    var userWinRateHistory = userWinRateHistoryList.FirstOrDefault(e => e.LineType == 3);
                    
                    if(userWinRateHistory == null)
                        return;
                    
                    userWinRateHistory.WinCount++;

                    await AccountDB.SetUserWinRateHistoryAsync(userWinRateHistory);
                }
                else if (i == 3)
                {
                    var userWinRateHistoryList = await AccountDB.GetUserWinRateHistoryAsync(user.Seq);
                    var userWinRateHistory = userWinRateHistoryList.FirstOrDefault(e => e.LineType == 2);
                    
                    if(userWinRateHistory == null)
                        return;
                    
                    userWinRateHistory.WinCount++;

                    await AccountDB.SetUserWinRateHistoryAsync(userWinRateHistory);
                }
                else if (i == 4)
                {
                    var userWinRateHistoryList = await AccountDB.GetUserWinRateHistoryAsync(user.Seq);
                    var userWinRateHistory = userWinRateHistoryList.FirstOrDefault(e => e.LineType == 1);
                    
                    if(userWinRateHistory == null)
                        return;
                    
                    userWinRateHistory.WinCount++;

                    await AccountDB.SetUserWinRateHistoryAsync(userWinRateHistory);
                }
            }
        }

        public static async Task SetUserLoseAsync(string teamData)
        {
            teamData = Regex.Replace(teamData, @",\s+", ",");
            string[] nickNameArray = teamData.Split(new char[] {','});
            
            if(nickNameArray.Length != 5)
                return;

            for (int i = 0; i < nickNameArray.Length; i++)
            {
                var user = await AccountDB.GetUserInfoAsync(nickNameArray[i]);

                if (i == 0)
                {
                    var userWinRateHistoryList = await AccountDB.GetUserWinRateHistoryAsync(user.Seq);
                    var userWinRateHistory = userWinRateHistoryList.FirstOrDefault(e => e.LineType == 5);
                    
                    if(userWinRateHistory == null)
                        return;
                    
                    userWinRateHistory.LoseCount++;

                    await AccountDB.SetUserWinRateHistoryAsync(userWinRateHistory);
                }
                else if (i == 1)
                {
                    var userWinRateHistoryList = await AccountDB.GetUserWinRateHistoryAsync(user.Seq);
                    var userWinRateHistory = userWinRateHistoryList.FirstOrDefault(e => e.LineType == 4);
                    
                    if(userWinRateHistory == null)
                        return;
                    
                    userWinRateHistory.LoseCount++;

                    await AccountDB.SetUserWinRateHistoryAsync(userWinRateHistory);
                }
                else if (i == 2)
                {
                    var userWinRateHistoryList = await AccountDB.GetUserWinRateHistoryAsync(user.Seq);
                    var userWinRateHistory = userWinRateHistoryList.FirstOrDefault(e => e.LineType == 3);
                    
                    if(userWinRateHistory == null)
                        return;
                    
                    userWinRateHistory.LoseCount++;

                    await AccountDB.SetUserWinRateHistoryAsync(userWinRateHistory);
                }
                else if (i == 3)
                {
                    var userWinRateHistoryList = await AccountDB.GetUserWinRateHistoryAsync(user.Seq);
                    var userWinRateHistory = userWinRateHistoryList.FirstOrDefault(e => e.LineType == 2);
                    
                    if(userWinRateHistory == null)
                        return;
                    
                    userWinRateHistory.LoseCount++;

                    await AccountDB.SetUserWinRateHistoryAsync(userWinRateHistory);
                }
                else if (i == 4)
                {
                    var userWinRateHistoryList = await AccountDB.GetUserWinRateHistoryAsync(user.Seq);
                    var userWinRateHistory = userWinRateHistoryList.FirstOrDefault(e => e.LineType == 1);
                    
                    if(userWinRateHistory == null)
                        return;
                    
                    userWinRateHistory.LoseCount++;

                    await AccountDB.SetUserWinRateHistoryAsync(userWinRateHistory);
                }
            }
        }
    }
}
