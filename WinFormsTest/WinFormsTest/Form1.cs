using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tb_logdetails.Text += Environment.MachineName + "\r\n";
            tb_logdetails.Text += Environment.UserName + "\r\n";
            tb_logdetails.Text += DateTime.Now.ToLongDateString() + "\r\n";
        }
    }
}
