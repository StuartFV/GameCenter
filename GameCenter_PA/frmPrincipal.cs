using GameCenter_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameCenter_GUI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // <--- ¡Esto es lo único obligatorio para que sea MDI!
        }

        // Evento para abrir tu formulario de Mantenimiento / Registro
        private void mnuVideojuegosRegistrar_Click(object sender, EventArgs e)
        {
            frmGameCenter formulario = new frmGameCenter();
            formulario.MdiParent = this;
            formulario.Show();
        }

        // Evento para abrir tu formulario de Consulta por Periodo y Reporte Excel
        private void mnuVideojuegosPeriodo_Click(object sender, EventArgs e)
        {
            frmVideojuegosPeriodo formularioPeriodo = new frmVideojuegosPeriodo();
            formularioPeriodo.MdiParent = this;
            formularioPeriodo.Show();
        }

        // Evento para organizar las ventanas en Cascada (Requisito B1 y para la Captura 2)
        private void mnuVentanasCascada_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        // Evento para organizar en Mosaico Horizontal
        private void mnuVentanasMosaicoHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        // Evento para Salir desde el menú
        private void mnuArchivoSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Evento para el cierre con confirmación (Requisito B3)
        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea salir?",
                "Game Center",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (respuesta == DialogResult.No)
            {
                e.Cancel = true; // Cancela el cierre
            }
        }

        private void consultarPorPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVideojuegosPeriodo formularioPeriodo = new frmVideojuegosPeriodo();
            formularioPeriodo.MdiParent = this;
            formularioPeriodo.Show();
        }
    }
}