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
            float sx = SMath.Tan(fovHalfRadianX) * _camera.Near * x;
            float sy = SMath.Tan(fovHalfRadianY) * _camera.Near * y;

            Vector3 o = _cameraTransform.Translation;
            Vector3 right = _cameraTransform.RightVector;
            Vector3 forward = _cameraTransform.ForwardVector;
            Vector3 up = _cameraTransform.UpVector;
            float d = _camera.Near;
            Vector3 dir = right * sx + up * sy + forward * d;
            dir.Normalize();
            return new Ray(o, dir);
        }

        public float Trace(Ray ray)
        {

            List<ShapeNode> allShapeNodes = new List<ShapeNode>();
            _scene.Root.GetChildren(allShapeNodes, true);

            float bestDist = -1;
            foreach (var v in allShapeNodes)
            {
                float dist = v.Trace(ray);
                if(dist >= 0)
                {
                    if(bestDist < 0)
                    {
                        bestDist = dist;
                    }
                    else
                    {
                        bestDist = SMath.Min(bestDist, dist);
                    }
                }
            }
            return bestDist;
        }
    }

}
