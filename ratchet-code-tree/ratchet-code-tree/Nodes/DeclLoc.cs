using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class DeclLoc : Statement
    {
        Type _Type;
        public Type Type { get { return _Type; } }
        int _Index;
        public int Index { get { return _Index; } }
        bool _IsPinned = false;
        public bool IsPinned { get { return _IsPinned; } }
        public DeclLoc(int Index, Type Type, bool IsPinned)
        {
            _Type = Type;
            if (Index < 0) { throw new Exception("Invalid local index"); }
            _Index = Index;
            _IsPinned = IsPinned;
        }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectDeclLoc(this); }
    }
}
