using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class Leave : Branch
    {
        public Leave(Node Target) : base(Target) { }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectLeave(this); }
    }
}
