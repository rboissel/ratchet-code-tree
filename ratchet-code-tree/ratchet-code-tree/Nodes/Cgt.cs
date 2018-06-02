using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ratchet.Code.Tree.Nodes
{
    public class Cgt : Node
    {
        Node _Left;
        public Node Left { get { return _Left; } }
        Node _Right;
        public Node Right { get { return _Right; } }

        public Cgt(Node Left, Node Right)
        {
            _Left = Left;
            _Right = Right;
        }
        public override Type Type { get { return typeof(Int32); } }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectCgt(this); }
    }
}
