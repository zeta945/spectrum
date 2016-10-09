using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public struct Vector4
    {
        public float x, y, z, w;

        public Vector4(float xx, float yy, float zz, float ww)
        {
            x = xx;y = yy;z = zz;w = ww;
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}", x, y, z, w);
        }
    }
}
