namespace GameCenter_GUI
{
    partial class frmVideojuegosPeriodo
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
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            cboPlataforma = new ComboBox();
            label3 = new Label();
            btnConsultar = new Button();
            btnExportar = new Button();
            dgvVideojuegos = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            Plataforma = new DataGridViewTextBoxColumn();
            Puntuacion = new DataGridViewTextBoxColumn();
            lblTotal = new Label();
            sfdGuardar = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dgvVideojuegos).BeginInit();
            SuspendLayout();
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(131, 26);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(95, 23);
            dtpDesde.TabIndex = 0;
            // 
            // dtpHasta
            // 
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(347, 26);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(96, 23);
            dtpHasta.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 34);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Desde:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 34);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Hasta:";
            // 
            // cboPlataforma
            // 
            cboPlataforma.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlataforma.FormattingEnabled = true;
            cboPlataforma.Location = new Point(602, 26);
            cboPlataforma.Name = "cboPlataforma";
            cboPlataforma.Size = new Size(121, 23);
            cboPlataforma.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(516, 34);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 5;
            label3.Text = "Plataforma:";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(509, 89);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 6;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(606, 89);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(117, 23);
            btnExportar.TabIndex = 7;
            btnExportar.Text = "Exportar a Excel";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // dgvVideojuegos
            // 
            dgvVideojuegos.AutoGenerateColumns = false;
            dgvVideojuegos.AllowUserToAddRows = false;
            dgvVideojuegos.AllowUserToDeleteRows = false;
            dgvVideojuegos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVideojuegos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVideojuegos.Columns.AddRange(new DataGridViewColumn[] { Fecha, Nombre, Genero, Plataforma, Puntuacion });
            dgvVideojuegos.Location = new Point(1, 161);
            dgvVideojuegos.Name = "dgvVideojuegos";
            dgvVideojuegos.ReadOnly = true;
            dgvVideojuegos.Size = new Size(736, 336);
            dgvVideojuegos.TabIndex = 8;
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "Fecha";
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 120;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 120;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 180;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 180;
            // 
            // Genero
            // 
            Genero.DataPropertyName = "Genero";
            Genero.HeaderText = "Genero";
            Genero.MinimumWidth = 150;
            Genero.Name = "Genero";
            Genero.ReadOnly = true;
            Genero.Width = 150;
            // 
            // Plataforma
            // 
            Plataforma.DataPropertyName = "Platafroma";
            Plataforma.HeaderText = "Plataforma";
            Plataforma.MinimumWidth = 150;
            Plataforma.Name = "Plataforma";
            Plataforma.ReadOnly = true;
            Plataforma.Width = 150;
            // 
            // Puntuacion
            // 
            Puntuacion.DataPropertyName = "Puntuacion";
            Puntuacion.HeaderText = "Puntuacion";
            Puntuacion.MinimumWidth = 100;
            Puntuacion.Name = "Puntuacion";
            Puntuacion.ReadOnly = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Variable Display", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(12, 507);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(237, 28);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Registros encontrados: 0";
            // 
            // sfdGuardar
            // 
            sfdGuardar.Title = "Filter = Libro de Excel (*.xlsx)|*.xlsx";
            // 
            // frmVideojuegosPeriodo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 544);
            Controls.Add(lblTotal);
            Controls.Add(dgvVideojuegos);
            Controls.Add(btnExportar);
            Controls.Add(btnConsultar);
            Controls.Add(label3);
            Controls.Add(cboPlataforma);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Name = "frmVideojuegosPeriodo";
            Text = "Consulta de Videojuegos por Periodo";
            Load += frmVideojuegosPeriodo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVideojuegos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private Label label1;
        private Label label2;
        private ComboBox cboPlataforma;
        private Label label3;
        private Button btnConsultar;
        private Button btnExportar;
        private DataGridView dgvVideojuegos;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn Plataforma;
        private DataGridViewTextBoxColumn Puntuacion;
        private Label lblTotal;
        private SaveFileDialog sfdGuardar;
    }
}