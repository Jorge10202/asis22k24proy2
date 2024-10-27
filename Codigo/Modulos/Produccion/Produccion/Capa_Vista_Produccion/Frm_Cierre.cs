﻿using System;
using System.Data;
using System.Windows.Forms;

namespace Capa_Vista_Produccion
{
    public partial class Frm_Cierre : Form
    {
        private Capa_Controlador_Produccion.Control_Cierre controlCierre = new Capa_Controlador_Produccion.Control_Cierre();

        public Frm_Cierre()
        {
            InitializeComponent();
            CargarHistorialCierres(); // Cargar el historial de cierres al abrir el formulario
        }

        // Método para cargar el historial de cierres en el DataGridView
        private void CargarHistorialCierres()
        {
            try
            {
                dgv_historico_cierres.DataSource = controlCierre.ObtenerHistorialCierres();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el historial de cierres: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento para el botón Nuevo
        private void btn_Nuevo_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Obtener el saldo anterior más reciente y mostrarlo en txt_saldo_anterior
                decimal saldoAnterior = controlCierre.ObtenerDatosCierre(dtp_fecha_cierre.Value).saldoAnterior;
                txt_saldo_anterior.Text = saldoAnterior.ToString("F2");

                // Limpiar los campos para nuevos datos
                txt_cargos_mes.Clear();
                txt_abonos_mes.Clear();
                txt_saldo_actual.Clear();
                txt_cargos_acumulados.Clear();
                txt_abonos_acumulados.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al preparar nuevo registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            // Verificar que el usuario haya ingresado datos en los campos necesarios
            try
            {
                if (string.IsNullOrWhiteSpace(txt_saldo_anterior.Text) ||
                    string.IsNullOrWhiteSpace(txt_cargos_mes.Text) ||
                    string.IsNullOrWhiteSpace(txt_abonos_mes.Text))
                {
                    MessageBox.Show("Por favor, ingrese todos los datos necesarios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Calcular el saldo actual
                decimal saldoAnterior = decimal.Parse(txt_saldo_anterior.Text);
                decimal cargosMes = decimal.Parse(txt_cargos_mes.Text);
                decimal abonosMes = decimal.Parse(txt_abonos_mes.Text);

                decimal saldoActual = controlCierre.CalcularSaldoActual(saldoAnterior, cargosMes, abonosMes);
                txt_saldo_actual.Text = saldoActual.ToString("F2");

                // Calcular los cargos y abonos acumulados del año contable seleccionado, incluyendo el mes actual
                int year = dtp_fecha_cierre.Value.Year;
                decimal cargosAcumulados = controlCierre.ObtenerCargosAcumuladosAnuales(year, cargosMes);
                decimal abonosAcumulados = controlCierre.ObtenerAbonosAcumuladosAnuales(year, abonosMes);

                // Mostrar los valores actualizados de acumulados en los TextBoxes
                txt_cargos_acumulados.Text = cargosAcumulados.ToString("F2");
                txt_abonos_acumulados.Text = abonosAcumulados.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores válidos en todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular los valores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_saldo_actual.Text) ||
                    string.IsNullOrWhiteSpace(txt_cargos_acumulados.Text) ||
                    string.IsNullOrWhiteSpace(txt_abonos_acumulados.Text) ||
                    string.IsNullOrWhiteSpace(txt_saldo_anterior.Text) ||
                    string.IsNullOrWhiteSpace(txt_cargos_mes.Text) ||
                    string.IsNullOrWhiteSpace(txt_abonos_mes.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal saldoAnterior = decimal.Parse(txt_saldo_anterior.Text);
                decimal cargosMes = decimal.Parse(txt_cargos_mes.Text);
                decimal abonosMes = decimal.Parse(txt_abonos_mes.Text);
                decimal saldoActual = decimal.Parse(txt_saldo_actual.Text);
                decimal cargosAcumulados = decimal.Parse(txt_cargos_acumulados.Text);
                decimal abonosAcumulados = decimal.Parse(txt_abonos_acumulados.Text);
                DateTime fecha = dtp_fecha_cierre.Value;

                bool resultado = controlCierre.GuardarCierre(saldoAnterior, cargosMes, abonosMes, saldoActual, cargosAcumulados, abonosAcumulados, fecha);

                if (resultado)
                {
                    MessageBox.Show("Cierre guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarHistorialCierres(); // Recargar el historial de cierres
                    LimpiarCampos(); // Limpiar campos después de guardar exitosamente
                }
                else
                {
                    MessageBox.Show("Error al guardar el cierre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores válidos en todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Método para limpiar todos los campos de entrada
        private void LimpiarCampos()
        {
            txt_saldo_anterior.Clear();
            txt_cargos_mes.Clear();
            txt_abonos_mes.Clear();
            txt_saldo_actual.Clear();
            txt_cargos_acumulados.Clear();
            txt_abonos_acumulados.Clear();
        }

        // Evento para mostrar detalles del cierre seleccionado en el DataGridView
        private void dgv_historico_cierres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgv_historico_cierres.Rows[e.RowIndex];

                txt_saldo_anterior.Text = filaSeleccionada.Cells["saldo_anterior"].Value.ToString();
                txt_cargos_mes.Text = filaSeleccionada.Cells["cargos_mes"].Value.ToString();
                txt_abonos_mes.Text = filaSeleccionada.Cells["abonos_mes"].Value.ToString();
                txt_saldo_actual.Text = filaSeleccionada.Cells["saldo_actual"].Value.ToString();
            }
        }
    }
}
