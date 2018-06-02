using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class LdLoca : Statement
    {
        int _Index;
        public int Index { get { return _Index; } }
        public LdLoca(int Index)
        {
            _Index = Index;
        }

        internal override void Inspect(Inspector Inspector) { Inspector.InspectLdLoca(this); }
    }
}