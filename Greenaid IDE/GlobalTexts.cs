using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Greenaid_IDE;

namespace Greenaid_IDE

{
    public class GlobalTexts
    {
        private static char hi = '"';

        public static string DefaultVisualBasicApplicationProgramCode =
            $"Imports System\n" +
            $"" +
            $"Module" + createproject.projectname + "\n" +
            $"   Sub Main(args As String())\n" +
            $"       Console.WriteLine(2 + 2);\n" +
            $"   End Sub\n" +
            $"End Module";
        
        public static string DefaultVisualBasicLibraryProgramCode =
            $"Imports System\n" +
            $"" +
            $"Public Class " + createproject.projectname + "\n" +
            $"   Public Shared Function Sum(a As Integer, b as Integer) As Integer\n" +
            $"       Return a + b\n" +
            $"   End Function\n" +
            $"End Class";
        
        public static string DefaultCSharpConsoleAppProgramCode =
            "using System;\n" +
            "namespace " + createproject.projectname + "\n" +
            "{\n" +
            "   public class Program\n" +
            "   {\n" +
            "       static void Main(string[] args)\n" +
            "       {\n" +
            "           Console.WriteLine(5 + 5);\n" +
            "       }\n" +
            "   }\n" +
            "}";
        public static string DefaultCSharpLibraryProgramCode =
            "using System;\n" +
            "namespace " + createproject.projectname + "\n" +
            "{\n" +
            "   public class Math\n" +
            "   {\n" +
            "       public static int Sum(int a, int b)\n" +
            "       {\n" +
            "           return a + b;\n" +
            "       }\n" +
            "   }\n" +
            "}";
        public static string DefaultWebsiteCode = "<!DOCTYPE html>\n\n<head>\n\n<title>Document</title>\n\n</head>\n\n<body>\n\n<h1>Here is a new website made with Greenaid IDE</h1>\n\n</body>\n\n</html>";
    }
}
