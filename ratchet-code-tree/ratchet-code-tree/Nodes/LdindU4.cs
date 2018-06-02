using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class LdindU4 : Node
    {
        Node _Address;
        public Node Address { get { return _Address; } }

        public LdindU4(Node Address)
        {
            _Address = Address;
        }
        public override Type Type { get { return typeof(UInt32); } }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectLdindU4(this); }
    }
}