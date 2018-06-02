using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class LdFld : Node
    {
        Node _This;
        public Node This { get { return _This; } }
        System.Reflection.FieldInfo _FieldInfo;
        public System.Reflection.FieldInfo FieldInfo { get { return _FieldInfo; } }
        public LdFld(Node This, System.Reflection.FieldInfo FieldInfo)
        {
            _This = This;
            _FieldInfo = FieldInfo;
        }
        public override Type Type { get { return _FieldInfo.FieldType; } }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectLdFld(this); }
    }
}
