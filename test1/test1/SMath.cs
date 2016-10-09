using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public class SMath
    {
        public const float PI = (float)Math.PI;
        public const float SmallNumber = 1.0e-8f;

        static float _toRadian = PI / 180.0f;
        static float _toDegree = 180.0f / PI;
        
        public static float ToRadian(float degree) { return degree * _toRadian; }
        public static float ToDegree(float radian) { return radian * _toDegree; }
        public static float Tan(float rad) { return (float)Math.Tan(rad); }
        public static float InvSqrt(float f) { return (float)(1.0 / Math.Sqrt(f)); }
        public static float Sqrt(float f) { return (float)Math.Sqrt(f); }
        public static float Min(float v1, float v2) { return v2 < v1 ? v2 : v1; }
    }
}
