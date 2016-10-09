using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{


    public class RenderOutput
    {
        int _width;
        int _height;

        public RenderOutput(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public int Width
        {
            get { return _width; }
        }

        public int Height
        {
            get { return _height; }
        }
    }

    public class Renderer
    {
        

        public Renderer()
        {

        }

        public void Render(RenderView view, RenderOutput output)
        {
            for(int i = 0; i < output.Height; i++)
            {
                float y = ((float)i / output.Height - 0.5f) * 2;
                for(int j = 0; j < output.Width; j++)
                {
                    float x = ((float)j / output.Width - 0.5f) * 2;
                    Ray ray = view.GenerateRay(x, y);

                    float dist = view.Trace(ray);
                    if(dist >= 0)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write("=");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
