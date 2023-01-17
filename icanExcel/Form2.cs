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
using Tulpep.NotificationWindow;

namespace icanExcel
{
    public partial class FormArchivos : Form
    {
        private string path = @"c:\";
        private string path2 = @"\Users\oscar\OneDrive\Documentos\ICAN\prueba.xlsx";
        public FormArchivos()
        {
            InitializeComponent();
            /*MessageBox.Show("¿Primera vez utilizando esta herramienta? Da click en el botón AYUDA para más información.", "Bienvenido",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);*/

            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Notification!";
            popup.BodyColor = Color.Red;
            popup.TitleText = "AVISO";
            popup.TitleColor = Color.White;
            popup.ContentColor = Color.White;
            popup.ContentText = "Esta ventana no ha sido implementada, intentalo mas tarde!";
            popup.Popup();
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
                    SLDocument sheetDoc = new SLDocument(path); //existing
                    SLDocument origDoc = new SLDocument(path2); //existing
                    sheetDoc.AddWorksheet("SecondSheet");
                    //loop to copy the needed information (whole sheet in this case):
                    sheetDoc.SetCellValue("A1", origDoc.GetCellValueAsString("A1"));
                    sheetDoc.SetCellValue("A2", origDoc.GetCellValueAsString("A2"));

                    sheetDoc.SaveAs("FinalSheet.xlsx");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            }
        }
    }
}
