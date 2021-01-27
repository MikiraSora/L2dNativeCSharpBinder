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
    class FrameworkLibrary : CommonLibraryBase
    {
        public override string ModuleName => "libFramework";

        public override void Setup(Driver driver)
        {
            base.Setup(driver);
            var options = driver.Options;

            var module = options.AddModule(ModuleName);

            module.Headers.Add(@"E:\live2dProjects\Live2D-Raspbian-Native-Sample\Framework\src\CubismFramework.hpp");
            module.CodeFiles.Add(@"E:\live2dProjects\Live2D-Raspbian-Native-Sample\Framework\src\CubismFramework.hpp");

            module.IncludeDirs.AddRange(new[]{
                @"E:\live2dProjects\Live2D-Raspbian-Native-Sample\Samples\OpenGL\thirdParty\glew-2.1.0\include",
                @"E:\live2dProjects\Live2D-Raspbian-Native-Sample\Samples\OpenGL\thirdParty\glfw-3.3\include",
                @"E:\live2dProjects\Live2D-Raspbian-Native-Sample\Framework\src",
                @"E:\live2dProjects\Live2D-Raspbian-Native-Sample\Core\include"
                });
            
            module.LibraryName = ModuleName;
        }
    }
}
