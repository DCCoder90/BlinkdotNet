using System;
using System.Collections.Generic;
using System.Text;

namespace BlinkdotNet.Entities
{
    public class Programs
    {
            public int id { get; set; }
            public int network_id { get; set; }
            public string status { get; set; }
            public string name { get; set; }
            public List<Schedule> schedule { get; set; }
            public string format { get; set; }
    }
}
