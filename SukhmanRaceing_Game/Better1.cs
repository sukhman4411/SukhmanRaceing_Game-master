﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SukhmanRaceing_Game
{
    public class Better1 : Factory
    {
        public override int Amt()
        {
            return 50;
        }


        public int getData(int Amount) {
            Factory obj;
            obj = new Better1();
            if (obj.Amt() >= Amount)
            {
                return Amount;
            }
            else {
                return 0;
            }
        }
    }
}
