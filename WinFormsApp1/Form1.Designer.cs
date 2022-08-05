namespace WinFormsApp1
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
            this.data1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlibro = new System.Windows.Forms.TextBox();
            this.btncerrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            this.SuspendLayout();
            // 
            // data1
            // 
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Libro,
            this.Fecha_Actual,
            this.Fecha_Entrega});
            this.data1.Location = new System.Drawing.Point(79, 139);
            this.data1.Name = "data1";
            this.data1.RowTemplate.Height = 25;
            this.data1.Size = new System.Drawing.Size(445, 150);
            this.data1.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Libro
            // 
            this.Libro.HeaderText = "Libro";
            this.Libro.Name = "Libro";
            // 
            // Fecha_Actual
            // 
            this.Fecha_Actual.HeaderText = "Fecha_Actual";
            this.Fecha_Actual.Name = "Fecha_Actual";
            // 
            // Fecha_Entrega
            // 
            this.Fecha_Entrega.HeaderText = "Fecha_Entrega";
            this.Fecha_Entrega.Name = "Fecha_Entrega";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(79, 15);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 23);
            this.txtnombre.TabIndex = 1;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(60, 93);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "Ok";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Libro";
            // 
            // txtlibro
            // 
            this.txtlibro.Location = new System.Drawing.Point(79, 55);
            this.txtlibro.Name = "txtlibro";
            this.txtlibro.Size = new System.Drawing.Size(100, 23);
            this.txtlibro.TabIndex = 5;
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(449, 321);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 23);
            this.btncerrar.TabIndex = 6;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 404);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.txtlibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.data1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView data1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Libro;
        private DataGridViewTextBoxColumn Fecha_Actual;
        private DataGridViewTextBoxColumn Fecha_Entrega;
        private TextBox txtnombre;
        private Button btnok;
        private Label label1;
        private Label label2;
        private TextBox txtlibro;
        private Button btncerrar;
        private Button button1;
    }
}