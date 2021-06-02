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

            // Extract part of method that make sense to keep
            // on its own.
            LoopMethod(users, age);
        }

        private void LoopMethod(List<string> users, int age)
        {
            foreach (string user in users)
            {
                Console.Write($"Test: {user} {age}");
            }
        }
    }
}
