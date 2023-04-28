using System;
using BlazorApp3.Common.Enum;
using BlazorApp3.Common.Type;

namespace BlazorApp3.Common.Manager
{
    public class DivideTeamManager
    {
        public static List<UserTeamDivideInfo> DivideTeam(List<UserTeamDivideInfo> userInfos, bool isRandomLine = true, bool isRandomChamp = false)
        {
            List<UserTeamDivideInfo> userTeamDivideInfos = new List<UserTeamDivideInfo>();

            List<LineType> lineTypes = new List<LineType>(System.Enum.GetValues(typeof(LineType)).Cast<LineType>());
            lineTypes.AddRange(lineTypes);
            lineTypes.RemoveAll(e => e == LineType.Random);

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
                    randomLaneUserInfos[i].LineType = lineTypes[randomNumber];
                    
                    lineTypes.Remove(randomLaneUserInfos[i].LineType);
                    userTeamDivideInfos.Add(randomLaneUserInfos[i]);
                }
            }

            return userTeamDivideInfos;
        }
    }
}
