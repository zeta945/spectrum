using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public class SceneNode
    {
        Transform _localTransform;
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

    }
}
