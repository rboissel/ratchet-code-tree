using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class LdElemR4 : Node
    {
        Node _Index;
        public Node Index { get { return _Index; } }
        Node _Array;
        public Node Array { get { return _Array; } }
        public LdElemR4(Node Array, Node Index)
        {
            _Index = Index;
            _Array = Array;
        }
        public override Type Type { get { return typeof(Single); } }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectLdElemR4(this); }
    }
}