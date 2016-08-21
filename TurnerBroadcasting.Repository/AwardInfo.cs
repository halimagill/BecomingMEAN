using System.Collections.Generic;

namespace TurnerBroadcasting.Repository
{
    public class AwardInfo
    {
        public string Award { get; set; }
        public int AwardYear { get; set; }
        public string AwardCompany { get; set; }
        public bool AwardWon { get; set; }
        public IEnumerable<string> Participants { get; set; }
    }
}
