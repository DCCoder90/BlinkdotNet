using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using BlinkdotNet.Entities;

namespace BlinkdotNet.Net.Entities
{
    [DataContract]
    internal class Syncmodule
    {
        [DataMember(Name ="syncmodule")]
        public Module Module{ get; set; }
    }
}
