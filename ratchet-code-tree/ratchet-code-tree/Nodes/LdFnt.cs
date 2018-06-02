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

        public LdFtn(System.Reflection.MethodBase MethodBase)
        {
            _MethodBase = MethodBase;
        }
        public override Type Type { get { return  typeof(System.Reflection.MethodBase); } }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectLdFtn(this); }
    }
}