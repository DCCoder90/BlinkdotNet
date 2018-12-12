using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using BlinkdotNet.Entities;

namespace BlinkdotNet.Net.Entities
{
    [DataContract]
    internal class EventCollection
    {
        [DataMember(Name ="@event")]
        public List<Event> Events { get; set; }
    }
}
