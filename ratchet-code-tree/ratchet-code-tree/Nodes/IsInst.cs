﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class IsInst : Statement
    {
        Node _Object;
        public Node Object { get { return _Object; } }
        Type _Type;
        public Type Type { get { return _Type; } }

        public IsInst(Node Object, Type Type)
        {
            _Object = Object;
            _Type = Type;
        }

        internal override void Inspect(Inspector Inspector) { Inspector.InspectIsInst(this); }
    }
}
