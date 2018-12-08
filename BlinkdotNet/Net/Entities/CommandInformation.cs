using System;

namespace BlinkdotNet.Net.Entities
{
    public class CommandInformation
    {
        public int id{ get; set; }
        public DateTime created_at{ get; set; }
        public DateTime updated_at{ get; set; }
        public DateTime execute_time{ get; set; }
        public string command{ get; set; }
        public string state_stage{ get; set; }
        public DateTime stage_rest{ get; set; }
        public string stage_cs_db{ get; set; }
        public string stage_cs_sent{ get; set; }
        public string stage_sm{ get; set; }
        public string stage_dev{ get; set; }
        public string stage_is{ get; set; }
        public string stage_lv{ get; set; }
        public string stage_vs{ get; set; }
        public string state_condition{ get; set; }
        public string sm_ack{ get; set; }
        public string lfr_ack{ get; set; }
        public string sequence{ get; set; }
        public int attempts{ get; set; }
        public string transaction{ get; set; }
        public string player_transaction{ get; set; }
        public string server{ get; set; }
        public string duration{ get; set; }
        public string by_whom{ get; set; }
        public bool diagnostic{ get; set; }
        public string debug{ get; set; }
        public string target{ get; set; }
        public string target_id{ get; set; }
        public string parent_command_id{ get; set; }
        public int camera_id{ get; set; }
        public string siren_id{ get; set; }
        public string firmware_id{ get; set; }
        public int network_id{ get; set; }
        public int account_id{ get; set; }
        public int sync_module_id{ get; set; }
    }
}