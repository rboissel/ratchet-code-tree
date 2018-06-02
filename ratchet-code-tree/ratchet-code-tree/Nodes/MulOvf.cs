using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class MulOvf : Node
    {
        Node _Left;
        public Node Left { get { return _Left; } }
        Node _Right;
        public Node Right { get { return _Right; } }
        bool _Unsigned;
        public bool Unsigned { get { return _Unsigned; } }
        public MulOvf(Node Left, Node Right, bool Unsigned)
        {
            _Left = Left;
            _Right = Right;
            _Unsigned = Unsigned;
        }

        internal override void Inspect(Inspector Inspector) { Inspector.InspectMulOvf(this); }
    }
}
