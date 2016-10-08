using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public struct Vector3
    {
        public float x, y, z;

        public static Vector3 Zero = new Vector3(0, 0, 0);
        public static Vector3 One = new Vector3(1, 1, 1);

        public Vector3(float xx, float yy, float zz)
        {
            x = xx; y = yy; z = zz;
        }
    }
}
