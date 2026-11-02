using GameCenter_BE;
using GameCenter_BL;
using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GameCenter_GUI
{
    public partial class frmGameCenter : Form
    {

        private List<VideojuegoBE> videojuegos = new List<VideojuegoBE>();

        public frmGameCenter()
        {
            InitializeComponent();

            cmbGenero.Items.Add("Acción");
            cmbGenero.Items.Add("Aventura");
            cmbGenero.Items.Add("RPG");
            cmbGenero.Items.Add("Terror");
            cmbGenero.Items.Add("Deportes");
            cmbGenero.Items.Add("Carreras");
            cmbGenero.Items.Add("Shooter");
            cmbGenero.Items.Add("Estrategia");

            cmbPlataforma.Items.Add("PC");
            cmbPlataforma.Items.Add("PlayStation 5");
            cmbPlataforma.Items.Add("PlayStation 4");
            cmbPlataforma.Items.Add("Xbox Series X/S");
            cmbPlataforma.Items.Add("Xbox One");
            cmbPlataforma.Items.Add("Nintendo Switch");
            cmbPlataforma.Items.Add("Nintendo Switch 2");

            nudPuntuacion.Minimum = 0;
            nudPuntuacion.Maximum = 10;
            nudPuntuacion.Increment = 0.1M;
            nudPuntuacion.DecimalPlaces = 1;

            trbDificultad.Minimum = 1;
            trbDificultad.Maximum = 10;
            trbDificultad.Value = 5;

            clbCaracteristicas.Items.Add("Historia");
            clbCaracteristicas.Items.Add("Mundo abierto");
            clbCaracteristicas.Items.Add("Cooperativo");
            clbCaracteristicas.Items.Add("Terror");
            clbCaracteristicas.Items.Add("Supervivencia");
            clbCaracteristicas.Items.Add("Multijugador");

            // Cargamos la biblioteca al iniciar la ventana
            CargarBiblioteca();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Instanciar la entidad BE
                VideojuegoBE obj = new VideojuegoBE();

                // 2. Capturar los datos desde los controles de la pantalla (GUI)
                obj.Nombre = txtNombre.Text.Trim();
                obj.Genero = cmbGenero.SelectedItem?.ToString() ?? "";
                obj.Plataforma = cmbPlataforma.SelectedItem?.ToString() ?? "";
                obj.Fecha = dtpLanzamiento.Value;
                obj.FechaLanzamiento = DateOnly.FromDateTime(dtpLanzamiento.Value);
                obj.Puntuacion = nudPuntuacion.Value;
                obj.Dificultad = (int)trbDificultad.Value;
                obj.Terminado = chkTerminado.Checked;
                obj.Multijugador = chkMultijugador.Checked;
                obj.TipoCompra = rdoDigital.Checked ? "Digital" : (rdoFisico.Checked ? "Físico" : "");
                obj.Descripcion = rtbDescripcion.Text.Trim();

                // 3. Enviar a la capa de negocio usando VideojuegoBL
                VideojuegoBL logica = new VideojuegoBL();
                logica.RegistrarVideojuego(obj);

                MessageBox.Show("¡Videojuego registrado con éxito!", "Game Center", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarBiblioteca();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();

            cmbGenero.SelectedIndex = -1;
            cmbPlataforma.SelectedIndex = -1;

            dtpLanzamiento.Value = DateTime.Now;

            nudPuntuacion.Value = 0;

            trbDificultad.Value = 5;

            chkTerminado.Checked = false;
            chkMultijugador.Checked = false;

            rdoDigital.Checked = false;
            rdoFisico.Checked = false;

            rtbDescripcion.Clear();

            for (int i = 0; i < clbCaracteristicas.Items.Count; i++)
            {
                clbCaracteristicas.SetItemChecked(i, false);
            }

            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstJuegos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un videojuego de la biblioteca.", "Game Center", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Agregar confirmación
            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea eliminar este videojuego?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.No) return;

            VideojuegoBE juegoSeleccionado = (VideojuegoBE)lstJuegos.SelectedItem;
            VideojuegoBL logica = new VideojuegoBL();
            bool eliminado = logica.EliminarVideojuego(juegoSeleccionado.IdVideojuego);

            if (eliminado)
            {
                MessageBox.Show("Videojuego eliminado correctamente.", "Game Center", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarBiblioteca();
                btnLimpiar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el videojuego.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstJuegos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstJuegos.SelectedIndex == -1)
            {
                return;
            }

            VideojuegoBE juego = (VideojuegoBE)lstJuegos.SelectedItem;

            txtNombre.Text = juego.Nombre;

            if (!string.IsNullOrEmpty(juego.Genero))
            {
                cmbGenero.SelectedItem = juego.Genero;
            }
            else
            {
                cmbGenero.SelectedIndex = -1;
            }

            if (!string.IsNullOrEmpty(juego.Plataforma))
            {
                cmbPlataforma.SelectedItem = juego.Plataforma;
            }
            else
            {
                cmbPlataforma.SelectedIndex = -1;
            }

            dtpLanzamiento.Value = juego.Fecha;
            nudPuntuacion.Value = juego.Puntuacion;
            trbDificultad.Value = juego.Dificultad;

            chkTerminado.Checked = juego.Terminado;
            chkMultijugador.Checked = juego.Multijugador;

            rdoDigital.Checked = juego.TipoCompra == "Digital";
            rdoFisico.Checked = juego.TipoCompra == "Físico";

            rtbDescripcion.Text = juego.Descripcion;

            // Nota: Asegúrate de manejar tus características según cómo las guardes en BE
        }

        private void CargarBiblioteca()
        {
            VideojuegoBL logica = new VideojuegoBL();
            List<VideojuegoBE> listaJuegos = logica.ListarVideojuegos("");

            lstJuegos.Items.Clear();
            foreach (var juego in listaJuegos)
            {
                lstJuegos.Items.Add(juego);
            }
        }

        private void grpCaracteristicas_Enter(object sender, EventArgs e)
        {

        }
    }
}