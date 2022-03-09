using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class RollingDice
    {
        ///<summary>
        /// UC2- Dice is Rolled.
        ///</summary>

        public static void DiceRoll()
        {
            Random dice = new Random();
            int roll = dice.Next(1, 7);
            Console.WriteLine("Number After Rolling : " + roll);
        }
    }
}