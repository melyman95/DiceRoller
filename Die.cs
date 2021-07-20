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

        static Die() // static, so called only once for all instances of the class.
        {
            r = new Random();
        }
        public Die()
        {
                // Roll die on creation to generate first random number.
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
            if (!IsHeld) // Die is not held.
            {
                int DieValue = r.Next(1, 7);
                FaceValue = (byte)DieValue;
            }

            return FaceValue;
        }
    }
}
