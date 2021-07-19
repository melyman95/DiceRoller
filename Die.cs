using System;
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
        Random r;
        public Die()
        {
            // Roll die on creation to generate first random number.
            r = new Random();
            RollDie();
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
