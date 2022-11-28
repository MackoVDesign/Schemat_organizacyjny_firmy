namespace Schemat_organizacyjny_firmy
{
    partial class Form3
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1OK = new System.Windows.Forms.Button();
            this.button1anl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1OK
            // 
            this.button1OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1OK.Location = new System.Drawing.Point(107, 75);
            this.button1OK.Name = "button1OK";
            this.button1OK.Size = new System.Drawing.Size(75, 23);
            this.button1OK.TabIndex = 0;
            this.button1OK.Text = "OK";
            this.button1OK.UseVisualStyleBackColor = true;
            this.button1OK.Click += new System.EventHandler(this.button1OK_Click);
            // 
            // button1anl
            // 
            this.button1anl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1anl.Location = new System.Drawing.Point(188, 75);
            this.button1anl.Name = "button1anl";
            this.button1anl.Size = new System.Drawing.Size(75, 23);
            this.button1anl.TabIndex = 1;
            this.button1anl.Text = "Zamknij";
            this.button1anl.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazwa";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 23);
            this.textBox1.TabIndex = 3;
            // 
            // Form3
            // 
            this.AcceptButton = this.button1OK;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1anl;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1anl);
            this.Controls.Add(this.button1OK);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1OK;
        private Button button1anl;
        private Label label1;
        private TextBox textBox1;
    }
}