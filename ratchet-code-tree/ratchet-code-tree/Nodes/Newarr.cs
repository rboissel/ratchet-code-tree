using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class Newarr : Node
    {
        Node _Size;
        public Node Size { get { return _Size; } }
        Type _Type;
        public override Type Type { get { return _Type; } }

        public Newarr(Type Type, Node Size) { _Size = Size; _Type = Type.MakeArrayType(); }

        internal override void Inspect(Inspector Inspector) { Inspector.InspectNewarr(this); }

    }
}
