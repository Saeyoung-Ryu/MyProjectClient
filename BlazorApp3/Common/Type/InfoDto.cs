using RiotSharp.Endpoints.MatchEndpoint;

namespace BlazorApp3.Common.Type;

public class InfoDto
{
    public List<ParticipantDto> Participants { get; set; }

    public List<ParticipantDto> GetMyTeamParticipantDtos(string myPuuid)
    {
        var myWinLose = Participants.First(e => e.Puuid == myPuuid).Win;
        return Participants.Where(e => e.Win == myWinLose).ToList();
    }
}