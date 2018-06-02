using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class LdArray : Node
    {
        Type _Type = null;
        public override Type Type { get { return _Type; } }

        object[] _Array;
        public object[] Value { get { return _Array; } }

        public LdArray(object[] Array)
        {
            _Type = typeof(Object[]);
            _Array = Array;
        }

        internal override void Inspect(Inspector Inspector) { Inspector.InspectLdArray(this); }

    }
}
