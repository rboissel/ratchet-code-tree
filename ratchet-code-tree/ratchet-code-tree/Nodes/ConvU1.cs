using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class ConvU1 : Node
    {
        Node _Value;
        public Node Value { get { return _Value; } set { _Value = value; } }

        public ConvU1(Node Value)
        {
            _Value = Value;
        }
        public override Type Type { get { return typeof(Byte); } }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectConvU1(this); }
    }
}
