using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anthon_exam
{
    public class IntegerConverter
    {
        public void ConvertToInt(string numStr)
        {
			try
			{
                Console.WriteLine(Convert.ToInt32(numStr));
			}
			catch (Exception)
			{
                Console.WriteLine("String is not a number");
			}
        }
    }
}
