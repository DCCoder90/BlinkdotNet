using System.Collections.Generic;

namespace BlinkdotNet.Entities
{
    public class Schedule
    {
        public string action { get; set; }
        public List<string> devices { get; set; }
        public List<string> dow { get; set; }
        public int id { get; set; }
        public string time { get; set; }
    }
}