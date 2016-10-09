using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public struct Ray
    {
        public Vector3 _origin;
        public Vector3 _direction;

        public Ray(Vector3 o, Vector3 dir)
        {
            _origin = o;
            _direction = dir;
        }

        public Ray Transform(Transform trans)
        {
            var newOrigin = trans.TransformPosition(_origin);
            var newDirection = trans.TransformVector(_direction);

            return new Ray(newOrigin, newDirection);
        }

        public override string ToString()
        {
            return string.Format("origin: {0}, direction: {1}", _origin, _direction);
        }
    }
}
