using CppSharp.AST;
using CppSharp.Passes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2dNativeCSharpBinder.Pass
{
    public class StdCallConvPass : TranslationUnitPass
    {
        public override bool VisitFunctionDecl(Function function)
        {
            function.CallingConvention = CallingConvention.StdCall;
            return base.VisitFunctionDecl(function);
        }
    }
}
