using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class LdcI4 : Node
    {
        int _Value = 0;
        public int Value { get { return _Value; } }

        public LdcI4(int Value)
        {
            _Value = Value;
        }
        public override Type Type { get { return typeof(Int32); } }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectLdcI4(this); }
    }
}
