using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class While : Statement
    {
        Node _Condition;
        public Node Condition { get { return _Condition; } }
        Statement[] _WhileStatements;
        public Statement[] WhileStatements { get { return _WhileStatements; } }
        public While(Node Condition, Statement[] WhileStatements) { _WhileStatements = WhileStatements; _Condition = Condition; }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectWhile(this); }
    }
}
