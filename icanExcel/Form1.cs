//Elaborado por Oscar Abraham Arroyo Gómez
//b7sed
//Lunes 24 de Octubre del 2022

using SpreadsheetLight;

namespace icanExcel
{
    public partial class Form1 : Form
    {
        //private string archivoExcel = @"C:\\Users\\oscar\\Documents\\ICAN\\icanExcel\\icanExcel\\prueba.xlsx";
        //private string path = @"c:\";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"";
            try
            {
                OpenFileDialog of = new OpenFileDialog();
                of.InitialDirectory = @"c:\";
                of.Filter = "CSV files (*.csv)|*.csv|Excel Files|*.xls;*.xlsx;*.xlsm";
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
                        datosViewModel bDatos = new datosViewModel();
                        bDatos.ID = sl.GetCellValueAsString(iRow, 2);
                        bDatos.Email = sl.GetCellValueAsString(iRow, 3);
                        bDatos.Billing_Phone = sl.GetCellValueAsString(iRow, 4);
                        bDatos.Billing_Name = sl.GetCellValueAsString(iRow, 5);
                        bDatos.Fulfilled_at = sl.GetCellValueAsString(iRow, 6);
                        bDatos.Notes = sl.GetCellValueAsString(iRow, 7);

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
            string path = @"";
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
                    archivox2.Text = path;
                    SLDocument sl = new SLDocument(path);

                    int iRow = 2;
                    List<datosViewModel> list = new List<datosViewModel>();


                    while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
                    {
                        datosViewModel bDatos = new datosViewModel();
                        bDatos.ID = sl.GetCellValueAsString(iRow, 2);
                        bDatos.Email = sl.GetCellValueAsString(iRow, 3);
                        bDatos.Billing_Phone = sl.GetCellValueAsString(iRow, 4);
                        bDatos.Billing_Name = sl.GetCellValueAsString(iRow, 5);
                        bDatos.Fulfilled_at = sl.GetCellValueAsString(iRow, 6);
                        bDatos.Notes = sl.GetCellValueAsString(iRow, 7);

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
    }
}