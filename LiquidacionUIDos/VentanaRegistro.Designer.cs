﻿namespace LiquidacionUIDos
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
            this.TipoAfiliacionCmb = new System.Windows.Forms.ComboBox();
            this.NumeroLiquidacionTxt = new System.Windows.Forms.TextBox();
            this.CedulaTxt = new System.Windows.Forms.TextBox();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.ApellidoTxt = new System.Windows.Forms.TextBox();
            this.SalarioDevengadoTxt = new System.Windows.Forms.TextBox();
            this.ValorServicioTxt = new System.Windows.Forms.TextBox();
            this.RegistrarBtn = new System.Windows.Forms.Button();
            this.EpRegistrar = new System.Windows.Forms.ErrorProvider(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.FechaLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EpRegistrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Liquidacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salario Devengado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor del Servicio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo de Afiliacion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fecha:";
            // 
            // TipoAfiliacionCmb
            // 
            this.TipoAfiliacionCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoAfiliacionCmb.FormattingEnabled = true;
            this.TipoAfiliacionCmb.Items.AddRange(new object[] {
            "Regimen Contributivo",
            "Regimen Subsidiado"});
            this.TipoAfiliacionCmb.Location = new System.Drawing.Point(218, 288);
            this.TipoAfiliacionCmb.Name = "TipoAfiliacionCmb";
            this.TipoAfiliacionCmb.Size = new System.Drawing.Size(193, 21);
            this.TipoAfiliacionCmb.TabIndex = 11;
            // 
            // NumeroLiquidacionTxt
            // 
            this.NumeroLiquidacionTxt.Location = new System.Drawing.Point(218, 73);
            this.NumeroLiquidacionTxt.Name = "NumeroLiquidacionTxt";
            this.NumeroLiquidacionTxt.Size = new System.Drawing.Size(193, 20);
            this.NumeroLiquidacionTxt.TabIndex = 12;
            this.NumeroLiquidacionTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeroLiquidacionTxt_KeyPress);
            // 
            // CedulaTxt
            // 
            this.CedulaTxt.Location = new System.Drawing.Point(218, 107);
            this.CedulaTxt.Name = "CedulaTxt";
            this.CedulaTxt.Size = new System.Drawing.Size(193, 20);
            this.CedulaTxt.TabIndex = 13;
            this.CedulaTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CedulaTxt_KeyPress);
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(218, 147);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(193, 20);
            this.NombreTxt.TabIndex = 14;
            this.NombreTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreTxt_KeyPress);
            // 
            // ApellidoTxt
            // 
            this.ApellidoTxt.Location = new System.Drawing.Point(218, 181);
            this.ApellidoTxt.Name = "ApellidoTxt";
            this.ApellidoTxt.Size = new System.Drawing.Size(193, 20);
            this.ApellidoTxt.TabIndex = 15;
            this.ApellidoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApellidoTxt_KeyPress);
            // 
            // SalarioDevengadoTxt
            // 
            this.SalarioDevengadoTxt.Location = new System.Drawing.Point(218, 221);
            this.SalarioDevengadoTxt.Name = "SalarioDevengadoTxt";
            this.SalarioDevengadoTxt.Size = new System.Drawing.Size(193, 20);
            this.SalarioDevengadoTxt.TabIndex = 16;
            this.SalarioDevengadoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalarioDevengadoTxt_KeyPress);
            // 
            // ValorServicioTxt
            // 
            this.ValorServicioTxt.Location = new System.Drawing.Point(218, 258);
            this.ValorServicioTxt.Name = "ValorServicioTxt";
            this.ValorServicioTxt.Size = new System.Drawing.Size(193, 20);
            this.ValorServicioTxt.TabIndex = 17;
            this.ValorServicioTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValorServicioTxt_KeyPress);
            // 
            // RegistrarBtn
            // 
            this.RegistrarBtn.Location = new System.Drawing.Point(336, 379);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(299, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Registrar Liquidacioon";
            // 
            // FechaLbl
            // 
            this.FechaLbl.AutoSize = true;
            this.FechaLbl.Location = new System.Drawing.Point(221, 329);
            this.FechaLbl.Name = "FechaLbl";
            this.FechaLbl.Size = new System.Drawing.Size(0, 13);
            this.FechaLbl.TabIndex = 21;
            // 
            // VentanaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 411);
            this.Controls.Add(this.FechaLbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RegistrarBtn);
            this.Controls.Add(this.ValorServicioTxt);
            this.Controls.Add(this.SalarioDevengadoTxt);
            this.Controls.Add(this.ApellidoTxt);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.CedulaTxt);
            this.Controls.Add(this.NumeroLiquidacionTxt);
            this.Controls.Add(this.TipoAfiliacionCmb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.ComboBox TipoAfiliacionCmb;
        private System.Windows.Forms.TextBox NumeroLiquidacionTxt;
        private System.Windows.Forms.TextBox CedulaTxt;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.TextBox ApellidoTxt;
        private System.Windows.Forms.TextBox SalarioDevengadoTxt;
        private System.Windows.Forms.TextBox ValorServicioTxt;
        private System.Windows.Forms.Button RegistrarBtn;
        private System.Windows.Forms.ErrorProvider EpRegistrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label FechaLbl;
    }
}