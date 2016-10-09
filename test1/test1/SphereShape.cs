using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public class SphereShape : Shape
    {
        float _radius;

        public SphereShape(float radius)
        {
            _radius = radius;
        }

        public override float Trace(Ray ray)
        {
            //{ { t1 = - o.d - Sqrt[r ^ 2 + (o.d) ^ 2 - o.o]},{ t2 = - o.d + Sqrt[r ^ 2 + (o.d) ^ 2 - o.o]} }
            // o = ray's origin
            // d = ray's direction
            // r = sphere radius

            float o_dot_d = ray._origin.DotProduct(ray._direction);
            float o_dot_o = ray._origin.DotProduct(ray._origin);
            float r2 = _radius * _radius;

            if(o_dot_d <= 0)
            {
                float delta = r2 + o_dot_d * o_dot_d - o_dot_o;
                if(delta >= 0)
                {
                    float sqrtDelta = SMath.Sqrt(delta);
                    float t1 = -o_dot_d - sqrtDelta;

                    if (t1 < 0)
                    {
                        float t2 = -o_dot_d + sqrtDelta;
                        if (t2 >= 0)
                            return t2;
                    }
                    return t1;
                }

            }

            return -1.0f;
        }
    }
}
