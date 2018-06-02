using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class StArg : Statement
    {
        int _Index = 0;
        public int Index { get { return _Index; } }

        Node _Value;
        public Node Value { get { return _Value; } }

        public StArg(int Index, Node Value)
        {
            _Index = Index;
            _Value = Value;
        }

        internal override void Inspect(Inspector Inspector) { Inspector.InspectStArg(this); }
    }
}
