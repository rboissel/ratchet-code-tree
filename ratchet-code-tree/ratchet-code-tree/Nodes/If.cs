using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class If : Statement
    {
        Node _Condition;
        public Node Condition { get { return _Condition; } }
        Statement[] _IfStatements;
        public Statement[] IfStatements { get { return _IfStatements; } }
        public If(Node Condition, Statement[] IfStatements) { _IfStatements = IfStatements; _Condition = Condition; }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectIf(this); }
    }
}
