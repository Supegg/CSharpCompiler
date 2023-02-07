using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCompiler
{
    /// <summary>
    /// csc-命令行编译
    /// https://www.cnblogs.com/jtxs/p/4075877.html
    /// CSharpCodeProvider-代码编译
    /// https://learn.microsoft.com/zh-cn/troubleshoot/developer/visualstudio/csharp/language-compilers/compile-code-using-compiler
    /// CompilerParameters 
    /// https://learn.microsoft.com/en-us/dotnet/api/system.codedom.compiler.compilerparameters?view=netframework-4.7.2
    /// </summary>
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            CSharpCodeProvider codeProvider = new CSharpCodeProvider();
            string Output = "Out.exe";
            Button ButtonObject = (Button)sender;

            tbResult.Text = "";
            CompilerParameters parameters = new CompilerParameters();
            //Make sure we generate an EXE, not a DLL
            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = Output;
            parameters.CompilerOptions = @"/win32icon:Eva.ico";
            parameters.ReferencedAssemblies.Add("System.dll"); // 添加引用库

            CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, tbSrc.Text);

            if (results.Errors.Count > 0)
            {
                tbSrc.ForeColor = Color.Red;
                foreach (CompilerError CompErr in results.Errors)
                {
                    tbSrc.Text = tbSrc.Text +
                                "Line number " + CompErr.Line +
                                ", Error Number: " + CompErr.ErrorNumber +
                                ", '" + CompErr.ErrorText + ";" +
                                Environment.NewLine + Environment.NewLine;
                }
            }
            else
            {
                //Successful Compile
                tbResult.ForeColor = Color.Blue;
                tbResult.Text = "Success!";
                //If we clicked run then launch our EXE
                if (ButtonObject.Text == "Run")
                {
                    Process.Start(Output);
                }
            }
        }
    }
}

/*
using System;
using System.Diagnostics;

namespace HelloWorld
{
    /// <summary>
    /// Hello World
    /// </summary>
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Process.Start("cmd.exe"); //做启动器
            Console.ReadLine();
        }
    }
} 
*/
