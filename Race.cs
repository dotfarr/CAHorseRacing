using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HorseRacing
{
    internal class Race
    {
        public string racename;
        public TimeOnly starttime;

        public string RaceName
        {
            get { return racename; }
            set { racename = value; }

        }

        public TimeOnly StartTime
        {
            get { return starttime; }
            set { starttime = value; }

        }
    }
}
