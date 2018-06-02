using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class InitArray : Statement
    {
        Node _Array;
        public Node Array { get { return _Array; } }
        System.ValueType _Initializer;
        public System.ValueType Initializer { get { return _Initializer; } }

        public InitArray(Node Array, System.ValueType Initializer)
        {
            _Initializer = Initializer;
            _Array = Array;
        }

        internal override void Inspect(Inspector Inspector) { Inspector.InspectInitArray(this); }
    }
}
