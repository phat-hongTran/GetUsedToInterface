﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetUsedToInterface
{
    interface IClown
    {
        string FunnyThingIHave { get; }
        void Honk();

        protected static Random random = new Random();

        private static int carCapacity = 12;
        public static int CarCapacity
        {
            get { return carCapacity; }
            set
            {
                if (value > 10) carCapacity = value;
                else Console.Error.WriteLine($"Warning: Car capacity {value} is too small");
            }
        }

        public static string ClownCarDescription()
        {
            return $"A clown car with {random.Next(CarCapacity / 2, CarCapacity)} clowns";
        }
    }
}
