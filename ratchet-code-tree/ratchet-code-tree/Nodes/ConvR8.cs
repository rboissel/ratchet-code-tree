using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class ConvR8 : Node
    {
        Node _Value;
        public Node Value { get { return _Value; } set { _Value = value; } }

        public ConvR8(Node Value)
        {
            _Value = Value;
        }

        internal override void Inspect(Inspector Inspector) { Inspector.InspectConvR8(this); }
    }
}
