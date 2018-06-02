using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class Or : Node
    {
        Node _Left;
        public Node Left { get { return _Left; } }
        Node _Right;
        public Node Right { get { return _Right; } }
        Type _Type;
        public override Type Type { get { return _Type; } }
        public Or(Node Left, Node Right)
        {
            _Left = Left;
            _Right = Right;
            if (_Left.Type == _Right.Type) { _Type = _Left.Type; }
            else if (_Left.Type == null) { _Type = _Right.Type; }
            else { _Type = Left.Type; }
        }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectOr(this); }
    }
}
