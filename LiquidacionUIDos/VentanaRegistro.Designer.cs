namespace LiquidacionUIDos
{
    partial class VentanaRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaRegistro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DiaCmb = new System.Windows.Forms.ComboBox();
            this.MesCmb = new System.Windows.Forms.ComboBox();
            this.AñoCmb = new System.Windows.Forms.ComboBox();
            this.TipoAfiliacionCmb = new System.Windows.Forms.ComboBox();
            this.NumeroLiquidacionTxt = new System.Windows.Forms.TextBox();
            this.CedulaTxt = new System.Windows.Forms.TextBox();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.ApellidoTxt = new System.Windows.Forms.TextBox();
            this.SalarioDevengadoTxt = new System.Windows.Forms.TextBox();
            this.ValorServicioTxt = new System.Windows.Forms.TextBox();
            this.RegistrarBtn = new System.Windows.Forms.Button();
            this.EpRegistrar = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EpRegistrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Liquidacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salario Devengado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor del Servicio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo de Afiliacion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha";
            // 
            // DiaCmb
            // 
            this.DiaCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DiaCmb.FormattingEnabled = true;
            this.DiaCmb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.DiaCmb.Location = new System.Drawing.Point(179, 279);
            this.DiaCmb.Name = "DiaCmb";
            this.DiaCmb.Size = new System.Drawing.Size(48, 21);
            this.DiaCmb.TabIndex = 8;
            // 
            // MesCmb
            // 
            this.MesCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MesCmb.FormattingEnabled = true;
            this.MesCmb.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.MesCmb.Location = new System.Drawing.Point(233, 279);
            this.MesCmb.Name = "MesCmb";
            this.MesCmb.Size = new System.Drawing.Size(74, 21);
            this.MesCmb.TabIndex = 9;
            // 
            // AñoCmb
            // 
            this.AñoCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AñoCmb.FormattingEnabled = true;
            this.AñoCmb.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.AñoCmb.Location = new System.Drawing.Point(313, 279);
            this.AñoCmb.Name = "AñoCmb";
            this.AñoCmb.Size = new System.Drawing.Size(59, 21);
            this.AñoCmb.TabIndex = 10;
            // 
            // TipoAfiliacionCmb
            // 
            this.TipoAfiliacionCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoAfiliacionCmb.FormattingEnabled = true;
            this.TipoAfiliacionCmb.Items.AddRange(new object[] {
            "Regimen Contributivo",
            "Regimen Subsidiado"});
            this.TipoAfiliacionCmb.Location = new System.Drawing.Point(179, 241);
            this.TipoAfiliacionCmb.Name = "TipoAfiliacionCmb";
            this.TipoAfiliacionCmb.Size = new System.Drawing.Size(193, 21);
            this.TipoAfiliacionCmb.TabIndex = 11;
            // 
            // NumeroLiquidacionTxt
            // 
            this.NumeroLiquidacionTxt.Location = new System.Drawing.Point(179, 26);
            this.NumeroLiquidacionTxt.Name = "NumeroLiquidacionTxt";
            this.NumeroLiquidacionTxt.Size = new System.Drawing.Size(193, 20);
            this.NumeroLiquidacionTxt.TabIndex = 12;
            this.NumeroLiquidacionTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeroLiquidacionTxt_KeyPress);
            this.NumeroLiquidacionTxt.Validated += new System.EventHandler(this.NumeroLiquidacionTxt_Validated);
            // 
            // CedulaTxt
            // 
            this.CedulaTxt.Location = new System.Drawing.Point(179, 60);
            this.CedulaTxt.Name = "CedulaTxt";
            this.CedulaTxt.Size = new System.Drawing.Size(193, 20);
            this.CedulaTxt.TabIndex = 13;
            this.CedulaTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CedulaTxt_KeyPress);
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(179, 100);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(193, 20);
            this.NombreTxt.TabIndex = 14;
            this.NombreTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreTxt_KeyPress);
            // 
            // ApellidoTxt
            // 
            this.ApellidoTxt.Location = new System.Drawing.Point(179, 134);
            this.ApellidoTxt.Name = "ApellidoTxt";
            this.ApellidoTxt.Size = new System.Drawing.Size(193, 20);
            this.ApellidoTxt.TabIndex = 15;
            this.ApellidoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApellidoTxt_KeyPress);
            // 
            // SalarioDevengadoTxt
            // 
            this.SalarioDevengadoTxt.Location = new System.Drawing.Point(179, 174);
            this.SalarioDevengadoTxt.Name = "SalarioDevengadoTxt";
            this.SalarioDevengadoTxt.Size = new System.Drawing.Size(193, 20);
            this.SalarioDevengadoTxt.TabIndex = 16;
            this.SalarioDevengadoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalarioDevengadoTxt_KeyPress);
            // 
            // ValorServicioTxt
            // 
            this.ValorServicioTxt.Location = new System.Drawing.Point(179, 211);
            this.ValorServicioTxt.Name = "ValorServicioTxt";
            this.ValorServicioTxt.Size = new System.Drawing.Size(193, 20);
            this.ValorServicioTxt.TabIndex = 17;
            this.ValorServicioTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValorServicioTxt_KeyPress);
            // 
            // RegistrarBtn
            // 
            this.RegistrarBtn.Location = new System.Drawing.Point(533, 359);
            this.RegistrarBtn.Name = "RegistrarBtn";
            this.RegistrarBtn.Size = new System.Drawing.Size(75, 23);
            this.RegistrarBtn.TabIndex = 18;
            this.RegistrarBtn.Text = "Registrar";
            this.RegistrarBtn.UseVisualStyleBackColor = true;
            this.RegistrarBtn.Click += new System.EventHandler(this.RegistrarBtn_Click);
            this.RegistrarBtn.Validated += new System.EventHandler(this.RegistrarBtn_Click);
            // 
            // EpRegistrar
            // 
            this.EpRegistrar.ContainerControl = this;
            // 
            // VentanaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 411);
            this.Controls.Add(this.RegistrarBtn);
            this.Controls.Add(this.ValorServicioTxt);
            this.Controls.Add(this.SalarioDevengadoTxt);
            this.Controls.Add(this.ApellidoTxt);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.CedulaTxt);
            this.Controls.Add(this.NumeroLiquidacionTxt);
            this.Controls.Add(this.TipoAfiliacionCmb);
            this.Controls.Add(this.AñoCmb);
            this.Controls.Add(this.MesCmb);
            this.Controls.Add(this.DiaCmb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaRegistro";
            this.Text = " Registrar Liquidacion";
            ((System.ComponentModel.ISupportInitialize)(this.EpRegistrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox DiaCmb;
        private System.Windows.Forms.ComboBox MesCmb;
        private System.Windows.Forms.ComboBox AñoCmb;
        private System.Windows.Forms.ComboBox TipoAfiliacionCmb;
        private System.Windows.Forms.TextBox NumeroLiquidacionTxt;
        private System.Windows.Forms.TextBox CedulaTxt;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.TextBox ApellidoTxt;
        private System.Windows.Forms.TextBox SalarioDevengadoTxt;
        private System.Windows.Forms.TextBox ValorServicioTxt;
        private System.Windows.Forms.Button RegistrarBtn;
        private System.Windows.Forms.ErrorProvider EpRegistrar;
    }
}