using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor
{
    class ExtractMethod
    {
        public void Compute(int age)
        {
            List<string> users = new List<string>();

            foreach (string user in users)
            {
                Console.Write($"Test: {user} {age}");
            }
        }
    }
}
