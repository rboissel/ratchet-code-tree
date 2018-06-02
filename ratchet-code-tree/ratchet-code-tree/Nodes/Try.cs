using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class Try : Statement
    {
        Statement[] _TryStatements;
        public Statement[] TryStatements { get { return _TryStatements; } }
        Statement[] _CatchStatements;
        public Statement[] CatchStatements { get { return _CatchStatements; } }
        Statement[] _FinallyStatements;
        public Statement[] FinallyStatements { get { return _FinallyStatements; } }

        public Try(Statement[] TryStatements, Statement[] CatchStatements, Statement[] FinallyStatements)
        {
            _TryStatements = TryStatements;
            _CatchStatements = CatchStatements;
            _FinallyStatements = FinallyStatements;
        }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectTry(this); }
    }
}
