using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anthon_exam
{
    public class UppercaseConverter
    {
        public void ConvertUpper(string str)
        {
			try
			{
                Console.WriteLine(str.ToUpper());
			}
			catch (NullReferenceException ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}
