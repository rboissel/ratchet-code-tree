using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class Unbox : Node
    {
        Type _Type;
        public Type Type { get { return _Type; } }
        Node _Value;
        public Node Value { get { return _Value; } }

        public Unbox(Node Value, Type Type) { _Type = Type; _Value = Value; }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectUnbox(this); }
    }
}
