using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class StIndR4 : Statement
    {
        Node _Address;
        public Node Address { get { return _Address; } }

        Node _Value;
        public Node Value { get { return _Value; } }

        public StIndR4(Node Address, Node Value)
        {
            _Address = Address;
            _Value = Value;
        }

        internal override void Inspect(Inspector Inspector) { Inspector.InspectStIndR4(this); }
    }
}
