﻿
namespace Capa_Vista_Produccion
{
    partial class Frm_Cierre
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_saldo_anterior = new System.Windows.Forms.Label();
            this.lbl_cargos_mes = new System.Windows.Forms.Label();
            this.lbl_abonos_mes = new System.Windows.Forms.Label();
            this.lbl_saldo_actual = new System.Windows.Forms.Label();
            this.lbl_cargos_acumulados = new System.Windows.Forms.Label();
            this.lbl_abonos_acumulados = new System.Windows.Forms.Label();
            this.txt_saldo_anterior = new System.Windows.Forms.TextBox();
            this.txt_cargos_mes = new System.Windows.Forms.TextBox();
            this.txt_abonos_mes = new System.Windows.Forms.TextBox();
            this.txt_saldo_actual = new System.Windows.Forms.TextBox();
            this.txt_cargos_acumulados = new System.Windows.Forms.TextBox();
            this.txt_abonos_acumulados = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.dgv_historico_cierres = new System.Windows.Forms.DataGridView();
            this.dtp_fecha_cierre = new System.Windows.Forms.DateTimePicker();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.lbl_Fecha_Cierre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historico_cierres)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cierre Producción";
            // 
            // lbl_saldo_anterior
            // 
            this.lbl_saldo_anterior.AutoSize = true;
            this.lbl_saldo_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saldo_anterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.lbl_saldo_anterior.Location = new System.Drawing.Point(217, 221);
            this.lbl_saldo_anterior.Name = "lbl_saldo_anterior";
            this.lbl_saldo_anterior.Size = new System.Drawing.Size(115, 18);
            this.lbl_saldo_anterior.TabIndex = 1;
            this.lbl_saldo_anterior.Text = "Saldo Anterior";
            this.lbl_saldo_anterior.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_cargos_mes
            // 
            this.lbl_cargos_mes.AutoSize = true;
            this.lbl_cargos_mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargos_mes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.lbl_cargos_mes.Location = new System.Drawing.Point(28, 138);
            this.lbl_cargos_mes.Name = "lbl_cargos_mes";
            this.lbl_cargos_mes.Size = new System.Drawing.Size(91, 18);
            this.lbl_cargos_mes.TabIndex = 2;
            this.lbl_cargos_mes.Text = "Cargo Mes";
            // 
            // lbl_abonos_mes
            // 
            this.lbl_abonos_mes.AutoSize = true;
            this.lbl_abonos_mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_abonos_mes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.lbl_abonos_mes.Location = new System.Drawing.Point(26, 159);
            this.lbl_abonos_mes.Name = "lbl_abonos_mes";
            this.lbl_abonos_mes.Size = new System.Drawing.Size(93, 18);
            this.lbl_abonos_mes.TabIndex = 3;
            this.lbl_abonos_mes.Text = "Abono Mes";
            // 
            // lbl_saldo_actual
            // 
            this.lbl_saldo_actual.AutoSize = true;
            this.lbl_saldo_actual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saldo_actual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.lbl_saldo_actual.Location = new System.Drawing.Point(342, 221);
            this.lbl_saldo_actual.Name = "lbl_saldo_actual";
            this.lbl_saldo_actual.Size = new System.Drawing.Size(102, 18);
            this.lbl_saldo_actual.TabIndex = 4;
            this.lbl_saldo_actual.Text = "Saldo Actual";
            this.lbl_saldo_actual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_cargos_acumulados
            // 
            this.lbl_cargos_acumulados.AutoSize = true;
            this.lbl_cargos_acumulados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargos_acumulados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.lbl_cargos_acumulados.Location = new System.Drawing.Point(471, 206);
            this.lbl_cargos_acumulados.Name = "lbl_cargos_acumulados";
            this.lbl_cargos_acumulados.Size = new System.Drawing.Size(99, 36);
            this.lbl_cargos_acumulados.TabIndex = 5;
            this.lbl_cargos_acumulados.Text = "Cargos \r\nacumulados";
            this.lbl_cargos_acumulados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_abonos_acumulados
            // 
            this.lbl_abonos_acumulados.AutoSize = true;
            this.lbl_abonos_acumulados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_abonos_acumulados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.lbl_abonos_acumulados.Location = new System.Drawing.Point(602, 206);
            this.lbl_abonos_acumulados.Name = "lbl_abonos_acumulados";
            this.lbl_abonos_acumulados.Size = new System.Drawing.Size(99, 36);
            this.lbl_abonos_acumulados.TabIndex = 6;
            this.lbl_abonos_acumulados.Text = "Abonos \r\nacumulados";
            this.lbl_abonos_acumulados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_saldo_anterior
            // 
            this.txt_saldo_anterior.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_saldo_anterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txt_saldo_anterior.Location = new System.Drawing.Point(220, 254);
            this.txt_saldo_anterior.Name = "txt_saldo_anterior";
            this.txt_saldo_anterior.ReadOnly = true;
            this.txt_saldo_anterior.Size = new System.Drawing.Size(100, 22);
            this.txt_saldo_anterior.TabIndex = 10;
            this.txt_saldo_anterior.TabStop = false;
            // 
            // txt_cargos_mes
            // 
            this.txt_cargos_mes.BackColor = System.Drawing.Color.White;
            this.txt_cargos_mes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cargos_mes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(49)))), ((int)(((byte)(108)))));
            this.txt_cargos_mes.Location = new System.Drawing.Point(210, 140);
            this.txt_cargos_mes.Name = "txt_cargos_mes";
            this.txt_cargos_mes.Size = new System.Drawing.Size(100, 15);
            this.txt_cargos_mes.TabIndex = 2;
            // 
            // txt_abonos_mes
            // 
            this.txt_abonos_mes.BackColor = System.Drawing.Color.White;
            this.txt_abonos_mes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_abonos_mes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(49)))), ((int)(((byte)(108)))));
            this.txt_abonos_mes.Location = new System.Drawing.Point(210, 161);
            this.txt_abonos_mes.Name = "txt_abonos_mes";
            this.txt_abonos_mes.Size = new System.Drawing.Size(100, 15);
            this.txt_abonos_mes.TabIndex = 3;
            // 
            // txt_saldo_actual
            // 
            this.txt_saldo_actual.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_saldo_actual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txt_saldo_actual.Location = new System.Drawing.Point(344, 254);
            this.txt_saldo_actual.Name = "txt_saldo_actual";
            this.txt_saldo_actual.ReadOnly = true;
            this.txt_saldo_actual.Size = new System.Drawing.Size(100, 22);
            this.txt_saldo_actual.TabIndex = 10;
            this.txt_saldo_actual.TabStop = false;
            // 
            // txt_cargos_acumulados
            // 
            this.txt_cargos_acumulados.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_cargos_acumulados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txt_cargos_acumulados.Location = new System.Drawing.Point(470, 254);
            this.txt_cargos_acumulados.Name = "txt_cargos_acumulados";
            this.txt_cargos_acumulados.ReadOnly = true;
            this.txt_cargos_acumulados.Size = new System.Drawing.Size(100, 22);
            this.txt_cargos_acumulados.TabIndex = 11;
            this.txt_cargos_acumulados.TabStop = false;
            // 
            // txt_abonos_acumulados
            // 
            this.txt_abonos_acumulados.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_abonos_acumulados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.txt_abonos_acumulados.Location = new System.Drawing.Point(601, 254);
            this.txt_abonos_acumulados.Name = "txt_abonos_acumulados";
            this.txt_abonos_acumulados.ReadOnly = true;
            this.txt_abonos_acumulados.Size = new System.Drawing.Size(100, 22);
            this.txt_abonos_acumulados.TabIndex = 12;
            this.txt_abonos_acumulados.TabStop = false;
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_calcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_calcular.FlatAppearance.BorderSize = 0;
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.btn_calcular.Location = new System.Drawing.Point(358, 85);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(86, 33);
            this.btn_calcular.TabIndex = 5;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.btn_guardar.Location = new System.Drawing.Point(447, 84);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(98, 34);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.btn_limpiar.Location = new System.Drawing.Point(551, 85);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(88, 34);
            this.btn_limpiar.TabIndex = 7;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.btn_cerrar.Location = new System.Drawing.Point(773, 12);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(92, 34);
            this.btn_cerrar.TabIndex = 8;
            this.btn_cerrar.Text = "Salir";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // dgv_historico_cierres
            // 
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgv_historico_cierres.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_historico_cierres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_historico_cierres.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_historico_cierres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_historico_cierres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_historico_cierres.Location = new System.Drawing.Point(23, 282);
            this.dgv_historico_cierres.Name = "dgv_historico_cierres";
            this.dgv_historico_cierres.RowHeadersWidth = 51;
            this.dgv_historico_cierres.RowTemplate.Height = 24;
            this.dgv_historico_cierres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_historico_cierres.Size = new System.Drawing.Size(842, 445);
            this.dgv_historico_cierres.TabIndex = 9;
            // 
            // dtp_fecha_cierre
            // 
            this.dtp_fecha_cierre.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.dtp_fecha_cierre.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.dtp_fecha_cierre.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(105)))), ((int)(((byte)(180)))));
            this.dtp_fecha_cierre.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtp_fecha_cierre.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dtp_fecha_cierre.Location = new System.Drawing.Point(110, 182);
            this.dtp_fecha_cierre.Name = "dtp_fecha_cierre";
            this.dtp_fecha_cierre.Size = new System.Drawing.Size(200, 22);
            this.dtp_fecha_cierre.TabIndex = 4;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(183)))), ((int)(((byte)(235)))));
            this.btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Nuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_Nuevo.FlatAppearance.BorderSize = 0;
            this.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.btn_Nuevo.Location = new System.Drawing.Point(274, 85);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(78, 32);
            this.btn_Nuevo.TabIndex = 1;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click_1);
            // 
            // lbl_Fecha_Cierre
            // 
            this.lbl_Fecha_Cierre.AutoSize = true;
            this.lbl_Fecha_Cierre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha_Cierre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.lbl_Fecha_Cierre.Location = new System.Drawing.Point(28, 182);
            this.lbl_Fecha_Cierre.Name = "lbl_Fecha_Cierre";
            this.lbl_Fecha_Cierre.Size = new System.Drawing.Size(54, 18);
            this.lbl_Fecha_Cierre.TabIndex = 19;
            this.lbl_Fecha_Cierre.Text = "Fecha";
            // 
            // Frm_Cierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(207)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(881, 740);
            this.Controls.Add(this.lbl_Fecha_Cierre);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.dtp_fecha_cierre);
            this.Controls.Add(this.dgv_historico_cierres);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_abonos_acumulados);
            this.Controls.Add(this.txt_cargos_acumulados);
            this.Controls.Add(this.txt_saldo_actual);
            this.Controls.Add(this.txt_abonos_mes);
            this.Controls.Add(this.txt_cargos_mes);
            this.Controls.Add(this.txt_saldo_anterior);
            this.Controls.Add(this.lbl_abonos_acumulados);
            this.Controls.Add(this.lbl_cargos_acumulados);
            this.Controls.Add(this.lbl_saldo_actual);
            this.Controls.Add(this.lbl_abonos_mes);
            this.Controls.Add(this.lbl_cargos_mes);
            this.Controls.Add(this.lbl_saldo_anterior);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Cierre";
            this.Text = "Frm_Cierre";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_historico_cierres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_saldo_anterior;
        private System.Windows.Forms.Label lbl_cargos_mes;
        private System.Windows.Forms.Label lbl_abonos_mes;
        private System.Windows.Forms.Label lbl_saldo_actual;
        private System.Windows.Forms.Label lbl_cargos_acumulados;
        private System.Windows.Forms.Label lbl_abonos_acumulados;
        private System.Windows.Forms.TextBox txt_saldo_anterior;
        private System.Windows.Forms.TextBox txt_cargos_mes;
        private System.Windows.Forms.TextBox txt_abonos_mes;
        private System.Windows.Forms.TextBox txt_saldo_actual;
        private System.Windows.Forms.TextBox txt_cargos_acumulados;
        private System.Windows.Forms.TextBox txt_abonos_acumulados;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.DataGridView dgv_historico_cierres;
        private System.Windows.Forms.DateTimePicker dtp_fecha_cierre;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Label lbl_Fecha_Cierre;
    }
}