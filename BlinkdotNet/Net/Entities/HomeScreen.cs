using System.Collections.Generic;
using System.Text;

namespace BlinkdotNet.Net.Entities
{
    public class HomeScreen
    {
        public Account account { get; set; }
        public Network network { get; set; }
        public List<Device> devices { get; set; }
    }
}
