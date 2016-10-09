using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public class ShapeNode : SceneNode
    {
        Shape _shape;

        public ShapeNode()
        {

        }

        public Shape Shape
        {
            get { return _shape; }
            set { _shape = value; }
        }

        public float Trace(Ray ray)
        {
            if(_shape != null)
            {
                Transform worldTransformInv = WorldTransform.Inverse;

                Ray localRay = ray.Transform(worldTransformInv);
                return _shape.Trace(localRay);
            }

            return -1.0f;
        }
    }
}
