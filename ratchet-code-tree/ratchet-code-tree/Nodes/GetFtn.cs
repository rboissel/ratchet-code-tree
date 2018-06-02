using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class GetFtn : Node
    {
        System.Reflection.MethodBase _MethodBase;
        public System.Reflection.MethodBase MethodBase { get { return _MethodBase; } }
        Node _Value;
        public Node Value { get { return _Value; } }

        public GetFtn(Node Value, System.Reflection.MethodBase MethodBase)
        {
            _MethodBase = MethodBase;
            _Value = Value;
        }

        internal override void Inspect(Inspector Inspector) { Inspector.InspectGetFtn(this); }
    }
}