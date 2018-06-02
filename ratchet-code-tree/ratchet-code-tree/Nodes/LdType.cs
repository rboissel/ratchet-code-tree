using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class LdType : Node
    {
        Type _Type;
        public override  Type Type { get { return _Type; } }

        public LdType(Type Type)
        {
            _Type = Type;
        }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectLdType(this); }
    }
}