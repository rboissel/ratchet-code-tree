using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class LdStr : Node
    {
        string _Value = "";
        public string Value { get { return _Value; } }

        public LdStr(string Value)
        {
            _Value = Value;
        }
        public override Type Type { get { return typeof(String); } }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectLdStr(this); }
    }
}
