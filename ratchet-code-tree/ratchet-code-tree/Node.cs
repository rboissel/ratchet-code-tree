using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree
{
    public abstract class Node
    {
        internal abstract void Inspect(Inspector Inspector);
        object _Tag = null;
        public object Tag { get { return _Tag; } set { _Tag = value; } }
        public virtual Type Type { get { return null; } }
    }
}
