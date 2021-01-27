using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;
using L2dNativeCSharpBinder.Pass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2dNativeCSharpBinder.Library
{
    public class CoreLibrary : ILibrary
    {
        public void Postprocess(Driver driver, ASTContext ctx)
        {

        }

        public void Preprocess(Driver driver, ASTContext ctx)
        {

        }

        public void Setup(Driver driver)
        {
            var options = driver.Options;
            options.GeneratorKind = GeneratorKind.CSharp;
            options.Verbose = true;

            var module = options.AddModule("Live2DCubismCore");
            module.Headers.Add(@"C:\Sample\CubismSdkForNative-4-r.1\Core\include\Live2DCubismCore.h");
            module.LibraryDirs.Add(@"C:\Sample\CubismSdkForNative-4-r.1\Core\lib");
            module.LibraryName = "libLive2DCubismCore";

            options.OutputDir = GlobalOptions.OutputPath;
        }

        public void SetupPasses(Driver driver)
        {
            driver.Context.TranslationUnitPasses.AddPass(new StdCallConvPass());
        }
    }
}
