namespace GameCenter_GUI
{
    partial class frmGameCenter
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
            lblTitulo = new Label();
            grpInformacion = new GroupBox();
            rdoFisico = new RadioButton();
            rdoDigital = new RadioButton();
            label6 = new Label();
            chkMultijugador = new CheckBox();
            chkTerminado = new CheckBox();
            trbDificultad = new TrackBar();
            label5 = new Label();
            nudPuntuacion = new NumericUpDown();
            label4 = new Label();
            dtpLanzamiento = new DateTimePicker();
            cmbPlataforma = new ComboBox();
            cmbGenero = new ComboBox();
            lblLanzamiento = new Label();
            lblPlataforma = new Label();
            lblGenero = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            grpPortada = new GroupBox();
            lnkPagina = new LinkLabel();
            picPortada = new PictureBox();
            grpDescripcion = new GroupBox();
            rtbDescripcion = new RichTextBox();
            grpCaracteristicas = new GroupBox();
            clbCaracteristicas = new CheckedListBox();
            prgProgeso = new ProgressBar();
            lblProgreso = new Label();
            grpBiblioteca = new GroupBox();
            lstJuegos = new ListBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnRecomendar = new Button();
            grpInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbDificultad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPuntuacion).BeginInit();
            grpPortada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPortada).BeginInit();
            grpDescripcion.SuspendLayout();
            grpCaracteristicas.SuspendLayout();
            grpBiblioteca.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 20F);
            lblTitulo.ImageAlign = ContentAlignment.MiddleRight;
            lblTitulo.Location = new Point(266, 11);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(252, 31);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "🎮 GAME CENTER";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // grpInformacion
            // 
            grpInformacion.Controls.Add(rdoFisico);
            grpInformacion.Controls.Add(rdoDigital);
            grpInformacion.Controls.Add(label6);
            grpInformacion.Controls.Add(chkMultijugador);
            grpInformacion.Controls.Add(chkTerminado);
            grpInformacion.Controls.Add(trbDificultad);
            grpInformacion.Controls.Add(label5);
            grpInformacion.Controls.Add(nudPuntuacion);
            grpInformacion.Controls.Add(label4);
            grpInformacion.Controls.Add(dtpLanzamiento);
            grpInformacion.Controls.Add(cmbPlataforma);
            grpInformacion.Controls.Add(cmbGenero);
            grpInformacion.Controls.Add(lblLanzamiento);
            grpInformacion.Controls.Add(lblPlataforma);
            grpInformacion.Controls.Add(lblGenero);
            grpInformacion.Controls.Add(txtNombre);
            grpInformacion.Controls.Add(lblNombre);
            grpInformacion.Location = new Point(21, 62);
            grpInformacion.Name = "grpInformacion";
            grpInformacion.Size = new Size(456, 339);
            grpInformacion.TabIndex = 1;
            grpInformacion.TabStop = false;
            grpInformacion.Text = "Informacion del juego";
            // 
            // rdoFisico
            // 
            rdoFisico.AutoSize = true;
            rdoFisico.Location = new Point(188, 297);
            rdoFisico.Name = "rdoFisico";
            rdoFisico.Size = new Size(55, 19);
            rdoFisico.TabIndex = 18;
            rdoFisico.TabStop = true;
            rdoFisico.Text = "Fisico";
            rdoFisico.UseVisualStyleBackColor = true;
            // 
            // rdoDigital
            // 
            rdoDigital.AutoSize = true;
            rdoDigital.Location = new Point(92, 297);
            rdoDigital.Name = "rdoDigital";
            rdoDigital.Size = new Size(59, 19);
            rdoDigital.TabIndex = 17;
            rdoDigital.TabStop = true;
            rdoDigital.Text = "Digital";
            rdoDigital.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 299);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 16;
            label6.Text = "Tipo:";
            // 
            // chkMultijugador
            // 
            chkMultijugador.AutoSize = true;
            chkMultijugador.Location = new Point(188, 258);
            chkMultijugador.Name = "chkMultijugador";
            chkMultijugador.Size = new Size(127, 19);
            chkMultijugador.TabIndex = 15;
            chkMultijugador.Text = "Tiene Multijugador";
            chkMultijugador.UseVisualStyleBackColor = true;
            // 
            // chkTerminado
            // 
            chkTerminado.AutoSize = true;
            chkTerminado.Location = new Point(39, 258);
            chkTerminado.Name = "chkTerminado";
            chkTerminado.Size = new Size(117, 19);
            chkTerminado.TabIndex = 14;
            chkTerminado.Text = "Juego Terminado";
            chkTerminado.UseVisualStyleBackColor = true;
            // 
            // trbDificultad
            // 
            trbDificultad.Location = new Point(131, 214);
            trbDificultad.Name = "trbDificultad";
            trbDificultad.Size = new Size(272, 45);
            trbDificultad.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 221);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 12;
            label5.Text = "Dificultad:";
            // 
            // nudPuntuacion
            // 
            nudPuntuacion.Location = new Point(131, 176);
            nudPuntuacion.Name = "nudPuntuacion";
            nudPuntuacion.Size = new Size(120, 23);
            nudPuntuacion.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 180);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 10;
            label4.Text = "Puntuacion:";
            // 
            // dtpLanzamiento
            // 
            dtpLanzamiento.Location = new Point(131, 141);
            dtpLanzamiento.Name = "dtpLanzamiento";
            dtpLanzamiento.Size = new Size(223, 23);
            dtpLanzamiento.TabIndex = 9;
            // 
            // cmbPlataforma
            // 
            cmbPlataforma.FormattingEnabled = true;
            cmbPlataforma.Location = new Point(131, 110);
            cmbPlataforma.Name = "cmbPlataforma";
            cmbPlataforma.Size = new Size(184, 23);
            cmbPlataforma.TabIndex = 8;
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(131, 79);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(184, 23);
            cmbGenero.TabIndex = 7;
            // 
            // lblLanzamiento
            // 
            lblLanzamiento.AutoSize = true;
            lblLanzamiento.Location = new Point(35, 146);
            lblLanzamiento.Name = "lblLanzamiento";
            lblLanzamiento.Size = new Size(78, 15);
            lblLanzamiento.TabIndex = 6;
            lblLanzamiento.Text = "Lanzamiento:";
            // 
            // lblPlataforma
            // 
            lblPlataforma.AutoSize = true;
            lblPlataforma.Location = new Point(35, 116);
            lblPlataforma.Name = "lblPlataforma";
            lblPlataforma.Size = new Size(68, 15);
            lblPlataforma.TabIndex = 4;
            lblPlataforma.Text = "Plataforma:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(36, 84);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(48, 15);
            lblGenero.TabIndex = 2;
            lblGenero.Text = "Genero:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(131, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(272, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(36, 50);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // grpPortada
            // 
            grpPortada.Controls.Add(lnkPagina);
            grpPortada.Controls.Add(picPortada);
            grpPortada.Location = new Point(483, 62);
            grpPortada.Name = "grpPortada";
            grpPortada.Size = new Size(314, 339);
            grpPortada.TabIndex = 2;
            grpPortada.TabStop = false;
            grpPortada.Text = "Portada del Juego";
            // 
            // lnkPagina
            // 
            lnkPagina.AutoSize = true;
            lnkPagina.Location = new Point(123, 313);
            lnkPagina.Name = "lnkPagina";
            lnkPagina.Size = new Size(80, 15);
            lnkPagina.TabIndex = 1;
            lnkPagina.TabStop = true;
            lnkPagina.Text = "Pagina Oficial";
            // 
            // picPortada
            // 
            picPortada.Location = new Point(46, 23);
            picPortada.Name = "picPortada";
            picPortada.Size = new Size(225, 283);
            picPortada.SizeMode = PictureBoxSizeMode.Zoom;
            picPortada.TabIndex = 0;
            picPortada.TabStop = false;
            // 
            // grpDescripcion
            // 
            grpDescripcion.Controls.Add(rtbDescripcion);
            grpDescripcion.Location = new Point(21, 407);
            grpDescripcion.Name = "grpDescripcion";
            grpDescripcion.Size = new Size(776, 220);
            grpDescripcion.TabIndex = 3;
            grpDescripcion.TabStop = false;
            grpDescripcion.Text = "Descripcion";
            // 
            // rtbDescripcion
            // 
            rtbDescripcion.Location = new Point(13, 22);
            rtbDescripcion.Name = "rtbDescripcion";
            rtbDescripcion.Size = new Size(747, 177);
            rtbDescripcion.TabIndex = 0;
            rtbDescripcion.Text = "";
            // 
            // grpCaracteristicas
            // 
            grpCaracteristicas.Controls.Add(clbCaracteristicas);
            grpCaracteristicas.Controls.Add(prgProgeso);
            grpCaracteristicas.Controls.Add(lblProgreso);
            grpCaracteristicas.Location = new Point(21, 633);
            grpCaracteristicas.Name = "grpCaracteristicas";
            grpCaracteristicas.Size = new Size(392, 198);
            grpCaracteristicas.TabIndex = 4;
            grpCaracteristicas.TabStop = false;
            grpCaracteristicas.Text = "Caracteristicas:";
            grpCaracteristicas.Enter += grpCaracteristicas_Enter;
            // 
            // clbCaracteristicas
            // 
            clbCaracteristicas.FormattingEnabled = true;
            clbCaracteristicas.Location = new Point(13, 29);
            clbCaracteristicas.Name = "clbCaracteristicas";
            clbCaracteristicas.Size = new Size(355, 112);
            clbCaracteristicas.TabIndex = 2;
            // 
            // prgProgeso
            // 
            prgProgeso.Location = new Point(105, 161);
            prgProgeso.Name = "prgProgeso";
            prgProgeso.Size = new Size(236, 23);
            prgProgeso.TabIndex = 1;
            // 
            // lblProgreso
            // 
            lblProgreso.AutoSize = true;
            lblProgreso.Location = new Point(36, 166);
            lblProgreso.Name = "lblProgreso";
            lblProgreso.Size = new Size(57, 15);
            lblProgreso.TabIndex = 0;
            lblProgreso.Text = "Progreso:";
            // 
            // grpBiblioteca
            // 
            grpBiblioteca.Controls.Add(lstJuegos);
            grpBiblioteca.Location = new Point(419, 633);
            grpBiblioteca.Name = "grpBiblioteca";
            grpBiblioteca.Size = new Size(378, 198);
            grpBiblioteca.TabIndex = 5;
            grpBiblioteca.TabStop = false;
            grpBiblioteca.Text = "Biblioteca de Videjuegos";
            // 
            // lstJuegos
            // 
            lstJuegos.FormattingEnabled = true;
            lstJuegos.Location = new Point(15, 29);
            lstJuegos.Name = "lstJuegos";
            lstJuegos.Size = new Size(347, 154);
            lstJuegos.TabIndex = 0;
            lstJuegos.SelectedIndexChanged += lstJuegos_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(60, 843);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 37);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(209, 843);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 37);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(365, 843);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 37);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnRecomendar
            // 
            btnRecomendar.Location = new Point(529, 842);
            btnRecomendar.Name = "btnRecomendar";
            btnRecomendar.Size = new Size(252, 37);
            btnRecomendar.TabIndex = 9;
            btnRecomendar.Text = "Recomiendame un juego";
            btnRecomendar.UseVisualStyleBackColor = true;
            // 
            // frmGameCenter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 888);
            Controls.Add(btnRecomendar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(grpBiblioteca);
            Controls.Add(grpCaracteristicas);
            Controls.Add(grpDescripcion);
            Controls.Add(grpPortada);
            Controls.Add(grpInformacion);
            Controls.Add(lblTitulo);
            Name = "frmGameCenter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Game Center - Biblioteca de Videojuegos";
            grpInformacion.ResumeLayout(false);
            grpInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trbDificultad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPuntuacion).EndInit();
            grpPortada.ResumeLayout(false);
            grpPortada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPortada).EndInit();
            grpDescripcion.ResumeLayout(false);
            grpCaracteristicas.ResumeLayout(false);
            grpCaracteristicas.PerformLayout();
            grpBiblioteca.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox grpInformacion;
        private Label lblNombre;
        private Label lblGenero;
        private TextBox txtNombre;
        private Label label4;
        private DateTimePicker dtpLanzamiento;
        private ComboBox cmbPlataforma;
        private ComboBox cmbGenero;
        private Label lblLanzamiento;
        private Label lblPlataforma;
        private TrackBar trbDificultad;
        private Label label5;
        private NumericUpDown nudPuntuacion;
        private RadioButton rdoFisico;
        private RadioButton rdoDigital;
        private Label label6;
        private CheckBox chkMultijugador;
        private CheckBox chkTerminado;
        private GroupBox grpPortada;
        private PictureBox picPortada;
        private LinkLabel lnkPagina;
        private GroupBox grpDescripcion;
        private RichTextBox rtbDescripcion;
        private GroupBox grpCaracteristicas;
        private Label lblProgreso;
        private GroupBox grpBiblioteca;
        private ListBox lstJuegos;
        private ProgressBar prgProgeso;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnRecomendar;
        private CheckedListBox clbCaracteristicas;
    }
}
