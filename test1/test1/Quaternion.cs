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

        public Vector3 RotateVector(Vector3 v)
        {
            Vector3 q = new Vector3(X, Y, Z);
            Vector3 t = 2.0f * q.CrossProduct(v);
            Vector3 result = v + (W * t) + q.CrossProduct(t);
            return result;
        }

        public float X
        {
            get { return _vec.x; }
        }

        public float Y
        {
            get { return _vec.y; }
        }

        public float Z
        {
            get { return _vec.z; }
        }

        public float W
        {
            get { return _vec.w; }
        }


        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}", X, Y, Z, W);
        }

        public Quaternion Inverse
        {
            get { return new Quaternion(-X, -Y, -Z, W); }
        }

        public static Quaternion operator*(Quaternion a, Quaternion b)
        {

            // store intermediate results in temporaries
            float x = a.W * b.X + a.X * b.W + a.Y * b.Z - a.Z * b.Y;
            float y = a.W * b.Y - a.X * b.Z + a.Y * b.W + a.Z * b.X;
            float z = a.W * b.Z + a.X * b.Y - a.Y * b.X + a.Z * b.W;
            float w = a.W * b.W - a.X * b.X - a.Y * b.Y - a.Z * b.Z;

            // copy intermediate result to *this
            return new Quaternion(x, y, z, w);
        }
    }
}
