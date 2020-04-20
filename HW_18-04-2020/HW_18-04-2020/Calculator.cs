using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_18_04_2020
{
    delegate T command<T>(T Gen1, T Gen2);

    class Calculator<T>
    {
        public static T SUM<T>(T Gen1, T Gen2)
        {
            return (dynamic)Gen1 + (dynamic)Gen2 ;
        }
      
    }
}
