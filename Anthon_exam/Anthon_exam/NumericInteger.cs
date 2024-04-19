using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anthon_exam
{
    public class NumericInteger
    {
        public void Validate(int num)
        {
            if (num < 0 || num > 1000)
                throw new Exception("Number must be greater than or equal to 0 and less than or equal to 1000.");

            Console.WriteLine(num);
        }
    }
}
