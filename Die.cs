﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    /// <summary>
    /// Represents an individual dice.
    /// </summary>
    class Die
    {
        /// <summary>
        /// face value of die.
        /// </summary>
        /// 
        // static fields are shared across all instances of a class.
        static Random r;

        static Die() // static, so called only once for all instances of the class.
        {
            r = new Random();
        }
        public Die()
        {
            if (r == null)
            {
                r = new Random();
            }
            else
            {
                // Roll die on creation to generate first random number.
                RollDie();
            }
        }
        public byte FaceValue { get; private set; }

        public bool IsHeld { get; set; }

        public byte RollDie()
        {
            int DieValue = r.Next(1, 7);
            FaceValue = (byte)DieValue;

            return FaceValue;
        }
    }
}
