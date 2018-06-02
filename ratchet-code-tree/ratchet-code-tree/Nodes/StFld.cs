using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class StFld : Statement
    {
        Node _This;
        public Node This { get { return _This; } }
        System.Reflection.FieldInfo _FieldInfo;
        public System.Reflection.FieldInfo FieldInfo { get { return _FieldInfo; } }
        Node _Value;
        public Node Value { get { return _Value; } }

        public StFld(Node This, System.Reflection.FieldInfo FieldInfo, Node Value)
        {
            _This = This;
            _FieldInfo = FieldInfo;
            _Value = Value;
        }

        internal override void Inspect(Inspector Inspector) { Inspector.InspectStFld(this); }
    }
}