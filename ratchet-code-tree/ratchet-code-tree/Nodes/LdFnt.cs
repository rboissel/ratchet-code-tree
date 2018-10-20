using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class LdFtn : Node
    {
        System.Reflection.MethodBase _MethodBase;
        public System.Reflection.MethodBase MethodBase { get { return _MethodBase; } }

        int _Index;
        public int Index { get { return _Index; } }
        Type _Type = null;
        public override Type Type { get { if (_Type == null) { return typeof(System.Reflection.MethodBase); } else { return _Type; } } }

        public LdFtn(System.Reflection.MethodBase MethodBase)
        {
            _MethodBase = MethodBase;
        }

        public LdFtn(int Index, Type Type)
        {
            _MethodBase = null;
            _Index = Index;
            _Type = Type;

        }

        internal override void Inspect(Inspector Inspector) { Inspector.InspectLdFtn(this); }
    }
}