using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("Starter")]
[assembly: AssemblyDescription("This is a program launcher")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Starter")]
[assembly: AssemblyCopyright("Copyright ©  2023")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]

[assembly: Guid("c6e2bafb-abdb-4cc2-b967-45f569ea3052")]

[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.2.0.0")]


public class SuForm : System.Windows.Forms.Form
{
    public SuForm()
    {
        this.Text = "AppName";
        this.Width = 620;
        this.Height = 360;
            
        CSharpCompiler.Compiler main = new CSharpCompiler.Compiler();
        this.Controls.Add(main);
    }

    public static void Main()
    {
        System.Windows.Forms.Application.Run(new SuForm());
    }
}