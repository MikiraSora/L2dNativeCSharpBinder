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
    public class CoreLibrary : CommonLibraryBase
    {
        public override string ModuleName => "libLive2DCubismCore";

        public override void Setup(Driver driver)
        {
            base.Setup(driver);
            var options = driver.Options;

            var module = options.AddModule(ModuleName);
            module.Headers.Add(@"C:\Sample\CubismSdkForNative-4-r.1\Core\include\Live2DCubismCore.h");
            module.LibraryDirs.Add(@"C:\Sample\CubismSdkForNative-4-r.1\Core\lib");
            module.LibraryName = ModuleName;
        }
    }
}
