using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class LdindR4 : Node
    {
        Node _Address;
        public Node Address { get { return _Address; } }

        public LdindR4(Node Address)
        {
            _Address = Address;
        }
        public override Type Type { get { return typeof(Single); } }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectLdindR4(this); }
    }
}