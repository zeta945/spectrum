using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public class Scene
    {
        SceneNode _root = new SceneNode();

        public SceneNode Root
        {
            get { return _root; }
        }

        public ShapeNode CreateSphere(float radius)
        {
            ShapeNode shape = new ShapeNode();
            var sphere = new SphereShape(radius);
            shape.Shape = sphere;
            return shape;
        }


    }
}
