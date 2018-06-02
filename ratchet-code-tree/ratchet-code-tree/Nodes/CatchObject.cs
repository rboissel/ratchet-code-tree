using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class CatchObject : Node
    {
        Type _Type;
        public Type Type { get { return _Type; } set { _Type = value; } }

        public CatchObject(Type Type)
        {
            _Type = Type;
        }

        internal override void Inspect(Inspector Inspector) { Inspector.InspectCatchObject(this); }
    }
}
