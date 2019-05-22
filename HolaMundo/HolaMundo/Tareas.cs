using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Tareas
    {
        long var = 0;
        public long Sumar()
        {//como el numero es muy grande es de tipo long junto con el i

            for(long i= 1; i<=100000000; i++)
            {
                var = var + i;
            }

            return var;
        }
    }
}
