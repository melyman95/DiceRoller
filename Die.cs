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
        public byte FaceValue { get; private set; }

        public bool IsHeld { get; set; }

        public byte RollDie()
        {
            Random r = new Random();

            byte DieValue = (byte)r.Next(1, 6);

            return DieValue;
        }
    }
}
