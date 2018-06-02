using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class Ret : Statement
    {
        Node _Value;
        public Node Value { get { return _Value; } }

        public Ret(Node Value)
        {
            _Value = Value;
        }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectRet(this); }
    }
}
