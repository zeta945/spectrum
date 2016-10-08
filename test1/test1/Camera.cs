using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public class Camera
    {
        float _fov;
        float _near;
        float _far;
        float _width;
        float _height;
        bool _isPerspective;

        Camera(float fov, float near, float far, float width, float height)
        {
            _fov = fov;
            _near = near;
            _far = far;
            _width = width;
            _height = height;
            _isPerspective = true;
        }

        Camera(float width, float height, float near, float far)
        {
            _width = width;
            _height = height;
            _near = near;
            _far = far;
            _isPerspective = false;
        }

        public bool IsPerspective
        {
            get { return _isPerspective; }
        }

        public float FOV
        {
            get { return _fov; }
        }

        public float Near
        {
            get { return _near; }
        }

        public float Far
        {
            get { return _far; }
        }

        public float Width
        {
            get { return _width; }
        }

        public float Height
        {
            get { return _height; }
        }

        public float Aspect
        {
            get { return _width / _height; }
        }

        public static Camera CreatePerspective(float fov, float aspect, float near, float far)
        {
            return new test1.Camera(fov, near, far, aspect, 1);
        }

        public static Camera CreateOrthogonal(float width, float height, float near, float far)
        {
            return new test1.Camera(width, height, near, far);
        }
    }
}
