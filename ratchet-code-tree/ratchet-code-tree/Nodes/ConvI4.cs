using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class ConvI4 : Node
    {
        Node _Value;
        public Node Value { get { return _Value; } set { _Value = value; } }

        public ConvI4(Node Value)
        {
            _Value = Value;
        }
        public override Type Type { get { return typeof(Int32); } }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectConvI4(this); }
    }
}
