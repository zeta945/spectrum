using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public struct Transform
    {
        public Vector3 _position;
        public Quaternion _rotation;
        public Vector3 _scale;

        public Transform(Vector3 position, Quaternion rotation, Vector3 scale)
        {
            _position = position;
            _rotation = rotation;
            _scale = scale;

        }

        public void SetIdentity()
        {
            _position = Vector3.Zero;
            _rotation = Quaternion.Identity;
            _scale = Vector3.One;
        }



        public static readonly Transform Identity = new Transform(Vector3.Zero, Quaternion.Identity, Vector3.One);
    }
}
