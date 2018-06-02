using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class LdcR4 : Node
    {
        float _Value = 0;
        public float Value { get { return _Value; } }

        public LdcR4(float Value)
        {
            _Value = Value;
        }
        public override Type Type { get { return typeof(Single); } }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectLdcR4(this); }
    }
}
