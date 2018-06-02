using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class LdElemI4 : Node
    {
        Node _Index;
        public Node Index { get { return _Index; } }
        Node _Array;
        public Node Array { get { return _Array; } }
        public LdElemI4(Node Array, Node Index)
        {
            _Index = Index;
            _Array = Array;
        }
        public override Type Type { get { return typeof(Int32); } }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectLdElemI4(this); }
    }
}