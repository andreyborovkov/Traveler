﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveler
{
    public class Beach
    {
        //fields
        private string eyeColor;
        private double shoeSize;

        //properties
        public string GetColor
        {
            get { return this.eyeColor; }
            set { this.eyeColor = value; }
        }
        public double GetShoeSize
        {
            get { return this.shoeSize; }
            set { this.shoeSize = value; }
        }

        public Beach()
        {

        }
        public Beach(string input)
        {
            this.GetColor = input;
        }

        public string GetBeach(string eyeColor)
        {
            if (eyeColor=="green")
            {
                return "Seal Beach";
            }
            else if (eyeColor=="brown")
            {
                return "Newport Beach";
            }
            else if (eyeColor=="grey")
            {
                return "Huntington Beach";
            }
            else
            {
                return " ";
            }

        }
        public string GetHotel(double num, string value)
        {
            if ((num == 10)&&(value == "Seal Beach"))
            {
                return "Hilton";
            }
            return null;
        }
    }
}
