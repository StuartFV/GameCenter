using System;
using System.Data;
using System.Windows.Forms;
using ClosedXML.Excel;
using GameCenter_BL;

namespace GameCenter_GUI
{
    public partial class frmVideojuegosPeriodo : Form
    {
        // Instancia de la capa de negocio
        private VideojuegoBL _videojuegoBL = new VideojuegoBL();

        public frmVideojuegosPeriodo()
        {
            InitializeComponent();
        }

        private void frmVideojuegosPeriodo_Load(object sender, EventArgs e)
        {
            CargarPlataformas();

            // Rango amplio para abarcar cualquier fecha con la que se hayan registrado tus juegos
            dtpDesde.Value = new DateTime(2000, 1, 1);
            dtpHasta.Value = new DateTime(2030, 12, 31);
        }

        private void CargarPlataformas()
        {
            cboPlataforma.Items.Clear();
            cboPlataforma.Items.Add("Todos");
            cboPlataforma.Items.Add("PC");
            cboPlataforma.Items.Add("PlayStation 5");
            cboPlataforma.Items.Add("PlayStation 4");
            cboPlataforma.Items.Add("Xbox Series X");
            cboPlataforma.Items.Add("Xbox One");
            cboPlataforma.Items.Add("Nintendo Switch");
            // Agrega aquí cualquier otra plataforma que hayas registrado en tu sistema
            cboPlataforma.SelectedIndex = 0;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime desde = dtpDesde.Value;
                DateTime hasta = dtpHasta.Value;
                string plataforma = cboPlataforma.SelectedItem?.ToString();

                if (plataforma == "Todos") plataforma = "";

                var resultado = _videojuegoBL.ListarVideojuegosPorPeriodo(desde, hasta, plataforma);

                dgvVideojuegos.DataSource = resultado;

                // Actualiza el contador correctamente reflejando el total de filas
                lblTotal.Text = "Registros encontrados: " + dgvVideojuegos.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message, "Game Center", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVideojuegos.Rows.Count == 0)
                {
                    MessageBox.Show("No hay registros para exportar.", "Game Center", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Videojuegos");

                    // 1. Título del Reporte con el periodo
                    worksheet.Cell("A1").Value = "REPORTE DE VIDEOJUEGOS - GAME CENTER";
                    worksheet.Cell("A1").Style.Font.Bold = true;
                    worksheet.Cell("A1").Style.Font.FontSize = 14;
                    worksheet.Range("A1:F1").Merge();

                    // 2. Cabeceras personalizadas (Fila 3)
                    int row = 3;
                    worksheet.Cell(row, 1).Value = "ID";
                    worksheet.Cell(row, 2).Value = "Nombre";
                    worksheet.Cell(row, 3).Value = "Género";
                    worksheet.Cell(row, 4).Value = "Plataforma";
                    worksheet.Cell(row, 5).Value = "Puntuación";
                    worksheet.Cell(row, 6).Value = "Fecha";

                    // Formato de cabecera
                    var headerRange = worksheet.Range("A3:F3");
                    headerRange.Style.Font.Bold = true;
                    headerRange.Style.Fill.BackgroundColor = XLColor.CornflowerBlue;
                    headerRange.Style.Font.FontColor = XLColor.White;

                    // 3. Llenar datos (A partir de la fila 4)
                    int startRow = 4;
                    foreach (DataGridViewRow dgvRow in dgvVideojuegos.Rows)
                    {
                        if (dgvRow.IsNewRow) continue;

                        worksheet.Cell(row, 1).Value = dgvRow.Cells["IdVideojuego"].Value?.ToString();
                        worksheet.Cell(row, 2).Value = dgvRow.Cells["Nombre"].Value?.ToString();
                        worksheet.Cell(row, 3).Value = dgvRow.Cells["Genero"].Value?.ToString();
                        worksheet.Cell(row, 4).Value = dgvRow.Cells["Plataforma"].Value?.ToString();
                        worksheet.Cell(row, 5).Value = Convert.ToDouble(dgvRow.Cells["Puntuacion"].Value ?? 0);
                        worksheet.Cell(row, 6).Value = Convert.ToDateTime(dgvRow.Cells["Fecha"].Value ?? DateTime.Now).ToString("dd/MM/yyyy");

                        row++;
                    }

                    int endRow = row - 1;

                    // 4. Fila de Total con Fórmula de Excel (Ej. Promedio o Conteo)
                    worksheet.Cell(row, 4).Value = "Total Registros:";
                    worksheet.Cell(row, 4).Style.Font.Bold = true;

                    // Usando fórmula de Excel COUNTA o COUNT
                    worksheet.Cell(row, 5).FormulaA1 = $"COUNTA(B{startRow}:B{endRow})";
                    worksheet.Cell(row, 5).Style.Font.Bold = true;

                    worksheet.Columns().AdjustToContents();

                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Archivo Excel (*.xlsx)|*.xlsx";
                    sfd.FileName = "Reporte_Videojuegos.xlsx";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(sfd.FileName);
                        MessageBox.Show("¡Reporte exportado a Excel con éxito!", "Game Center", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar: " + ex.Message, "Game Center", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}