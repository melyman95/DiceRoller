using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    /// <summary>
    /// Represents a six-sided die like one used in Monopoly games.
    /// </summary>
    class Die
    {
        /// <summary>
        /// face value of die.
        /// </summary>
        /// 
        // static fields are shared across all instances of a class.
        static Random r;
        byte minValue;
        byte maxValue;

        static Die() // static, so called only once for all instances of the class.
        {
            r = new Random();
        }
        public Die():this(1, 7)
        {
            // Roll die on creation to generate first random number.
        }

        public Die(byte minValue, byte maxValue)
        {
            // Create die with numbers between 1 and 6, inclusive lower bound.
            this.minValue = minValue;
            this.maxValue = maxValue;
            RollDie();
        }
        public byte FaceValue { get; private set; }

        public bool IsHeld { get; set; }

        /// <summary>
        /// Rolls random value between 1 and 6.
        /// Return the newly rolled value.
        /// If the die is held, the current value will be returned.
        /// </summary>
        /// <returns></returns>

        public byte RollDie()
        {
            const int offset = 1;
            if (!IsHeld) // Die is not held.
            {
                int DieValue = r.Next(minValue, maxValue + offset);
                FaceValue = (byte)DieValue;
            }

            return FaceValue;
        }
    }
}
