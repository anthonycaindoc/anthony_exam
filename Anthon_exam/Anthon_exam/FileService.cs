using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anthon_exam
{
    public class FileService
    {
        public void Open(string filepath)
        {
            if (File.Exists(filepath))
            {
                var file = File.ReadAllText(filepath);
                Console.WriteLine(file);
            }
            else
            {
                Console.WriteLine("File does not exists.");
            }
        }
    }
}
