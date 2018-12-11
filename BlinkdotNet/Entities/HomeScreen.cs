using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BlinkdotNet.Entities
{
    [DataContract]
    public class HomeScreen
    {
        [DataMember(Name ="account")]
        public Account Account { get; set; }

        [DataMember(Name = "network")]
        public Network Network { get; set; }

        [DataMember(Name = "devices")]
        public List<Device> Devices { get; set; }
    }
}
