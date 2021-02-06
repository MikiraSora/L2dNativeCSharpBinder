using CppSharp;
using L2dNativeCSharpBinder.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2dNativeCSharpBinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Setup(args);
            Run();

            Console.WriteLine("All done!");
            Console.ReadKey();
        }

        private static void Run()
        {
            Console.WriteLine("Tasks begin....");
            ConsoleDriver.Run(new CoreLibrary());
            ConsoleDriver.Run(new FrameworkLibrary());
            ConsoleDriver.Run(new DemoLibrary());
            Console.WriteLine("Tasks done....");
        }

        private static void Setup(string[] args)
        {
            Console.WriteLine("Tasks setup....");
            GlobalOptions.OutputPath = "./BinderOutput";
        }
    }
}
