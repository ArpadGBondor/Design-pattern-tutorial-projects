using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublishSubscribe.PatternVersion
{
    public class Location
    {
        public enum AtmosphereType
        {
            Normal,
            Poisonous
        }

        public AtmosphereType Atmosphere { get; set; }
    }
}
