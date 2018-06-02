using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public abstract class Branch : Statement
    {
        Node _Target;
        public Node Target { get { return _Target; } }
        public void SetTarget(Node Target) { _Target = Target; }
        public Branch(Node Target) { _Target = Target; }
    }
}
