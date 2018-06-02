using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class Newobj : Node
    {
        Node[] _Parameters;
        public Node[] Parameters { get { return _Parameters; } }
        Node _Method;
        public Node Method { get { return _Method; } }

        public Newobj(Node Method, Node[] Parameters)
        {
            _Parameters = Parameters;
            _Method = Method;
        }

        internal override void Inspect(Inspector Inspector) { Inspector.InspectNewobj(this); }
    }
}
