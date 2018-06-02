using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class Branch_Always : Branch
    {
        public Branch_Always(Node Target) : base(Target) { }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectBranch_Always(this); }
    }
}
