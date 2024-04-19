using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anthon_exam
{
    public class DateConverter
    {
        public void ConvertDate(string dateStr)
        {
            var result = DateTime.TryParse(dateStr, out DateTime date);

            if (result)
            {
                Console.WriteLine(date);
            }
            else
            {
                Console.WriteLine("String is not a valid date.");
            }
        }
    }
}
