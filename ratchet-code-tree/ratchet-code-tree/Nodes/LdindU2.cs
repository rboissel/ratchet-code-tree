using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class LdindU2 : Node
    {
        Node _Address;
        public Node Address { get { return _Address; } }

        public LdindU2(Node Address)
        {
            _Address = Address;
        }
        public override Type Type { get { return typeof(UInt16); } }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectLdindU2(this); }
    }
}