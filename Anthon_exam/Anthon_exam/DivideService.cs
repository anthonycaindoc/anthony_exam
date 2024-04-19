using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anthon_exam
{
    public class DivideService
    {
        public void Divide(int num, int denom)
        {
            try
            {
                var result = num / denom;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
