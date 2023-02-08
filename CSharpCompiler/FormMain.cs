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

            Compiler compiler = new Compiler();
            this.Controls.Add(compiler);
        }
    }
}
