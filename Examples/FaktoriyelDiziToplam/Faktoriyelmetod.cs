using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaktoriyelDiziToplam
{
    class Faktoriyelmetod
    {
        public static int factor(int n)
        {

            int factor = 1;
                        
            for (int i = 1; i <= n; i++)
            {
                factor *= i; 
            }

            return factor;
        }

        public static decimal islem(decimal x)
        {



            return 0;
        }
    }
}
