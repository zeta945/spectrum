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

        public static readonly Vector3 Zero = new Vector3(0, 0, 0);
        public static readonly Vector3 One = new Vector3(1, 1, 1);
        public static readonly Vector3 Forward = new Vector3(0, 1, 0);
        public static readonly Vector3 Right = new Vector3(1, 0, 0);
        public static readonly Vector3 Up = new Vector3(0, 0, 1);

        public Vector3(float xx, float yy, float zz)
        {
            x = xx; y = yy; z = zz;
        }

        public Vector3 CrossProduct(Vector3 b)
        {
            return new Vector3(y * b.z - z * b.y,
                z * b.x - x * b.z,
                x * b.y - y * b.x);
        }

        public float DotProduct(Vector3 b)
        {
            return x * b.x + y * b.y + z * b.z;
        }

        public bool Normalize(float tolerance = SMath.SmallNumber)
        {
            float squareSum = DotProduct(this);
            if (squareSum > tolerance)
            {
                float scale = SMath.InvSqrt(squareSum);
                x *= scale; y *= scale; z *= scale;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2}", x, y, z);
        }

        public Vector3 Normalized
        {
            get
            {
                Vector3 n = this;
                n.Normalize();
                return n;
            }
        }

        public static Vector3 operator-(Vector3 v)
        {
            return new Vector3(-v.x, -v.y, -v.z);
        }

        public static Vector3 operator+(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        public static Vector3 operator *(Vector3 a, Vector3 b)
        {
            return new Vector3(a.x * b.x, a.y * b.y, a.z * b.z);
        }

        public static Vector3 operator*(Vector3 a, float t)
        {
            return new Vector3(a.x * t, a.y * t, a.z * t);
        }

        public static Vector3 operator *(float t, Vector3 a)
        {
            return new Vector3(a.x * t, a.y * t, a.z * t);
        }
    }
}
