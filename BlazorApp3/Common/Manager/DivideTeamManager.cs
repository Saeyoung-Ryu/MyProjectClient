using System;
using BlazorApp3.Common.Enum;
using BlazorApp3.Common.Type;

namespace BlazorApp3.Common.Manager
{
    public class DivideTeamManager
    {
        public static List<UserTeamDivideInfo> DivideTeam(List<UserTeamDivideInfo> userInfos, bool isRandomLine = true, bool isRandomChamp = false)
        {
            if (!CheckIfTeamIsDividable(userInfos))
                return userInfos;
            
            List<UserTeamDivideInfo> userTeamDivideInfos = new List<UserTeamDivideInfo>();

            List<LineType> lineTypes = new List<LineType>(System.Enum.GetValues(typeof(LineType)).Cast<LineType>());
            lineTypes.AddRange(lineTypes);
            lineTypes.RemoveAll(e => e == LineType.Random || e == LineType.None);

            var fixedLaneUserInfos = userInfos.Where(e => e.LineType != LineType.Random).ToList();
            var randomLaneUserInfos = userInfos.Where(e => e.LineType == LineType.Random).ToList();
            
            if (isRandomLine)
            {
                for (int i = 0; i < fixedLaneUserInfos.Count; i++)
                {
                    lineTypes.Remove(fixedLaneUserInfos[i].LineType);
                    userTeamDivideInfos.Add(fixedLaneUserInfos[i]);
                }

                for (int i = 0; i < randomLaneUserInfos.Count; i++)
                {
                    Random random = new Random();
                    int randomNumber = random.Next(lineTypes.Count);

                    while (randomLaneUserInfos[i].ExceptionLine == lineTypes[randomNumber])
                    {
                        randomNumber = random.Next(lineTypes.Count);
                    }
                    
                    randomLaneUserInfos[i].LineType = lineTypes[randomNumber];
                    
                    lineTypes.Remove(randomLaneUserInfos[i].LineType);
                    userTeamDivideInfos.Add(randomLaneUserInfos[i]);
                }
            }

            return userTeamDivideInfos;
        }

        private static bool CheckIfTeamIsDividable(List<UserTeamDivideInfo> userInfos)
        {
            var noSupCount = userInfos.Count(e => e.ExceptionLine == LineType.Support);
            var noAdcCount = userInfos.Count(e => e.ExceptionLine == LineType.Adc);
            var noMidCount = userInfos.Count(e => e.ExceptionLine == LineType.Mid);
            var noJungleCount = userInfos.Count(e => e.ExceptionLine == LineType.Jungle);
            var noTopCount = userInfos.Count(e => e.ExceptionLine == LineType.Top);
            
            if (noSupCount > 8 || noAdcCount > 8 || noMidCount > 8 || noJungleCount > 8 || noTopCount > 8)
                return false;

            return true;
        }
    }
}
