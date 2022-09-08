using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    internal class Class1
    {
        public int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int this[int max]
        {
            get
            {
                if (max >= 10)
                {
                    return max;

                }
            }
        }
    }   
}
