using CppSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2dNativeCSharpBinder.Library
{
    public class DemoLibrary : CommonLibraryBase
    {
        public override string ModuleName => "Demo";

        public override void Setup(Driver driver)
        {
            base.Setup(driver);

            var options = driver.Options;

            var module = options.AddModule(ModuleName);

            var baseSrcPath = @"E:\live2dProjects\Live2D-Raspbian-Native-Sample\Samples\OpenGL\Demo\proj.linux.cmake\Demo\";
            module.Headers.AddRange(new[] {
                "LAppLive2DManager.hpp",
                "LAppModel.hpp",
            }.Select(x=>Path.Combine(baseSrcPath,x)));

            module.IncludeDirs.AddRange(new[]{
                @"E:\live2dProjects\Live2D-Raspbian-Native-Sample\Samples\OpenGL\thirdParty\glew-2.1.0\include",
                @"E:\live2dProjects\Live2D-Raspbian-Native-Sample\Samples\OpenGL\thirdParty\glfw-3.3\include",
                @"E:\live2dProjects\Live2D-Raspbian-Native-Sample\Framework\src",
                @"E:\live2dProjects\Live2D-Raspbian-Native-Sample\Samples\OpenGL\Demo\proj.linux.cmake\Demo",
                @"E:\live2dProjects\Live2D-Raspbian-Native-Sample\Core\include",
                Path.Combine(Environment.CurrentDirectory, "Headers")
                });

            module.Defines.Add("GLint = int");
            module.Defines.Add("GLuint = unsigned int");

            module.LibraryName = ModuleName;
        }
    }
}
