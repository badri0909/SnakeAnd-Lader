using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class Options
    {
        ///<summary>
        /// UC1- Options a rolled dice ca choose any one .
        ///</summary>
        public static void ChooseOptions()
        {
            Random opt = new Random();
            string[] options = { "No Play", "Ladder", "Snake" };
            int oIndex = opt.Next(options.Length);

            Console.WriteLine("Option choosed: {0} ", options[oIndex]);

        }
    }
}