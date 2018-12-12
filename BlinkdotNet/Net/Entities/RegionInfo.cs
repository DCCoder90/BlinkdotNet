using System.Runtime.Serialization;

namespace BlinkdotNet.Net.Entities
{
    [DataContract]
    internal class RegionInfo<T>
    {
        [DataMember(Name ="preferred")]
        public string Preferred { get; set; }

        [DataMember(Name ="regions")]
        public T Regions { get; set; }
    }
}