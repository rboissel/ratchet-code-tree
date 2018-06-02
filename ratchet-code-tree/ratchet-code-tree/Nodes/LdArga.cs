using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class LdArga : Node
    {
        int _Index = 0;
        public int Index { get { return _Index; } }

        public LdArga(int Index)
        {
            _Index = Index;
        }

        internal override void Inspect(Inspector Inspector) { Inspector.InspectLdArga(this); }
    }
}
