using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anthon_exam
{
    public class AverageComputation
    {
        public void Compute(IEnumerable<int> nums)
        {
            if (!nums.Any())
                Console.WriteLine("List must not be empty.");

            Console.WriteLine(Queryable.Average(nums.AsQueryable()));
        }
    }
}
