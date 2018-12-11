using System.Runtime.Serialization;

namespace BlinkdotNet.Entities
{
    [DataContract]
    public class Account
    {
        [DataMember(Name = "notifications")]
        public int Notifications { get; set; }
    }
}