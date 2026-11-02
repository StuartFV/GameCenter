namespace GameCenter_GUI
{
    partial class frmPrincipal
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
            menuStrip1 = new MenuStrip();
            mnuArchivo = new ToolStripMenuItem();
            mnuArchivoNuevo = new ToolStripMenuItem();
            mnuArchivoSalir = new ToolStripMenuItem();
            mnuVideojuegos = new ToolStripMenuItem();
            mnuVideojuegosRegistrar = new ToolStripMenuItem();
            consultarPorPeriodoToolStripMenuItem = new ToolStripMenuItem();
            mnuVideojuegosBiblioteca = new ToolStripMenuItem();
            mnuVideojuegosRecomendaciones = new ToolStripMenuItem();
            mnuVentanas = new ToolStripMenuItem();
            mnuVentanasCascada = new ToolStripMenuItem();
            mnuVentanasMosaicoHorizontal = new ToolStripMenuItem();
            mnuHerramientas = new ToolStripMenuItem();
            mnuHerramientasLimpiar = new ToolStripMenuItem();
            mnuHerramientasConfiguracion = new ToolStripMenuItem();
            mnuAyuda = new ToolStripMenuItem();
            mnuAyudaManual = new ToolStripMenuItem();
            mnuAyudaAcercaDe = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblEstado = new ToolStripStatusLabel();
            lblAplicacion = new ToolStripStatusLabel();
            lblVersion = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuArchivo, mnuVideojuegos, mnuVentanas, mnuHerramientas, mnuAyuda });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuArchivo
            // 
            mnuArchivo.DropDownItems.AddRange(new ToolStripItem[] { mnuArchivoNuevo, mnuArchivoSalir });
            mnuArchivo.Name = "mnuArchivo";
            mnuArchivo.Size = new Size(60, 20);
            mnuArchivo.Text = "Archivo";
            // 
            // mnuArchivoNuevo
            // 
            mnuArchivoNuevo.Name = "mnuArchivoNuevo";
            mnuArchivoNuevo.ShortcutKeys = Keys.Control | Keys.Alt | Keys.C;
            mnuArchivoNuevo.Size = new Size(180, 22);
            mnuArchivoNuevo.Text = "Nuevo";
            // 
            // mnuArchivoSalir
            // 
            mnuArchivoSalir.Name = "mnuArchivoSalir";
            mnuArchivoSalir.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuArchivoSalir.Size = new Size(180, 22);
            mnuArchivoSalir.Text = "Salir";
            mnuArchivoSalir.Click += mnuArchivoSalir_Click;
            // 
            // mnuVideojuegos
            // 
            mnuVideojuegos.DropDownItems.AddRange(new ToolStripItem[] { mnuVideojuegosRegistrar, consultarPorPeriodoToolStripMenuItem, mnuVideojuegosBiblioteca, mnuVideojuegosRecomendaciones });
            mnuVideojuegos.Name = "mnuVideojuegos";
            mnuVideojuegos.Size = new Size(84, 20);
            mnuVideojuegos.Text = "Videojuegos";
            // 
            // mnuVideojuegosRegistrar
            // 
            mnuVideojuegosRegistrar.Name = "mnuVideojuegosRegistrar";
            mnuVideojuegosRegistrar.ShortcutKeys = Keys.Control | Keys.Shift | Keys.E;
            mnuVideojuegosRegistrar.Size = new Size(300, 22);
            mnuVideojuegosRegistrar.Text = "Registrar videojuegos";
            mnuVideojuegosRegistrar.Click += mnuVideojuegosRegistrar_Click;
            // 
            // consultarPorPeriodoToolStripMenuItem
            // 
            consultarPorPeriodoToolStripMenuItem.Name = "consultarPorPeriodoToolStripMenuItem";
            consultarPorPeriodoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.F;
            consultarPorPeriodoToolStripMenuItem.Size = new Size(300, 22);
            consultarPorPeriodoToolStripMenuItem.Text = "Consultar por Periodo";
            consultarPorPeriodoToolStripMenuItem.Click += consultarPorPeriodoToolStripMenuItem_Click;
            // 
            // mnuVideojuegosBiblioteca
            // 
            mnuVideojuegosBiblioteca.Name = "mnuVideojuegosBiblioteca";
            mnuVideojuegosBiblioteca.Size = new Size(300, 22);
            mnuVideojuegosBiblioteca.Text = "Biblioteca";
            // 
            // mnuVideojuegosRecomendaciones
            // 
            mnuVideojuegosRecomendaciones.Name = "mnuVideojuegosRecomendaciones";
            mnuVideojuegosRecomendaciones.Size = new Size(300, 22);
            mnuVideojuegosRecomendaciones.Text = "Recomendaciones";
            // 
            // mnuVentanas
            // 
            mnuVentanas.DropDownItems.AddRange(new ToolStripItem[] { mnuVentanasCascada, mnuVentanasMosaicoHorizontal });
            mnuVentanas.Name = "mnuVentanas";
            mnuVentanas.Size = new Size(66, 20);
            mnuVentanas.Text = "Ventanas";
            // 
            // mnuVentanasCascada
            // 
            mnuVentanasCascada.Name = "mnuVentanasCascada";
            mnuVentanasCascada.ShortcutKeys = Keys.Control | Keys.Alt | Keys.A;
            mnuVentanasCascada.Size = new Size(187, 22);
            mnuVentanasCascada.Text = "Cascada";
            mnuVentanasCascada.Click += mnuVentanasCascada_Click;
            // 
            // mnuVentanasMosaicoHorizontal
            // 
            mnuVentanasMosaicoHorizontal.Name = "mnuVentanasMosaicoHorizontal";
            mnuVentanasMosaicoHorizontal.ShortcutKeys = Keys.Control | Keys.Alt | Keys.M;
            mnuVentanasMosaicoHorizontal.Size = new Size(187, 22);
            mnuVentanasMosaicoHorizontal.Text = "Mosaico";
            mnuVentanasMosaicoHorizontal.Click += mnuVentanasMosaicoHorizontal_Click;
            // 
            // mnuHerramientas
            // 
            mnuHerramientas.DropDownItems.AddRange(new ToolStripItem[] { mnuHerramientasLimpiar, mnuHerramientasConfiguracion });
            mnuHerramientas.Name = "mnuHerramientas";
            mnuHerramientas.Size = new Size(90, 20);
            mnuHerramientas.Text = "Herramientas";
            // 
            // mnuHerramientasLimpiar
            // 
            mnuHerramientasLimpiar.Name = "mnuHerramientasLimpiar";
            mnuHerramientasLimpiar.ShortcutKeys = Keys.Control | Keys.Shift | Keys.F11;
            mnuHerramientasLimpiar.Size = new Size(297, 22);
            mnuHerramientasLimpiar.Text = "Limpiar Formulario";
            // 
            // mnuHerramientasConfiguracion
            // 
            mnuHerramientasConfiguracion.Name = "mnuHerramientasConfiguracion";
            mnuHerramientasConfiguracion.Size = new Size(297, 22);
            mnuHerramientasConfiguracion.Text = "Configuracion";
            // 
            // mnuAyuda
            // 
            mnuAyuda.DropDownItems.AddRange(new ToolStripItem[] { mnuAyudaManual, mnuAyudaAcercaDe });
            mnuAyuda.Name = "mnuAyuda";
            mnuAyuda.Size = new Size(53, 20);
            mnuAyuda.Text = "Ayuda";
            // 
            // mnuAyudaManual
            // 
            mnuAyudaManual.Name = "mnuAyudaManual";
            mnuAyudaManual.Size = new Size(180, 22);
            mnuAyudaManual.Text = "Manual";
            // 
            // mnuAyudaAcercaDe
            // 
            mnuAyudaAcercaDe.Name = "mnuAyudaAcercaDe";
            mnuAyudaAcercaDe.Size = new Size(180, 22);
            mnuAyudaAcercaDe.Text = "Acerca de";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblEstado, lblAplicacion, lblVersion });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblEstado
            // 
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 17);
            lblEstado.Text = "● Listo";
            // 
            // lblAplicacion
            // 
            lblAplicacion.Name = "lblAplicacion";
            lblAplicacion.Size = new Size(86, 17);
            lblAplicacion.Text = "GAME CENTER";
            // 
            // lblVersion
            // 
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(28, 17);
            lblVersion.Text = "v1.0";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GAME CENTER";
            WindowState = FormWindowState.Maximized;
            FormClosing += frmPrincipal_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuArchivo;
        private ToolStripMenuItem mnuVideojuegos;
        private ToolStripMenuItem mnuHerramientas;
        private ToolStripMenuItem mnuAyuda;
        private ToolStripMenuItem mnuArchivoNuevo;
        private ToolStripMenuItem mnuArchivoSalir;
        private ToolStripMenuItem mnuVideojuegosRegistrar;
        private ToolStripMenuItem mnuVideojuegosBiblioteca;
        private ToolStripMenuItem mnuVideojuegosRecomendaciones;
        private ToolStripMenuItem mnuHerramientasLimpiar;
        private ToolStripMenuItem mnuHerramientasConfiguracion;
        private ToolStripMenuItem mnuAyudaManual;
        private ToolStripMenuItem mnuAyudaAcercaDe;
        private ToolStripMenuItem mnuVentanas;
        private ToolStripMenuItem mnuVentanasCascada;
        private ToolStripMenuItem mnuVentanasMosaicoHorizontal;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblEstado;
        private ToolStripStatusLabel lblAplicacion;
        private ToolStripStatusLabel lblVersion;
        private ToolStripMenuItem consultarPorPeriodoToolStripMenuItem;
    }
}