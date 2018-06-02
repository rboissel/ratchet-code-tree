﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class LdElema : Node
    {
        Node _Index;
        public Node Index { get { return _Index; } }
        Node _Array;
        public Node Array { get { return _Array; } }
        public LdElema(Node Array, Node Index)
        {
            _Index = Index;
            _Array = Array;
        }

        internal override void Inspect(Inspector Inspector) { Inspector.InspectLdElema(this); }
    }
}