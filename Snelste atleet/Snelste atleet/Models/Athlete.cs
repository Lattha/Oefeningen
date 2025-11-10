using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snelste_atleet.Models
{
    internal class Athlete
    {
        public string Name { get; set; }
        public int Time { get; set; }

        public Athlete() { }

        public Athlete(string name, int time) 
        { 
            Name = name;
            Time = time;
        }

        public string FormattedTime   // extra property om tijd als uu:mm:ss te tonen
        {
            get
            {
                TimeSpan timespan = TimeSpan.FromSeconds(Time);
                return timespan.ToString(@"hh\:mm\:ss");
            }
        }

    }
}
