using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class Call_Procedure : Statement
    {
        Node[] _Parameters;
        public Node[] Parameters { get { return _Parameters; } }
        Node _Method;
        public Node Method { get { return _Method; } }
        Node _This;
        public Node This { get { return _This; } }

        public Call_Procedure(Node Method, Node This, Node[] Parameters)
        {
            _Parameters = Parameters;
            _Method = Method;
            _This = This;
        }

        internal override void Inspect(Inspector Inspector) { Inspector.InspectCall_Procedure(this); }
    }
}
