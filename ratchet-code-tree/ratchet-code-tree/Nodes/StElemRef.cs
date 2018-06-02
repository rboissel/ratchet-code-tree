using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class StElemRef : Statement
    {
        Node _Array;
        public Node Array { get { return _Array; } }

        Node _Index;
        public Node Index { get { return _Index; } }

        Node _Value;
        public Node Value { get { return _Value; } }

        public StElemRef(Node Array, Node Index, Node Value)
        {
            _Index = Index;
            _Value = Value;
            _Array = Array;
        }

        internal override void Inspect(Inspector Inspector) { Inspector.InspectStElemRef(this); }
    }
}
