using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anthon_exam
{
    public class NumberRoots
    {
        public void FindRoot(int number)
        {
            if (number < 0)
                Console.WriteLine("Number must not be a negative number.");
            else
                Console.WriteLine(Math.Pow(number, 1.0 / 2));
        }
    }
}
