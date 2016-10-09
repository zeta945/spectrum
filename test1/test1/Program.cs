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

            Camera cam = Camera.CreatePerspective(90, 1, 1, 1000);
            Transform camTrans = Transform.Identity;
            camTrans.Translation = new Vector3(0, -20, 0);
            RenderView view = new RenderView(scene, cam, camTrans);

            RenderOutput output = new RenderOutput(50, 50);
            Renderer r = new Renderer();
            r.Render(view, output);

        }
    }
}
