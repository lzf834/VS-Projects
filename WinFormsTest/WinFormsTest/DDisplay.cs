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
    public partial class DDisplay : Form
    {
        public DDisplay()
        {
            InitializeComponent();
            //Using textbox
            //tb_logdetails.Text += Environment.MachineName + "\r\n";
            //tb_logdetails.Text += Environment.UserName + "\r\n";
            //tb_logdetails.Text += DateTime.Now.ToLongDateString() + "\r\n";

            //Setting base table properties
            dataGridView1.ColumnCount = 1;
            dataGridView1.RowCount = 4;
            dataGridView1.RowHeadersWidth = 130;
            dataGridView1.AutoSize = true;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns[0].Name = "Properties";

            dataGridView1.Rows[0].HeaderCell.Value = "Machine Name";
            dataGridView1.Rows[1].HeaderCell.Value = "User Name";
            dataGridView1.Rows[2].HeaderCell.Value = "Date";
            dataGridView1.Rows[3].HeaderCell.Value = "Time";

            dataGridView1.Rows[0].Cells[0].Value = Environment.MachineName;
            dataGridView1.Rows[1].Cells[0].Value = Environment.UserName;
            dataGridView1.Rows[2].Cells[0].Value = DateTime.Now.ToShortDateString();
            dataGridView1.Rows[3].Cells[0].Value = DateTime.Now.ToShortTimeString();
        }
    }
}
