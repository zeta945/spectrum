using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public struct Quaternion
    {
        Vector4 _vec;

        public static Quaternion Identity = new Quaternion(0, 0, 0, 1);

        public Quaternion(float x, float y, float z, float w)
        {
            _vec = new Vector4(x, y, z, w);
        }
    }
}
