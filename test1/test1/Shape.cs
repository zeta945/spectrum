using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public class Shape
    {

        public virtual float Trace(Ray ray)
        {
            return -1.0f;
        }
    }
}
