using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{

    public class RenderView
    {
        Scene _scene;
        Camera _camera;
        Transform _cameraTransform;

        public RenderView(Scene scene, Camera camera, Transform cameraTransform)
        {
            _scene = scene;
            _camera = camera;
            _cameraTransform = cameraTransform;
        }

        public Ray GenerateRay(float x, float y)
        {
            float fovHalfRadianY = SMath.ToRadian(_camera.FOV * 0.5f);
            float fovHalfRadianX = fovHalfRadianY * _camera.Aspect;
            float sx = SMath.Tan(fovHalfRadianX) * _camera.Near;
            float sy = SMath.Tan(fovHalfRadianY) * _camera.Near;

        }
    }

    public class Renderer
    {
        

        public Renderer()
        {

        }

        public void Render(RenderView view)
        {

        }
    }
}
