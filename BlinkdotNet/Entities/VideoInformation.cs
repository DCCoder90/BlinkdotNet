using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BlinkdotNet.Entities
{
    [DataContract]
    public class VideoInformation
    {
        [DataMember(Name ="id")]
        public int Id { get; set; }

        [DataMember(Name ="created_at")]
        public DateTime Created { get; set; }

        [DataMember(Name ="updated_at")]
        public DateTime Updated { get; set; }

        [DataMember(Name ="camera_name")]
        public string CameraName { get; set; }

        [DataMember(Name ="description")]
        public string Description { get; set; }

        [DataMember(Name ="length")]
        public int Length { get; set; }

        [DataMember(Name ="size")]
        public int Size { get; set; }

        [DataMember(Name ="upload_time")]
        public int UploadTime { get; set; }

        [DataMember(Name ="viewed")]
        public DateTime Viewed { get; set; }

        [DataMember(Name ="locked")]
        public bool IsLocked { get; set; }

        [DataMember(Name ="ready")]
        public bool IsReady { get; set; }

        [DataMember(Name ="encryption")]
        public string Encryption { get; set; }

        [DataMember(Name ="encryption")]
        public string EncryptionKey { get; set; }

        [DataMember(Name ="storage_location")]
        public string Location { get; set; }

        [DataMember(Name ="thumbnail")]
        public string Thumbnail { get; set; }

        [DataMember(Name ="address")]
        public string Address { get; set; }

        [DataMember(Name ="account_id")]
        public int AccountId { get; set; }

        [DataMember(Name ="network_id")]
        public int NetworkId { get; set; }

        [DataMember(Name ="camera_id")]
        public int CameraId { get; set; }

        [DataMember(Name ="event_id")]
        public string EventId { get; set; }

        [DataMember(Name ="partial")]
        public bool IsPartial { get; set; }

        [DataMember(Name ="network_name")]
        public string NetworkName { get; set; }

        [DataMember(Name ="time_zone")]
        public string TimeZone { get; set; }
    }
}
