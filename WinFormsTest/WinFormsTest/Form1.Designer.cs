
namespace WinFormsTest
{
    partial class Form1
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
            this.tb_logname = new System.Windows.Forms.TextBox();
            this.tb_logdetails = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_logname
            // 
            this.tb_logname.Location = new System.Drawing.Point(12, 12);
            this.tb_logname.Multiline = true;
            this.tb_logname.Name = "tb_logname";
            this.tb_logname.ReadOnly = true;
            this.tb_logname.Size = new System.Drawing.Size(100, 49);
            this.tb_logname.TabIndex = 0;
            this.tb_logname.TabStop = false;
            this.tb_logname.Text = "Machine Name:\r\nUser:\r\nDate:";
            // 
            // tb_logdetails
            // 
            this.tb_logdetails.AcceptsReturn = true;
            this.tb_logdetails.Location = new System.Drawing.Point(118, 12);
            this.tb_logdetails.Multiline = true;
            this.tb_logdetails.Name = "tb_logdetails";
            this.tb_logdetails.ReadOnly = true;
            this.tb_logdetails.Size = new System.Drawing.Size(183, 49);
            this.tb_logdetails.TabIndex = 1;
            this.tb_logdetails.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 78);
            this.Controls.Add(this.tb_logdetails);
            this.Controls.Add(this.tb_logname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_logname;
        private System.Windows.Forms.TextBox tb_logdetails;
    }
}

