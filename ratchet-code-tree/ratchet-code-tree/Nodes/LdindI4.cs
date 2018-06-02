using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class LdindI4 : Node
    {
        Node _Address;
        public Node Address { get { return _Address; } }

        public LdindI4(Node Address)
        {
            _Address = Address;
        }
        public override Type Type { get { return typeof(Int32); } }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectLdindI4(this); }
    }
}
