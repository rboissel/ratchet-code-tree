using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class Throw : Statement
    {
        Node _Value;
        public Node Value { get { return _Value; } }
        public Throw(Node Value)
        {
            _Value = Value;
        }
        public override Type Type { get { return _Value.Type; } }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectThrow(this); }
    }
}