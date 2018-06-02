using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class LdNull : Node
    {
        public override Type Type { get { return null; } }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectLdNull(this); }
    }
}
