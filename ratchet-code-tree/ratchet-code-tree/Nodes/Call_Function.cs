using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree.Nodes
{
    public class Call_Function : Node
    {
        Node[] _Parameters;
        public Node[] Parameters { get { return _Parameters; } }
        Node _Method;
        public Node Method { get { return _Method; } }
        Node _This;
        public Node This { get { return _This; } }
        Type _Type;
        public override Type Type { get { return _Type; } }

        public Call_Function(Node Method, Node This, Node[] Parameters)
        {
            _Parameters = Parameters;
            _Method = Method;
            _This = This;
            if (Method is LdFtn)
            {
                System.Reflection.MethodBase methodBase = (Method as LdFtn).MethodBase;
                if (methodBase != null)
                {
                    if (methodBase.IsConstructor) { _Type = methodBase.DeclaringType; }
                    else if (methodBase is System.Reflection.MethodInfo)
                    {
                        _Type = (methodBase as System.Reflection.MethodInfo).ReflectedType;
                    }
                }
                else
                {
                    _Type = (Method as LdFtn).Type;
                }
            }
        }
        internal override void Inspect(Inspector Inspector) { Inspector.InspectCall_Function(this); }
    }
}
