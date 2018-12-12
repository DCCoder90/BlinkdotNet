using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BlinkdotNet.Entities
{
    [DataContract]
    public class Client
    {
        [DataMember(Name ="id")]
        public int Id { get; set; }

        [DataMember(Name ="created_at")]
        public DateTime Created { get; set; }

        [DataMember(Name ="updated_at")]
        public DateTime Updated { get; set; }

        [DataMember(Name ="name")]
        public string Name { get; set; }

        [DataMember(Name ="notify_sound")]
        public bool NotifySound { get; set; }

        [DataMember(Name = "client_type")]
        public string ClientType { get; set; }

        [DataMember(Name ="client_specifier")]
        public string ClientSpecifier { get; set; }

        [DataMember(Name ="notification_key")]
        public string NotificationKey { get; set; }

        [DataMember(Name ="aws_key")]
        public string AwsKey { get; set; }

        [DataMember(Name ="os_version")]
        public string OsVersion { get; set; }

        [DataMember(Name ="device_identifier")]
        public string DeviceIdentifier { get; set; }

        [DataMember(Name ="app_version")]
        public string AppVersion { get; set; }

        [DataMember(Name ="unique_id")]
        public string UniqueId { get; set; }

        [DataMember(Name ="home")]
        public string Home { get; set; }

        [DataMember(Name ="ssid")]
        public string SSID { get; set; }

        [DataMember(Name ="ssid_updated_at")]
        public DateTime SSIDUpdated { get; set; }

        [DataMember(Name = "enabled_notifications")]
        public bool EnabledNotifications { get; set; }

        [DataMember(Name ="client_options")]
        public string ClientOptions { get; set; }

        [DataMember(Name ="user_id")]
        public int UserId { get; set; }

        [DataMember(Name ="account_id")]
        public int AccountId { get; set; }
    }
}
