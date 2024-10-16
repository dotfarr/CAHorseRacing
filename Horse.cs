using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacing
{
    internal class Horse
    {
        //Each horse should have (at minimum) a name, date of birth and unique horseID.
        public string name;
        public DateOnly dateofbirth;
        public int horseID;

        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public DateOnly DateOfBirth
        {
            get { return dateofbirth; }
            set { dateofbirth = value; }
        }

        public int HorseID
        {
            get { return horseID; }
            set { horseID = value; }

        }

        public Horse(string name, DateOnly dateOfBirth, int horseID)
        {
            this.name = name;
            this.DateOfBirth = dateOfBirth;
            this.horseID = horseID;
        }

    }

}
