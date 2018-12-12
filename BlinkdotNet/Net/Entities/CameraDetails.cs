using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using BlinkdotNet.Entities;

namespace BlinkdotNet.Net.Entities
{
    [DataContract]
    internal class CameraDetails
    {
        [DataMember(Name ="camera_status")]
        public Camera Camera{ get; set; }
    }
}
