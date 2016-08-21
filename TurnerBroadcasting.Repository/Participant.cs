
namespace TurnerBroadcasting.Repository
{
    public class Participant
    {
        public int ParticipantId { get; set; }
        public string Name { get; set; }        
        public bool IsKey { get; set; }
        public string RoleType { get; set; }  //could be an enum
        public bool IsOnScreen { get; set; }
        public string ParticipantType { get; set; } 
    }
}
