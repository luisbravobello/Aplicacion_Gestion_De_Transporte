using System;
using System.Windows.Forms;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class vtnVentana : Form
    {
        private GestorTransporte gestor = new GestorTransporte();

        public vtnVentana()
        {
            InitializeComponent();
            cmb.Items.AddRange(new[] { "Bus", "Taxi", "Metro" });
            btnConsultar.Click += btnConsultar_Click;
            btnInsertar.Click += btnInsertar_Click;
            btnModificar.Click += btnModificar_Click;
            btnEliminar.Click += btnEliminar_Click;

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MostrarTransportes();
        }



        private void MostrarTransportes()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gestor.Listar();
        }

        private void LimpiarCampos()
        {
            txtRuta.Clear(); // Ruta
            txtCapacidad.Clear(); // Capacidad
            cmb.SelectedIndex = -1; // Tipo
            txtLugarRutaInicio.Clear(); // InicioRuta
            txtDestinoRutaFin.Clear(); // DestinoRuta
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string errores = "";
            int capacidad = 0;

            if (string.IsNullOrWhiteSpace(txtRuta.Text))
                errores += "- Ingrese una ruta.\n";

            if (string.IsNullOrWhiteSpace(txtCapacidad.Text))
                errores += "- Ingrese la capacidad (número de pasajeros).\n";
            else if (!int.TryParse(txtCapacidad.Text, out capacidad) || capacidad <= 0)
                errores += "- La capacidad debe ser un número positivo válido.\n";

            if (string.IsNullOrWhiteSpace(cmb.Text))
                errores += "- Seleccione un tipo de transporte (Bus, Taxi, Metro).\n";

            if (string.IsNullOrWhiteSpace(txtLugarRutaInicio.Text))
                errores += "- Ingrese el lugar de inicio de la ruta.\n";

            if (string.IsNullOrWhiteSpace(txtDestinoRutaFin.Text))
                errores += "- Ingrese el destino final de la ruta.\n";

            if (!string.IsNullOrEmpty(errores))
            {
                MessageBox.Show("Corrija los siguientes errores antes de continuar:\n\n" + errores,
                                "Validación de campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Desea insertar este nuevo transporte?",
                "Confirmar inserción",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion != DialogResult.Yes)
                return;

            var t = new Transporte
            {
                Ruta = txtRuta.Text,
                Capacidad = capacidad,
                Tipo = cmb.Text,
                LugarRutaInicio = txtLugarRutaInicio.Text,
                HoraRutaInicio = dtpHoraInicio.Value,
                DestinoRutaFin = txtDestinoRutaFin.Text,
                HoraDestinoFin = dtpHoraFin.Value
            };

            gestor.Insertar(t);
            MostrarTransportes();
            LimpiarCampos();

            MessageBox.Show("Transporte insertado correctamente.", "Inserción Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id;
                if (dataGridView1.CurrentRow.Cells["Id"].Value != null &&
                    int.TryParse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString(), out id))
                {
                    // Validar que el campo de capacidad no esté vacío y sea un número válido
                    string capacidadTexto = txtCapacidad.Text.Trim();
                    if (string.IsNullOrEmpty(capacidadTexto))
                    {
                        MessageBox.Show("El campo de capacidad no puede estar vacío.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int capacidad;
                    if (int.TryParse(capacidadTexto, out capacidad))
                    {
                        DialogResult confirmacion = MessageBox.Show(
                            "¿Estás seguro de que deseas modificar este transporte?",
                            "Confirmar modificación",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        if (confirmacion != DialogResult.Yes)
                        {
                            return;
                        }

                        var t = new Transporte
                        {
                            Id = id,
                            Ruta = txtRuta.Text,
                            Capacidad = capacidad,
                            Tipo = cmb.Text,
                            LugarRutaInicio = txtLugarRutaInicio.Text,
                            HoraRutaInicio = dtpHoraInicio.Value,
                            DestinoRutaFin = txtDestinoRutaFin.Text,
                            HoraDestinoFin = dtpHoraFin.Value
                        };

                        gestor.Actualizar(t);
                        MostrarTransportes();
                        LimpiarCampos();

                        MessageBox.Show("Transporte modificado correctamente.", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un número válido para la capacidad.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un Id válido.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para modificar.", "Sin Selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id;
                if (dataGridView1.CurrentRow.Cells["Id"].Value != null && int.TryParse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString(), out id))
                {
                    DialogResult confirmacion = MessageBox.Show(
                        "¿Estás seguro de que deseas eliminar este registro?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirmacion == DialogResult.Yes)
                    {
                        gestor.Eliminar(id);
                        MostrarTransportes();
                        LimpiarCampos();
                    }
                }
                else
                {
                    MessageBox.Show("Id seleccionado no válido.");
                }
            }
        }




        private void label2_Click(object sender, EventArgs e)
        {
            // Solo está enlazado al evento Click de lblCapacidad (opcional dejarlo vacío).
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblRuta_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void vtnVentana_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void txtHoraRutaInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCapacidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtRuta.Text = dataGridView1.CurrentRow.Cells["Ruta"].Value?.ToString();
                txtCapacidad.Text = dataGridView1.CurrentRow.Cells["Capacidad"].Value?.ToString();
                cmb.Text = dataGridView1.CurrentRow.Cells["Tipo"].Value?.ToString();
                txtLugarRutaInicio.Text = dataGridView1.CurrentRow.Cells["LugarRutaInicio"].Value?.ToString();
                dtpHoraInicio.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["HoraRutaInicio"].Value);
                txtDestinoRutaFin.Text = dataGridView1.CurrentRow.Cells["DestinoRutaFin"].Value?.ToString();
                dtpHoraFin.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["HoraDestinoFin"].Value);
            }
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}

