using System;
using System.Collections.Generic;
using MongoRepository;

namespace TurnerBroadcasting.Repository
{
    public class Title : Entity
    {
        public int TitleId { get; set; }
        public string TitleName { get; set; }
        public string TitleNameSortable { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ReleaseYear { get; set; }
        public IEnumerable<AwardInfo> Awards { get; set; }
        public IEnumerable<string> Genres { get; set; }
        public IEnumerable<OtherName> OtherNames { get; set; }
        public IEnumerable<Participant> Participants { get; set; }
        public IEnumerable<Storyline> StoryLines { get; set; }
    }
}
