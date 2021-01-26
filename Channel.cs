using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ar8600
{
    class Channel
    {
        public string Frequency { get; set; }
        public string Modulation { get; set; }
        public string Attenuation { get; set; }
        public string Squelch { get; set; }

        public Channel(string freq, string mod, string att, string squel)
        {
            Frequency = freq;
            Modulation = mod;
            Attenuation = att;
            Squelch = squel;
        }

        public Channel()
        {

        }
    }
}
