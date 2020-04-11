namespace LiquidacionUIDos
{
    partial class VentanaConsultaLiquidacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaConsultaLiquidacion));
            this.label1 = new System.Windows.Forms.Label();
            this.NumeroLiquidacionTxt = new System.Windows.Forms.TextBox();
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
            this.BuscarBtn = new System.Windows.Forms.Button();
            this.EpBuscar = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TablaLiquidacionDtgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Liquidacion";
            // 
            // NumeroLiquidacionTxt
            // 
            this.NumeroLiquidacionTxt.Location = new System.Drawing.Point(195, 77);
            this.NumeroLiquidacionTxt.Name = "NumeroLiquidacionTxt";
            this.NumeroLiquidacionTxt.Size = new System.Drawing.Size(141, 20);
            this.NumeroLiquidacionTxt.TabIndex = 1;
            this.NumeroLiquidacionTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeroLiquidacionTxt_KeyPress);
            this.NumeroLiquidacionTxt.Validated += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // TablaLiquidacionDtgv
            // 
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
            this.TablaLiquidacionDtgv.Location = new System.Drawing.Point(52, 139);
            this.TablaLiquidacionDtgv.Name = "TablaLiquidacionDtgv";
            this.TablaLiquidacionDtgv.Size = new System.Drawing.Size(1241, 87);
            this.TablaLiquidacionDtgv.TabIndex = 2;
            // 
            // NumeroLiquidacion
            // 
            this.NumeroLiquidacion.Frozen = true;
            this.NumeroLiquidacion.HeaderText = "Numero de Liquidacion";
            this.NumeroLiquidacion.Name = "NumeroLiquidacion";
            // 
            // Cedula
            // 
            this.Cedula.Frozen = true;
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Nombres";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Apellidos";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Tipo de Afiliacion";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 115;
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
            // 
            // BuscarBtn
            // 
            this.BuscarBtn.Location = new System.Drawing.Point(375, 75);
            this.BuscarBtn.Name = "BuscarBtn";
            this.BuscarBtn.Size = new System.Drawing.Size(75, 23);
            this.BuscarBtn.TabIndex = 3;
            this.BuscarBtn.Text = "Buscar";
            this.BuscarBtn.UseVisualStyleBackColor = true;
            this.BuscarBtn.Click += new System.EventHandler(this.BuscarBtn_Click);
            // 
            // EpBuscar
            // 
            this.EpBuscar.ContainerControl = this;
            // 
            // VentanaConsultaLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 450);
            this.Controls.Add(this.BuscarBtn);
            this.Controls.Add(this.TablaLiquidacionDtgv);
            this.Controls.Add(this.NumeroLiquidacionTxt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaConsultaLiquidacion";
            this.Text = "Consultar Liquidacion";
            ((System.ComponentModel.ISupportInitialize)(this.TablaLiquidacionDtgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumeroLiquidacionTxt;
        private System.Windows.Forms.DataGridView TablaLiquidacionDtgv;
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
        private System.Windows.Forms.Button BuscarBtn;
        private System.Windows.Forms.ErrorProvider EpBuscar;
    }
}