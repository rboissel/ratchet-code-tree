using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class Branch_IfFalse : Branch
    {
        Node _Value;
        public Node Value { get { return _Value; } }
        public Branch_IfFalse(Node Target, Node Value) : base(Target) { _Value = Value; }

        internal override void Inspect(Inspector Inspector) { Inspector.InspectBranch_IfFalse(this); }
    }
}
