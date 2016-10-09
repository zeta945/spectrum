using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public struct Transform
    {
        Vector3 _translation;
        Quaternion _rotation;
        Vector3 _scale;

        public Transform(Vector3 translation, Quaternion rotation, Vector3 scale)
        {
            _translation = translation;
            _rotation = rotation;
            _scale = scale;

        }

        public void SetIdentity()
        {
            _translation = Vector3.Zero;
            _rotation = Quaternion.Identity;
            _scale = Vector3.One;
        }


        public Vector3 Translation
        {
            get { return _translation; }
            set { _translation = value; }
        }

        public Quaternion Rotation
        {
            get { return _rotation; }
        }

        public Vector3 Scale
        {
            get { return _scale; }
        }

        public Vector3 ForwardVector
        {
            get
            {
                return _rotation.RotateVector(Vector3.Forward).Normalized;
            }
        }

        public Vector3 RightVector
        {
            get
            {
                return _rotation.RotateVector(Vector3.Right).Normalized;
            }
        }

        public Vector3 UpVector
        {
            get
            {
                return _rotation.RotateVector(Vector3.Up).Normalized;
            }
        }

        public Transform Inverse
        {
            get
            {
                Quaternion newRotation = Rotation.Inverse;
                Vector3 newScale = new Vector3(1.0f / Scale.x, 1.0f / Scale.y, 1.0f / Scale.z);
                Vector3 newTranslation = newRotation.RotateVector(newScale * -Translation);
                return new Transform(newTranslation, newRotation, newScale);
            }

        }

        public Vector3 TransformVector(Vector3 v)
        {
            Vector3 result = Rotation.RotateVector(v * Scale);
            return result;
        }

        public Vector3 TransformPosition(Vector3 p)
        {
            Vector3 result = Rotation.RotateVector(p * Scale) + Translation;
            return result;
        }

        public static Transform operator*(Transform a, Transform b)
        {
            Quaternion newRotation = a.Rotation * b.Rotation;
            Vector3 newTranslation = b.Rotation.RotateVector(a.Translation * b.Scale) + b.Translation;
            Vector3 newScale = a.Scale * b.Scale;
            return new Transform(newTranslation, newRotation, newScale);
        }

        public static readonly Transform Identity = new Transform(Vector3.Zero, Quaternion.Identity, Vector3.One);
    }
}
