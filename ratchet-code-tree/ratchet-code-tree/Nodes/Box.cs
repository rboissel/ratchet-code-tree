using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class Box : Node
    {
        internal override void Inspect(Inspector Inspector) { Inspector.InspectBox(this); }
    }
}
