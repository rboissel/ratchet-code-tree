using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class DeclFunc : Statement
    {
        public class Parameter
        {
            Type _Type;
            public Parameter(Type Type) { _Type = Type; }
        }

        Type _ReturnType;
        public Type ReturnType { get { return _ReturnType; } }
        Parameter[] _Parameters;
        public Parameter[] Parameters { get { return _Parameters; } }
        Statement[] _Statements;
        public Statement[] Statements { get { return _Statements; } }
        public DeclFunc(int Index, Type ReturnType, Parameter[] Parameters, Statement[] Statements)
        {
            _ReturnType = ReturnType;
            _Parameters = Parameters;
            _Statements = Statements;
        }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectDeclFunc(this); }
    }
}
