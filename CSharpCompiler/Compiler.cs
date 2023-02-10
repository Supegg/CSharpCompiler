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
    public partial class Compiler : UserControl
    {
        public Compiler()
        {
            InitializeComponent();
        }


        private void button_Click(object sender, EventArgs e)
        {
            CSharpCodeProvider codeProvider = new CSharpCodeProvider();
            string Output = "Compiler.exe";
            Button ButtonObject = (Button)sender;

            tbResult.Text = "";
            CompilerParameters parameters = new CompilerParameters();
            // Make sure we generate an EXE, not a DLL
            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = Output;
            // parameters.CompilerOptions = "/target:exe /optimize /win32icon:Eva.ico";
            // parameters.ReferencedAssemblies.Add("System.dll"); // 添加引用库

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
