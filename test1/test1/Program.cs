using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Scene scene = new Scene();
            scene.Root.AddChild(scene.CreateSphere(10));

            Camera cam = Camera.CreatePerspective(90, 16.0f / 9.0f, 1, 1000);
            RenderView view = new RenderView(scene, cam, Transform.Identity);

            Renderer r = new Renderer();
            r.Render(view);

        }
    }
}
