using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace icanExcel
{
    public partial class FormArchivos : Form
    {
        private string path = @"c:\";
        private string path2 = @"c:\";
        public FormArchivos()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form main = new mainForm();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog of = new OpenFileDialog();
                of.InitialDirectory = @"c:\";
                of.Filter = "Excel Files|*.xls;*.xlsx|CSV files (*.csv)|*.csv";
                of.FilterIndex = 1;
                of.RestoreDirectory = true;
                of.CheckFileExists = true;
                of.CheckPathExists = true;

                if (of.ShowDialog() == DialogResult.OK)
                {
                    path = of.FileName;
                    textBox1.Text = path;
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            }
        }
    }
}
