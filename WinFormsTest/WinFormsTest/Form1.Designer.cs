
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
            this.btn_displaylog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_logname
            // 
            this.tb_logname.Location = new System.Drawing.Point(33, 12);
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
            this.tb_logdetails.Location = new System.Drawing.Point(140, 12);
            this.tb_logdetails.Multiline = true;
            this.tb_logdetails.Name = "tb_logdetails";
            this.tb_logdetails.ReadOnly = true;
            this.tb_logdetails.Size = new System.Drawing.Size(183, 49);
            this.tb_logdetails.TabIndex = 1;
            // 
            // btn_displaylog
            // 
            this.btn_displaylog.Location = new System.Drawing.Point(67, 80);
            this.btn_displaylog.Name = "btn_displaylog";
            this.btn_displaylog.Size = new System.Drawing.Size(142, 23);
            this.btn_displaylog.TabIndex = 2;
            this.btn_displaylog.Text = "Display Information";
            this.btn_displaylog.UseVisualStyleBackColor = true;
            this.btn_displaylog.Click += new System.EventHandler(this.btn_displaylog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 119);
            this.Controls.Add(this.btn_displaylog);
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
        private System.Windows.Forms.Button btn_displaylog;
    }
}

