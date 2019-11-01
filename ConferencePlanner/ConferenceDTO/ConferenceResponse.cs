using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceDTO
{
    public class ConferenceResponse : Conference
    {
        public ICollection<Session> Sessions { get; set; } = new List<Session>();

        public ICollection<Track> Tracks { get; set; } = new List<Track>();

        public ICollection<Speaker> Speakers { get; set; } = new List<Speaker>();
    }
}
