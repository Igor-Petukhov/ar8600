using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ar8600
{
    public class Channel : ICloneable
    {
        public decimal Frequency { get; set; }
        public string Modulation { get; set; }
        public string Attenuation { get; set; }
        public int Squelch { get; set; }

        public Channel(decimal freq, string mod, string att, int squel)
        {
            Frequency = freq;
            Modulation = mod;
            Attenuation = att;
            Squelch = squel;
        }

        public Channel()
        {
            Frequency = 100;
            Modulation = "";
            Attenuation = "AT0";
            //Squelch;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
