using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class LdindI1 : Node
    {
        Node _Address;
        public Node Address { get { return _Address; } }

        public LdindI1(Node Address)
        {
            _Address = Address;
        }
        public override Type Type { get { return typeof(Byte); } }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectLdindI1(this); }
    }
}