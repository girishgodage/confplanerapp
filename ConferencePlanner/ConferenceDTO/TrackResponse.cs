using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceDTO
{
    public class TrackResponse : Track
    {
        public Conference Conference { get; set; }

        public ICollection<Session> Sessions { get; set; } = new List<Session>();
    }
}
