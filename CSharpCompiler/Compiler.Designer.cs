
namespace CSharpCompiler
{
    partial class Compiler
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRun = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.tbSrc = new System.Windows.Forms.TextBox();
            this.btnBuild = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(717, 339);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 33);
            this.btnRun.TabIndex = 7;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.button_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(32, 346);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(100, 25);
            this.tbResult.TabIndex = 6;
            // 
            // tbSrc
            // 
            this.tbSrc.Location = new System.Drawing.Point(16, 31);
            this.tbSrc.Multiline = true;
            this.tbSrc.Name = "tbSrc";
            this.tbSrc.Size = new System.Drawing.Size(776, 282);
            this.tbSrc.TabIndex = 5;
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(625, 339);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(75, 33);
            this.btnBuild.TabIndex = 4;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.button_Click);
            // 
            // Compiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbSrc);
            this.Controls.Add(this.btnBuild);
            this.Name = "Compiler";
            this.Size = new System.Drawing.Size(809, 442);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.TextBox tbSrc;
        private System.Windows.Forms.Button btnBuild;
    }
}
