using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLinq
{
    public static class Methods
    {
        public static void PrintEnumerable(IEnumerable<string> enumerable)
        {
            foreach (string item in enumerable)
                Console.WriteLine(item);
        }
    }
}
