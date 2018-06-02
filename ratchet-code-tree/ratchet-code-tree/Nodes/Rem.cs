using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class Rem : Node
    {
        Node _Left;
        public Node Left { get { return _Left; } }
        Node _Right;
        public Node Right { get { return _Right; } }

        public Rem(Node Left, Node Right)
        {
            _Left = Left;
            _Right = Right;
        }

        internal override void Inspect(Inspector Inspector) { Inspector.InspectRem(this); }
    }
}
