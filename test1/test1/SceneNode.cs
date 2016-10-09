using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public class SceneNode
    {
        Transform _localTransform = Transform.Identity;
        SceneNode _parent;
        List<SceneNode> _children;

        public SceneNode()
        {
            
        }

        public void AddChild(SceneNode child)
        {
            if (child._parent != null)
                throw new Exception();

            if (_children == null)
                _children = new List<SceneNode>();
            _children.Add(child);

            child._parent = this;
        }

        public Transform LocalTransform
        {
            get { return _localTransform; }
            set { _localTransform = value; }
        }

        public Transform WorldTransform
        {
            get
            {
                if (_parent == null)
                    return _localTransform;
                return _parent.WorldTransform * _localTransform;
            }
        }

        public void GetChildren(List<SceneNode> children)
        {
            children.AddRange(_children);
        }

        public void GetChildren<T>(List<T> children, bool includeAllDescendants = false) where T: SceneNode
        {
            if (_children == null)
                return;
                
            foreach(var v in _children)
            {
                var c = v as T;
                if(c != null)
                {
                    children.Add(c);
                }
                if(includeAllDescendants)
                {
                    v.GetChildren<T>(children, includeAllDescendants);
                }
            }
        }

    }
}
