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
