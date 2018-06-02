using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class LdFldInfo : Node
    {
        System.Reflection.FieldInfo _FieldInfo;
        public System.Reflection.FieldInfo FieldInfo { get { return _FieldInfo; } }

        public LdFldInfo(System.Reflection.FieldInfo FieldInfo)
        {
            _FieldInfo = FieldInfo;
        }
        public override Type Type { get { return typeof(System.Reflection.FieldInfo); } }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectLdFldInfo(this); }
    }
}