using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class LdcR8 : Node
    {
        double _Value = 0;
        public double Value { get { return _Value; } }

        public LdcR8(double Value)
        {
            _Value = Value;
        }
        public override Type Type { get { return typeof(Double); } }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectLdcR8(this); }
    }
}
