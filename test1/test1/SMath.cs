using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public class SMath
    {
        public static readonly float PI = (float)Math.PI;

        static float _toRadian = PI / 180.0f;
        static float _toDegree = 180.0f / PI;
        
        public static float ToRadian(float degree) { return degree * _toRadian; }
        public static float ToDegree(float radian) { return radian * _toDegree; }
        public static float Tan(float rad) { return (float)Math.Tan(rad); }
    }
}
