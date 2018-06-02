using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class LdArg : Node
    {
        int _Index = 0;
        public int Index { get { return _Index; } }
        Type _Type = null;
        public override Type Type { get { return _Type; } }


        public LdArg(int Index)
        {
            _Index = Index;
        }

        public LdArg(int Index, Type Type)
        {
            _Index = Index;
            _Type = Type;
        }

        internal override void Inspect(Inspector Inspector) { Inspector.InspectLdArg(this); }
    }
}
