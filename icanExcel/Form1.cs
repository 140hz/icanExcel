//Elaborado por Oscar Abraham Arroyo Gómez
//b7sed
//Lunes 24 de Octubre del 2022

using DocumentFormat.OpenXml.Wordprocessing;
using SpreadsheetLight;
using System.Windows.Forms;

namespace icanExcel
{
    public partial class mainForm : Form
    {
        
        private string path = @"c:\";
        private string path2 = @"c:\";
        public mainForm()
        {
            InitializeComponent();
            /*MessageBox.Show("¿Primera vez utilizando esta herramienta? Da click en el botón AYUDA para más información.", "Bienvenido",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);*/
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<datosViewModel> list = new List<datosViewModel>();

            datagridExcel1.DataSource = list;

            List<datosViewModel> list2 = new List<datosViewModel>();

            datagridExcel2.DataSource = list2;
            try
            {
                SaveFileDialog saveD = new SaveFileDialog();
                saveD.Filter = "Libro de Excel|.xlsx";
                saveD.Title = "Guardar Excel";
                saveD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (saveD.ShowDialog() == DialogResult.OK)
                {
                    SLDocument originalDoc = new SLDocument(archivox1.Text);
                    SLDocument sheetDoc = new SLDocument(archivox2.Text);


                    //int iRow = 1;

                    //while (!string.IsNullOrEmpty(originalDoc.GetCellValueAsString(iRow, 1)))
                    //{
                        sheetDoc.SetCellValue("A1",originalDoc.GetCellValueAsString("A1"));
                        sheetDoc.SetCellValue("A2", originalDoc.GetCellValueAsString("A2"));
                    

                    sheetDoc.SaveAs(saveD.FileName);
                    MessageBox.Show("Archivo guardado existosamente en " + saveD.FileName);
                }
                else
                {
                    MessageBox.Show("Hubo un ERROR al guardar el archivo, vuelve a intentarlo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnExcel2.Enabled = true;
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
                    archivox1.Text = path;
                    SLDocument sl = new SLDocument(path);

                    int iRow = 2;
                    List<datosViewModel> list = new List<datosViewModel>();


                    while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                    {
                        //string fecha = "2005/05/05 22:12 PM";
                        datosViewModel bDatos = new datosViewModel();
                        bDatos.ID = sl.GetCellValueAsString(iRow, 1);
                        bDatos.Email = sl.GetCellValueAsString(iRow, 2);
                        bDatos.Billing_Phone = sl.GetCellValueAsString(iRow, 16);
                        bDatos.Billing_Name = sl.GetCellValueAsString(iRow, 25);
                        bDatos.Fulfilled_at = sl.GetCellValueAsString(iRow, 6);
                        //DateTime oDate = DateTime.ParseExact(fecha, "yyyy/MM/dd HH:mm tt", System.Globalization.CultureInfo.InvariantCulture);
                        //box1.Text = (oDate.ToString());
                        bDatos.Notes = sl.GetCellValueAsString(iRow, 45);

                        list.Add(bDatos);
                        iRow++;
                    }

                    datagridExcel1.DataSource = list;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            }
        }

        private void btnExcel2_Click(object sender, EventArgs e)
        {
            btnGenExcel.Enabled = true;
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
                    path2 = of.FileName;
                    archivox2.Text = path2;
                    SLDocument sl = new SLDocument(path2);

                    int iRow = 2;
                    List<datosViewModel> list = new List<datosViewModel>();


                    while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                    {
                        //string fecha = "2005/05/05 22:12 PM";
                        datosViewModel bDatos = new datosViewModel();
                        bDatos.ID = sl.GetCellValueAsString(iRow, 1);
                        bDatos.Email = sl.GetCellValueAsString(iRow, 2);
                        bDatos.Billing_Phone = sl.GetCellValueAsString(iRow, 16);
                        bDatos.Billing_Name = sl.GetCellValueAsString(iRow, 25);
                        bDatos.Fulfilled_at = sl.GetCellValueAsString(iRow, 6);
                        //DateTime oDate = DateTime.ParseExact(fecha, "yyyy/MM/dd HH:mm tt", System.Globalization.CultureInfo.InvariantCulture);
                        //box1.Text = (oDate.ToString());
                        bDatos.Notes = sl.GetCellValueAsString(iRow, 45);

                        list.Add(bDatos);
                        iRow++;
                    }

                    datagridExcel2.DataSource = list;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            }

        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new FormArchivos();
            Button regresar = new Button();
            regresar.Text = "regresar";
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Form frm = new formAyuda();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            
        }
    }
}