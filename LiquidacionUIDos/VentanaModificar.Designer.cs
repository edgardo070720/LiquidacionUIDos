﻿namespace LiquidacionUIDos
{
    partial class VentanaModificar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaModificar));
            this.label1 = new System.Windows.Forms.Label();
            this.TablaLiquidacionDtgv = new System.Windows.Forms.DataGridView();
            this.NumeroLiquidacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroLiquidacionTxt = new System.Windows.Forms.TextBox();
            this.ValorServicioLbl = new System.Windows.Forms.Label();
            this.ValorServicioTxt = new System.Windows.Forms.TextBox();
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.ModificarBtn = new System.Windows.Forms.Button();
            this.EpModificar = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablaLiquidacionDtgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpModificar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Liquidcion";
            // 
            // TablaLiquidacionDtgv
            // 
            this.TablaLiquidacionDtgv.AllowUserToAddRows = false;
            this.TablaLiquidacionDtgv.AllowUserToDeleteRows = false;
            this.TablaLiquidacionDtgv.AllowUserToOrderColumns = true;
            this.TablaLiquidacionDtgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TablaLiquidacionDtgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaLiquidacionDtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaLiquidacionDtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroLiquidacion,
            this.Cedula,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.TablaLiquidacionDtgv.Location = new System.Drawing.Point(22, 184);
            this.TablaLiquidacionDtgv.Name = "TablaLiquidacionDtgv";
            this.TablaLiquidacionDtgv.ReadOnly = true;
            this.TablaLiquidacionDtgv.Size = new System.Drawing.Size(1320, 87);
            this.TablaLiquidacionDtgv.TabIndex = 3;
            // 
            // NumeroLiquidacion
            // 
            this.NumeroLiquidacion.Frozen = true;
            this.NumeroLiquidacion.HeaderText = "Numero de Liquidacion";
            this.NumeroLiquidacion.Name = "NumeroLiquidacion";
            this.NumeroLiquidacion.ReadOnly = true;
            // 
            // Cedula
            // 
            this.Cedula.Frozen = true;
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Nombres";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Apellidos";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Tipo de Afiliacion";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 160;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Salario Devengado";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Valor del Servicio";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "Tarifa";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 55;
            // 
            // Column7
            // 
            this.Column7.Frozen = true;
            this.Column7.HeaderText = "Valor Real";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.Frozen = true;
            this.Column8.HeaderText = "Tope Maximo";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 60;
            // 
            // Column9
            // 
            this.Column9.Frozen = true;
            this.Column9.HeaderText = "Cuota Moderadora";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.Frozen = true;
            this.Column10.HeaderText = "Fecha";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 180;
            // 
            // NumeroLiquidacionTxt
            // 
            this.NumeroLiquidacionTxt.Location = new System.Drawing.Point(230, 116);
            this.NumeroLiquidacionTxt.Name = "NumeroLiquidacionTxt";
            this.NumeroLiquidacionTxt.Size = new System.Drawing.Size(158, 20);
            this.NumeroLiquidacionTxt.TabIndex = 4;
            this.NumeroLiquidacionTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeroLiquidacionTxt_KeyPress);
            this.NumeroLiquidacionTxt.Validated += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // ValorServicioLbl
            // 
            this.ValorServicioLbl.AutoSize = true;
            this.ValorServicioLbl.Location = new System.Drawing.Point(111, 150);
            this.ValorServicioLbl.Name = "ValorServicioLbl";
            this.ValorServicioLbl.Size = new System.Drawing.Size(89, 13);
            this.ValorServicioLbl.TabIndex = 5;
            this.ValorServicioLbl.Text = "Valor del Servicio";
            this.ValorServicioLbl.Visible = false;
            // 
            // ValorServicioTxt
            // 
            this.ValorServicioTxt.Location = new System.Drawing.Point(230, 147);
            this.ValorServicioTxt.Name = "ValorServicioTxt";
            this.ValorServicioTxt.Size = new System.Drawing.Size(158, 20);
            this.ValorServicioTxt.TabIndex = 6;
            this.ValorServicioTxt.Visible = false;
            this.ValorServicioTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValorServicioTxt_KeyPress);
            this.ValorServicioTxt.Validated += new System.EventHandler(this.ModificarBtn_Click);
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(429, 116);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(75, 23);
            this.BuscarBtn.TabIndex = 7;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // ModificarBtn
            // 
            this.ModificarBtn.Location = new System.Drawing.Point(429, 145);
            this.ModificarBtn.Name = "ModificarBtn";
            this.ModificarBtn.Size = new System.Drawing.Size(75, 23);
            this.ModificarBtn.TabIndex = 8;
            this.ModificarBtn.Text = "Modificar";
            this.ModificarBtn.UseVisualStyleBackColor = true;
            this.ModificarBtn.Visible = false;
            this.ModificarBtn.Click += new System.EventHandler(this.ModificarBtn_Click);
            // 
            // EpModificar
            // 
            this.EpModificar.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Modificar Liquidacion";
            // 
            // VentanaModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ModificarBtn);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.ValorServicioTxt);
            this.Controls.Add(this.ValorServicioLbl);
            this.Controls.Add(this.NumeroLiquidacionTxt);
            this.Controls.Add(this.TablaLiquidacionDtgv);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaModificar";
            this.Text = "Modificar";
            ((System.ComponentModel.ISupportInitialize)(this.TablaLiquidacionDtgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpModificar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TablaLiquidacionDtgv;
        private System.Windows.Forms.TextBox NumeroLiquidacionTxt;
        private System.Windows.Forms.Label ValorServicioLbl;
        private System.Windows.Forms.TextBox ValorServicioTxt;
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.Button ModificarBtn;
        private System.Windows.Forms.ErrorProvider EpModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroLiquidacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}