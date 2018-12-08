using System;
using System.Collections.Generic;
using System.Text;

namespace BlinkdotNet.Net.Entities
{
    public class SensorInformation
    {
        public int lfr { get; set; }
        public int wifi { get; set; }
        public DateTime updated_at { get; set; }
        public int temp { get; set; }
        public int battery { get; set; }
    }
}
