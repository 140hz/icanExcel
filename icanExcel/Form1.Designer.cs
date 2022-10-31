namespace icanExcel
{
    partial class Form1
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
            this.datagridExcel1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.datagridExcel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridExcel2)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridExcel1
            // 
            this.datagridExcel1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridExcel1.Location = new System.Drawing.Point(47, 109);
            this.datagridExcel1.Name = "datagridExcel1";
            this.datagridExcel1.RowHeadersWidth = 51;
            this.datagridExcel1.RowTemplate.Height = 29;
            this.datagridExcel1.Size = new System.Drawing.Size(720, 155);
            this.datagridExcel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 510);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 93);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generar CSV / XLSX";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Archivo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnExcel1
            // 
            this.btnExcel1.Location = new System.Drawing.Point(616, 74);
            this.btnExcel1.Name = "btnExcel1";
            this.btnExcel1.Size = new System.Drawing.Size(146, 29);
            this.btnExcel1.TabIndex = 3;
            this.btnExcel1.Text = "Excel 1";
            this.btnExcel1.UseVisualStyleBackColor = true;
            this.btnExcel1.Click += new System.EventHandler(this.button2_Click);
            // 
            // datagridExcel2
            // 
            this.datagridExcel2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridExcel2.Location = new System.Drawing.Point(47, 305);
            this.datagridExcel2.Name = "datagridExcel2";
            this.datagridExcel2.RowHeadersWidth = 51;
            this.datagridExcel2.RowTemplate.Height = 29;
            this.datagridExcel2.Size = new System.Drawing.Size(720, 155);
            this.datagridExcel2.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnExcel2
            // 
            this.btnExcel2.Location = new System.Drawing.Point(621, 270);
            this.btnExcel2.Name = "btnExcel2";
            this.btnExcel2.Size = new System.Drawing.Size(146, 29);
            this.btnExcel2.TabIndex = 7;
            this.btnExcel2.Text = "Excel 2";
            this.btnExcel2.UseVisualStyleBackColor = true;
            this.btnExcel2.Click += new System.EventHandler(this.btnExcel2_Click);
            // 
            // archivox1
            // 
            this.archivox1.Location = new System.Drawing.Point(131, 76);
            this.archivox1.Name = "archivox1";
            this.archivox1.Size = new System.Drawing.Size(479, 27);
            this.archivox1.TabIndex = 8;
            // 
            // archivox2
            // 
            this.archivox2.Location = new System.Drawing.Point(131, 272);
            this.archivox2.Name = "archivox2";
            this.archivox2.Size = new System.Drawing.Size(479, 27);
            this.archivox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Archivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ingresa los archivos excel";
            // 
            // btnMore
            // 
            this.btnMore.Location = new System.Drawing.Point(599, 653);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(165, 74);
            this.btnMore.TabIndex = 12;
            this.btnMore.Text = "Más de 2 archivos?";
            this.btnMore.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 753);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.archivox2);
            this.Controls.Add(this.archivox1);
            this.Controls.Add(this.btnExcel2);
            this.Controls.Add(this.datagridExcel2);
            this.Controls.Add(this.btnExcel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datagridExcel1);
            this.Name = "Form1";
            this.Text = "ICAN Excel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridExcel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridExcel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView datagridExcel1;
        private Button button1;
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
    }
}