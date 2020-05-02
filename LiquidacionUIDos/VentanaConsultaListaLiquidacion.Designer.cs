using System;
using System.Windows.Forms;

namespace LiquidacionUIDos
{
    partial class VentanaConsultaListaLiquidacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaConsultaListaLiquidacion));
            this.label1 = new System.Windows.Forms.Label();
            this.TablaLiquidacionDtvg = new System.Windows.Forms.DataGridView();
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
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiltroTxt = new System.Windows.Forms.TextBox();
            this.TipoFiltroCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TipoDeFiltroDosCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CantidadTxt = new System.Windows.Forms.TextBox();
            this.TotalCuotaTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TablaLiquidacionDtvg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Registros";
            // 
            // TablaLiquidacionDtvg
            // 
            this.TablaLiquidacionDtvg.AllowUserToAddRows = false;
            this.TablaLiquidacionDtvg.AllowUserToDeleteRows = false;
            this.TablaLiquidacionDtvg.AllowUserToOrderColumns = true;
            this.TablaLiquidacionDtvg.AllowUserToResizeColumns = false;
            this.TablaLiquidacionDtvg.AllowUserToResizeRows = false;
            this.TablaLiquidacionDtvg.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TablaLiquidacionDtvg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaLiquidacionDtvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaLiquidacionDtvg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.TablaLiquidacionDtvg.Location = new System.Drawing.Point(22, 53);
            this.TablaLiquidacionDtvg.MultiSelect = false;
            this.TablaLiquidacionDtvg.Name = "TablaLiquidacionDtvg";
            this.TablaLiquidacionDtvg.ReadOnly = true;
            this.TablaLiquidacionDtvg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.TablaLiquidacionDtvg.ShowEditingIcon = false;
            this.TablaLiquidacionDtvg.Size = new System.Drawing.Size(1319, 532);
            this.TablaLiquidacionDtvg.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Numero de Liquidacion";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Cedula";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Nombres ";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Apellidos";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Tipo de Afiliacion";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 160;
            // 
            // Column6
            // 
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "Salario Devengado";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.Frozen = true;
            this.Column7.HeaderText = "Valor del servicio";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.Frozen = true;
            this.Column8.HeaderText = "Tarifa";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 55;
            // 
            // Column9
            // 
            this.Column9.Frozen = true;
            this.Column9.HeaderText = "Valor real";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.Frozen = true;
            this.Column10.HeaderText = "Tope Maximo";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 60;
            // 
            // Column11
            // 
            this.Column11.Frozen = true;
            this.Column11.HeaderText = "Cuota Moderadora";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.Frozen = true;
            this.Column12.HeaderText = "Fecha";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 180;
            // 
            // FiltroTxt
            // 
            this.FiltroTxt.Location = new System.Drawing.Point(497, 19);
            this.FiltroTxt.Name = "FiltroTxt";
            this.FiltroTxt.Size = new System.Drawing.Size(196, 20);
            this.FiltroTxt.TabIndex = 2;
            this.FiltroTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FiltroTxt_KeyPress);
            // 
            // TipoFiltroCmb
            // 
            this.TipoFiltroCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoFiltroCmb.FormattingEnabled = true;
            this.TipoFiltroCmb.Items.AddRange(new object[] {
            "Numero de Liquidacion",
            "Cedula",
            "Nombres",
            "Apellidos",
            "Tipo de Afiliacion",
            "Fecha"});
            this.TipoFiltroCmb.Location = new System.Drawing.Point(302, 19);
            this.TipoFiltroCmb.Name = "TipoFiltroCmb";
            this.TipoFiltroCmb.Size = new System.Drawing.Size(165, 21);
            this.TipoFiltroCmb.TabIndex = 3;
            this.TipoFiltroCmb.SelectedIndexChanged += new System.EventHandler(this.TipoFiltroCmb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filtrar Por:";
            // 
            // TipoDeFiltroDosCmb
            // 
            this.TipoDeFiltroDosCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoDeFiltroDosCmb.FormattingEnabled = true;
            this.TipoDeFiltroDosCmb.Items.AddRange(new object[] {
            "Total Liquidaciones",
            "Total Regimen Contributivo",
            "Total Regimen Subsidiado"});
            this.TipoDeFiltroDosCmb.Location = new System.Drawing.Point(783, 18);
            this.TipoDeFiltroDosCmb.Name = "TipoDeFiltroDosCmb";
            this.TipoDeFiltroDosCmb.Size = new System.Drawing.Size(155, 21);
            this.TipoDeFiltroDosCmb.TabIndex = 5;
            this.TipoDeFiltroDosCmb.SelectedIndexChanged += new System.EventHandler(this.TipoDeFiltroDosCmb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(944, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cantidad: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1057, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Cuota:";
            // 
            // CantidadTxt
            // 
            this.CantidadTxt.Enabled = false;
            this.CantidadTxt.Location = new System.Drawing.Point(1005, 19);
            this.CantidadTxt.Name = "CantidadTxt";
            this.CantidadTxt.Size = new System.Drawing.Size(36, 20);
            this.CantidadTxt.TabIndex = 8;
            // 
            // TotalCuotaTxt
            // 
            this.TotalCuotaTxt.Enabled = false;
            this.TotalCuotaTxt.Location = new System.Drawing.Point(1128, 19);
            this.TotalCuotaTxt.Name = "TotalCuotaTxt";
            this.TotalCuotaTxt.Size = new System.Drawing.Size(111, 20);
            this.TotalCuotaTxt.TabIndex = 9;
            // 
            // VentanaConsultaListaLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 642);
            this.Controls.Add(this.TotalCuotaTxt);
            this.Controls.Add(this.CantidadTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TipoDeFiltroDosCmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TipoFiltroCmb);
            this.Controls.Add(this.FiltroTxt);
            this.Controls.Add(this.TablaLiquidacionDtvg);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaConsultaListaLiquidacion";
            this.Text = "Lista de Liquidacion";
            ((System.ComponentModel.ISupportInitialize)(this.TablaLiquidacionDtvg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TablaLiquidacionDtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private TextBox FiltroTxt;
        private ComboBox TipoFiltroCmb;
        private Label label2;
        private DataGridView TablaLiquidacionDtvg;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private ComboBox TipoDeFiltroDosCmb;
        private Label label3;
        private Label label4;
        private TextBox CantidadTxt;
        private TextBox TotalCuotaTxt;
    }
}