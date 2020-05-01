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
            this.FiltroTxt = new System.Windows.Forms.TextBox();
            this.TipoFiltroCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.TablaLiquidacionDtvg.AllowUserToResizeColumns = false;
            this.TablaLiquidacionDtvg.AllowUserToResizeRows = false;
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
            this.TablaLiquidacionDtvg.Enabled = false;
            this.TablaLiquidacionDtvg.Location = new System.Drawing.Point(22, 53);
            this.TablaLiquidacionDtvg.MultiSelect = false;
            this.TablaLiquidacionDtvg.Name = "TablaLiquidacionDtvg";
            this.TablaLiquidacionDtvg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.TablaLiquidacionDtvg.ShowEditingIcon = false;
            this.TablaLiquidacionDtvg.Size = new System.Drawing.Size(1303, 532);
            this.TablaLiquidacionDtvg.TabIndex = 1;
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
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Numero de Liquidacion";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Cedula";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Nombres ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Apellidos";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Tipo de Afiliacion";
            this.Column5.Name = "Column5";
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "Salario Devengado";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.Frozen = true;
            this.Column7.HeaderText = "Valor del servicio";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.Frozen = true;
            this.Column8.HeaderText = "Tarifa";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.Frozen = true;
            this.Column9.HeaderText = "Valor real";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.Frozen = true;
            this.Column10.HeaderText = "Tope Maximo";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.Frozen = true;
            this.Column11.HeaderText = "Cuota Moderadora";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.Frozen = true;
            this.Column12.HeaderText = "Fecha";
            this.Column12.Name = "Column12";
            this.Column12.Width = 160;
            // 
            // VentanaConsultaListaLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 627);
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
    }
}