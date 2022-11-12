namespace icanExcel
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.datagridExcel1 = new System.Windows.Forms.DataGridView();
            this.btnGenExcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcel1 = new System.Windows.Forms.Button();
            this.datagridExcel2 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnExcel2 = new System.Windows.Forms.Button();
            this.archivox1 = new System.Windows.Forms.TextBox();
            this.archivox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMore = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnAyuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridExcel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridExcel2)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridExcel1
            // 
            this.datagridExcel1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridExcel1.Location = new System.Drawing.Point(41, 82);
            this.datagridExcel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagridExcel1.Name = "datagridExcel1";
            this.datagridExcel1.RowHeadersWidth = 51;
            this.datagridExcel1.RowTemplate.Height = 29;
            this.datagridExcel1.Size = new System.Drawing.Size(630, 170);
            this.datagridExcel1.TabIndex = 0;
            // 
            // btnGenExcel
            // 
            this.btnGenExcel.Enabled = false;
            this.btnGenExcel.Location = new System.Drawing.Point(296, 483);
            this.btnGenExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenExcel.Name = "btnGenExcel";
            this.btnGenExcel.Size = new System.Drawing.Size(125, 70);
            this.btnGenExcel.TabIndex = 1;
            this.btnGenExcel.Text = "Generar CSV / XLSX";
            this.btnGenExcel.UseVisualStyleBackColor = true;
            this.btnGenExcel.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Archivo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnExcel1
            // 
            this.btnExcel1.Location = new System.Drawing.Point(539, 56);
            this.btnExcel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcel1.Name = "btnExcel1";
            this.btnExcel1.Size = new System.Drawing.Size(128, 22);
            this.btnExcel1.TabIndex = 3;
            this.btnExcel1.Text = "Excel 1";
            this.btnExcel1.UseVisualStyleBackColor = true;
            this.btnExcel1.Click += new System.EventHandler(this.button2_Click);
            // 
            // datagridExcel2
            // 
            this.datagridExcel2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridExcel2.Location = new System.Drawing.Point(41, 282);
            this.datagridExcel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagridExcel2.Name = "datagridExcel2";
            this.datagridExcel2.RowHeadersWidth = 51;
            this.datagridExcel2.RowTemplate.Height = 29;
            this.datagridExcel2.Size = new System.Drawing.Size(630, 170);
            this.datagridExcel2.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnExcel2
            // 
            this.btnExcel2.Enabled = false;
            this.btnExcel2.Location = new System.Drawing.Point(543, 255);
            this.btnExcel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcel2.Name = "btnExcel2";
            this.btnExcel2.Size = new System.Drawing.Size(128, 22);
            this.btnExcel2.TabIndex = 7;
            this.btnExcel2.Text = "Excel 2";
            this.btnExcel2.UseVisualStyleBackColor = true;
            this.btnExcel2.Click += new System.EventHandler(this.btnExcel2_Click);
            // 
            // archivox1
            // 
            this.archivox1.Enabled = false;
            this.archivox1.Location = new System.Drawing.Point(115, 57);
            this.archivox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.archivox1.Name = "archivox1";
            this.archivox1.Size = new System.Drawing.Size(420, 23);
            this.archivox1.TabIndex = 8;
            // 
            // archivox2
            // 
            this.archivox2.Enabled = false;
            this.archivox2.Location = new System.Drawing.Point(115, 257);
            this.archivox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.archivox2.Name = "archivox2";
            this.archivox2.Size = new System.Drawing.Size(420, 23);
            this.archivox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Archivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ingresa los archivos Excel";
            // 
            // btnMore
            // 
            this.btnMore.Location = new System.Drawing.Point(524, 490);
            this.btnMore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(144, 56);
            this.btnMore.TabIndex = 12;
            this.btnMore.Text = "Más de 2 archivos?";
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(12, 530);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(49, 23);
            this.btnAyuda.TabIndex = 13;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 565);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.archivox2);
            this.Controls.Add(this.archivox1);
            this.Controls.Add(this.btnExcel2);
            this.Controls.Add(this.datagridExcel2);
            this.Controls.Add(this.btnExcel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenExcel);
            this.Controls.Add(this.datagridExcel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ICAN Excel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridExcel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridExcel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView datagridExcel1;
        private Button btnGenExcel;
        private Label label1;
        private Button btnExcel1;
        private DataGridView datagridExcel2;
        private OpenFileDialog openFileDialog1;
        private Button btnExcel2;
        private TextBox archivox1;
        private TextBox archivox2;
        private Label label2;
        private Label label3;
        private Button btnMore;
        private SaveFileDialog saveFileDialog1;
        private Button btnAyuda;
    }
}