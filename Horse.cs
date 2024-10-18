﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacing
{
    public class Horse
    {
        //Each horse should have (at minimum) a name, date of birth and unique horseID.
        public string name;
        public DateOnly dateOfBirth;
        public int horseID;

        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public DateOnly DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public int HorseID
        {
            get { return horseID; }
            set { horseID = value; }

        }

        public Horse(string name, DateOnly dateOfBirth, int horseID)
        {
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
            this.HorseID = horseID;
        }


    }

}
