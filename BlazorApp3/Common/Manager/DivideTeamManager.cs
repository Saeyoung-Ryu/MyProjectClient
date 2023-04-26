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
            
            if (isRandomLine)
            {
                for (int i = 0; i < userInfos.Count; i++)
                {
                    if (userInfos[i].LineType != LineType.Random)
                    {
                        lineTypes.Remove(userInfos[i].LineType);
                        // userInfos.Remove(userInfos[i]);
                        userTeamDivideInfos.Add(userInfos[i]);
                    }
                    else
                    {
                        Random random = new Random();
                        int randomNumber = random.Next(lineTypes.Count);
                        userInfos[i].LineType = lineTypes[randomNumber];
                    
                        lineTypes.Remove(userInfos[i].LineType);
                        // userInfos.Remove(userInfos[i]);
                        userTeamDivideInfos.Add(userInfos[i]);
                    }
                }
            }

            return userTeamDivideInfos;
        }
    }
}
