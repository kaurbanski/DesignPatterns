﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Flightless : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly!");
        }
    }
}
