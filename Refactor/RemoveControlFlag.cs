using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor
{
    class RemoveControlFlagBad
    {
        public void Compute()
        {
            string result = null;
            List<string> values = new List<string>();

            foreach (string value in values)
            {
                if (result == null && value.StartsWith("a"))
                {
                    result = value;
                }
            }

            Console.WriteLine($"Result: {result}");
        }
    }

    class RemoveControlFlagGood
    {
        public void Compute()
        {
            string result = null;
            List<string> values = new List<string>();

            foreach (string value in values)
            {
                if (value.StartsWith("a"))
                {
                    result = value;
                    // Use break to stop iterating in the loop
                    // as soon as we have the value we want
                    break;
                }
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}
