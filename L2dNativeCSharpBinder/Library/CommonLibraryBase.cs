using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;
using L2dNativeCSharpBinder.Pass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2dNativeCSharpBinder.Library
{
    public abstract class CommonLibraryBase : ILibrary
    {
        public abstract string ModuleName{get;}

        public virtual void Postprocess(Driver driver, ASTContext ctx)
        {

        }

        public virtual void Preprocess(Driver driver, ASTContext ctx)
        {

        }

        public virtual void Setup(Driver driver)
        {
            var options = driver.Options;
            options.GeneratorKind = GeneratorKind.CSharp;
            options.Verbose = true;

            options.OutputDir = Path.Combine(GlobalOptions.OutputPath,ModuleName);
        }

        public virtual void SetupPasses(Driver driver)
        {
            driver.Context.TranslationUnitPasses.AddPass(StdCallConvPass.Default);
        }
    }
}
