using System.Collections.Generic;
using System.Runtime.Serialization;
using BlinkdotNet.Entities;

namespace BlinkdotNet.Net.Entities
{
    [DataContract]
    internal class CameraCollection
    {
        [DataMember(Name ="devicestatus")]
        public List<Camera> Cameras { get; set; }
    }
}