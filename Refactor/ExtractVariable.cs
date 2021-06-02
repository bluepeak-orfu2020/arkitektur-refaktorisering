using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor
{
    class ExtractVariableBad
    {
        public void Compute(int x)
        {
            if (x * 2 == 5 || x - 10 == 15)
            {
                // Do stuff
            }
        }
    }

    class ExtractVariableGood
    {
        public void Compute(int x)
        {
            bool isCondition1 = x * 2 == 5;
            bool isCondition2 = x - 10 == 15;

            // Extract the parts of the condition makes the
            // if statement easier to read as a whole
            // and by using good variable names also make the
            // parts' purpose easier to understand.
            if (isCondition1 || isCondition2)
            {
                // Do stuff
            }
        }
    }
}
