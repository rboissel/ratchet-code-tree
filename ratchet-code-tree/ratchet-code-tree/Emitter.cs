using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ratchet.Code.Tree
{
    public abstract class Inspector
    {
        public virtual void Inspect(Node Node) { Node.Inspect(this); }
        public virtual void InspectAdd(Nodes.Add Add) { Inspect(Add.Left); Inspect(Add.Right); }
        public virtual void InspectAnd(Nodes.And And) { Inspect(And.Left); Inspect(And.Right); }
        public virtual void InspectBox(Nodes.Box Box) { }
        public virtual void InspectCall_Procedure(Nodes.Call_Procedure Call) { if (Call.This != null) { Inspect(Call.This); } Inspect(Call.Method); for (int n = 0; n < Call.Parameters.Length; n++) { Inspect(Call.Parameters[n]); } }
        public virtual void InspectCall_Function(Nodes.Call_Function Call) { if (Call.This != null) { Inspect(Call.This); } Inspect(Call.Method); for (int n = 0; n < Call.Parameters.Length; n++) { Inspect(Call.Parameters[n]); } }
        public virtual void InspectCatchObject(Nodes.CatchObject CatchObject) { }
        public virtual void InspectClt_Un(Nodes.Clt_Un Clt_Un) { Inspect(Clt_Un.Left); Inspect(Clt_Un.Right); }
        public virtual void InspectClt(Nodes.Clt Clt) { Inspect(Clt.Left); Inspect(Clt.Right); }
        public virtual void InspectCgt_Un(Nodes.Cgt_Un Cgt_Un) { Inspect(Cgt_Un.Left); Inspect(Cgt_Un.Right); }
        public virtual void InspectCgt(Nodes.Cgt Cgt) { Inspect(Cgt.Left); Inspect(Cgt.Right); }
        public virtual void InspectCeq(Nodes.Ceq Ceq) { Inspect(Ceq.Left); Inspect(Ceq.Right); }
        public virtual void InspectConvU(Nodes.ConvU ConvU) { Inspect(ConvU.Value); }
        public virtual void InspectConvU1(Nodes.ConvU1 ConvU1) { Inspect(ConvU1.Value); }
        public virtual void InspectConvU2(Nodes.ConvU2 ConvU2) { Inspect(ConvU2.Value); }
        public virtual void InspectConvI(Nodes.ConvI ConvI) { Inspect(ConvI.Value); }
        public virtual void InspectConvI1(Nodes.ConvI1 ConvI1) { Inspect(ConvI1.Value); }
        public virtual void InspectConvI2(Nodes.ConvI2 ConvI2) { Inspect(ConvI2.Value); }
        public virtual void InspectConvI4(Nodes.ConvI4 ConvI4) { Inspect(ConvI4.Value); }
        public virtual void InspectConvI8(Nodes.ConvI8 ConvI8) { Inspect(ConvI8.Value); }
        public virtual void InspectConvR8(Nodes.ConvR8 ConvR8) { Inspect(ConvR8.Value); }
        public virtual void InspectDeclLoc(Nodes.DeclLoc DeclLoc) { }
        public virtual void InspectDiv(Nodes.Div Div) { Inspect(Div.Left); Inspect(Div.Right); }
        public virtual void InspectDiv_Un(Nodes.Div_Un Div) { Inspect(Div.Left); Inspect(Div.Right); }
        public virtual void InspectGetFtn(Nodes.GetFtn GetFtn) { Inspect(GetFtn.Value); }
        public virtual void InspectIf(Nodes.If If) { Inspect(If.Condition); for (int n = 0; n < If.IfStatements.Length; n++) { Inspect(If.IfStatements[n]); } }
        public virtual void InspectInitArray(Nodes.InitArray InitArray) { Inspect(InitArray.Array); }
        public virtual void InspectInitObj(Nodes.InitObj InitObj) { Inspect(InitObj.Object); }
        public virtual void InspectIsInst(Nodes.IsInst IsInst) { Inspect(IsInst.Object); }
        public virtual void InspectBranch_Always(Nodes.Branch_Always Branch_Always) { }
        public virtual void InspectBranch_IfFalse(Nodes.Branch_IfFalse Branch_IfFalse) { Inspect(Branch_IfFalse.Value); }
        public virtual void InspectBranch_IfTrue(Nodes.Branch_IfTrue Branch_IfTrue) { Inspect(Branch_IfTrue.Value); }
        public virtual void InspectBranch_IfEqual(Nodes.Branch_IfEqual Branch_Equal) { Inspect(Branch_Equal.Left); Inspect(Branch_Equal.Right); }
        public virtual void InspectBranch_IfNotEqual(Nodes.Branch_IfNotEqual Branch_NotEqual) { Inspect(Branch_NotEqual.Left); Inspect(Branch_NotEqual.Right); }
        public virtual void InspectBranch_IfGreater(Nodes.Branch_IfGreater Branch_Greater) { Inspect(Branch_Greater.Left); Inspect(Branch_Greater.Right); }
        public virtual void InspectBranch_IfGreaterOrEqual(Nodes.Branch_IfGreaterOrEqual Branch_GreaterOrEqual) { Inspect(Branch_GreaterOrEqual.Left); Inspect(Branch_GreaterOrEqual.Right); }
        public virtual void InspectBranch_IfLower(Nodes.Branch_IfLower Branch_IfLower) { Inspect(Branch_IfLower.Left); Inspect(Branch_IfLower.Right); }
        public virtual void InspectBranch_IfLowerOrEqual(Nodes.Branch_IfLowerOrEqual Branch_LowerOrEqual) { Inspect(Branch_LowerOrEqual.Left); Inspect(Branch_LowerOrEqual.Right); }
        public virtual void InspectLdArg(Nodes.LdArg LdArg) { }
        public virtual void InspectLdArga(Nodes.LdArga LdArga) { }
        public virtual void InspectLdFld(Nodes.LdFld LdFld) { }
        public virtual void InspectLdFldInfo(Nodes.LdFldInfo LdFldInfo) { }
        public virtual void InspectLdFtn(Nodes.LdFtn LdFtn) { }
        public virtual void InspectLeave(Nodes.Leave Leave) { }
        public virtual void InspectLdArray(Nodes.LdArray LdArray) { }
        public virtual void InspectLdElem(Nodes.LdElem LdElem) { Inspect(LdElem.Array); Inspect(LdElem.Index); }
        public virtual void InspectLdElema(Nodes.LdElema LdElema) { Inspect(LdElema.Array); Inspect(LdElema.Index); }
        public virtual void InspectLdElemI4(Nodes.LdElemI4 LdElemI4) { Inspect(LdElemI4.Array); Inspect(LdElemI4.Index); }
        public virtual void InspectLdElemR4(Nodes.LdElemR4 LdElemR4) { Inspect(LdElemR4.Array); Inspect(LdElemR4.Index); }
        public virtual void InspectLdElemRef(Nodes.LdElemRef LdElemRef) { Inspect(LdElemRef.Array); Inspect(LdElemRef.Index); }
        public virtual void InspectLdLoc(Nodes.LdLoc LdLoc) { }
        public virtual void InspectLdLoca(Nodes.LdLoca LdLoca) { }
        public virtual void InspectLdcI4(Nodes.LdcI4 LdcI4) { }
        public virtual void InspectLdcR4(Nodes.LdcR4 LdcR4) { }
        public virtual void InspectLdcR8(Nodes.LdcR8 LdcR8) { }
        public virtual void InspectLdindI1(Nodes.LdindI1 LdindI1) { Inspect(LdindI1.Address); }
        public virtual void InspectLdindI4(Nodes.LdindI4 LdindI4) { Inspect(LdindI4.Address); }
        public virtual void InspectLdindR4(Nodes.LdindR4 LdindR4) { Inspect(LdindR4.Address); }
        public virtual void InspectLdindU2(Nodes.LdindU2 LdindU2) { Inspect(LdindU2.Address); }
        public virtual void InspectLdindU4(Nodes.LdindU4 LdindU4) { Inspect(LdindU4.Address); }
        public virtual void InspectLdLen(Nodes.LdLen LdLen) { Inspect(LdLen.Value); }
        public virtual void InspectLdNull(Nodes.LdNull LdNull) { }
        public virtual void InspectLdStr(Nodes.LdStr LdStr) { }
        public virtual void InspectLdType(Nodes.LdType LdType) { }
        public virtual void InspectNeg(Nodes.Neg Neg) { Inspect(Neg.Value); }
        public virtual void InspectNewobj(Nodes.Newobj Newobj) { Inspect(Newobj.Method); for (int n = 0; n < Newobj.Parameters.Length; n++) { Inspect(Newobj.Parameters[n]); } }
        public virtual void InspectNewarr(Nodes.Newarr Newarr) { Inspect(Newarr.Size); }
        public virtual void InspectNot(Nodes.Not Not) { Inspect(Not.Value); }
        public virtual void InspectNop(Nodes.Nop Nop) { }
        public virtual void InspectMul(Nodes.Mul Mul) { Inspect(Mul.Left); Inspect(Mul.Right); }
        public virtual void InspectMulOvf(Nodes.MulOvf MulOvf) { Inspect(MulOvf.Left); Inspect(MulOvf.Right); }
        public virtual void InspectOr(Nodes.Or Or) { Inspect(Or.Left); Inspect(Or.Right); }
        public virtual void InspectRem(Nodes.Rem Rem) { Inspect(Rem.Left); Inspect(Rem.Right); }
        public virtual void InspectRet(Nodes.Ret Ret) { Inspect(Ret.Value); }
        public virtual void InspectShl(Nodes.Shl Shl) { Inspect(Shl.Left); Inspect(Shl.Right); }
        public virtual void InspectShr_Un(Nodes.Shr_Un Shr_Un) { Inspect(Shr_Un.Left); Inspect(Shr_Un.Right); }
        public virtual void InspectStArg(Nodes.StArg StArg) { Inspect(StArg.Value); }
        public virtual void InspectStElemRef(Nodes.StElemRef StElemRef) { Inspect(StElemRef.Array); Inspect(StElemRef.Index); Inspect(StElemRef.Value); }
        public virtual void InspectStElem(Nodes.StElem StElem) { Inspect(StElem.Array); Inspect(StElem.Index); Inspect(StElem.Value); }
        public virtual void InspectStIndI1(Nodes.StIndI1 StIndI1) { Inspect(StIndI1.Address); Inspect(StIndI1.Value); }
        public virtual void InspectStIndI2(Nodes.StIndI2 StIndI2) { Inspect(StIndI2.Address); Inspect(StIndI2.Value); }
        public virtual void InspectStIndI4(Nodes.StIndI4 StIndI4) { Inspect(StIndI4.Address); Inspect(StIndI4.Value); }
        public virtual void InspectStIndI8(Nodes.StIndI8 StIndI8) { Inspect(StIndI8.Address); Inspect(StIndI8.Value); }
        public virtual void InspectStIndR4(Nodes.StIndR4 StIndR4) { Inspect(StIndR4.Address); Inspect(StIndR4.Value); }
        public virtual void InspectStIndR8(Nodes.StIndR8 StIndR8) { Inspect(StIndR8.Address); Inspect(StIndR8.Value); }
        public virtual void InspectStFld(Nodes.StFld StFld) { Inspect(StFld.Value); }
        public virtual void InspectStLoc(Nodes.StLoc StLoc) { Inspect(StLoc.Value); }
        public virtual void InspectSub(Nodes.Sub Sub) { Inspect(Sub.Left); Inspect(Sub.Right); }
        public virtual void InspectThrow(Nodes.Throw Throw) { Inspect(Throw.Value); }
        public virtual void InspectTry(Nodes.Try Try)
        {
            if (Try.TryStatements == null)
            {
                for (int n = 0; n < Try.TryStatements.Length; n++) { Inspect(Try.TryStatements[n]); }
            }

            if (Try.CatchStatements == null)
            {
                for (int n = 0; n < Try.CatchStatements.Length; n++) { Inspect(Try.CatchStatements[n]); }
            }

            if (Try.FinallyStatements == null)
            {
                for (int n = 0; n < Try.FinallyStatements.Length; n++) { Inspect(Try.FinallyStatements[n]); }
            }
        }
        public virtual void InspectUnbox(Nodes.Unbox Unbox) { Inspect(Unbox.Value); }
        public virtual void InspectWhile(Nodes.While While) { Inspect(While.Condition); for (int n = 0; n < While.WhileStatements.Length; n++) { Inspect(While.WhileStatements[n]); } }
    }
}
