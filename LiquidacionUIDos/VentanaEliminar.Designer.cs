namespace LiquidacionUIDos
{
    partial class VentanaEliminar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaEliminar));
            this.label1 = new System.Windows.Forms.Label();
            this.NumeroLiquidacionTxt = new System.Windows.Forms.TextBox();
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.ConsultarListaBtn = new System.Windows.Forms.Button();
            this.ConsultarBtn = new System.Windows.Forms.Button();
            this.EpNumeroLiquidacion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EpNumeroLiquidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Liquidacion";
            // 
            // NumeroLiquidacionTxt
            // 
            this.NumeroLiquidacionTxt.Location = new System.Drawing.Point(217, 120);
            this.NumeroLiquidacionTxt.Name = "NumeroLiquidacionTxt";
            this.NumeroLiquidacionTxt.Size = new System.Drawing.Size(288, 20);
            this.NumeroLiquidacionTxt.TabIndex = 1;
            this.NumeroLiquidacionTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumeroLiquidacionTxt_KeyPress);
            this.NumeroLiquidacionTxt.Validated += new System.EventHandler(this.NumeroLiquidacionTxt_Validated);
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.Location = new System.Drawing.Point(217, 177);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(75, 23);
            this.EliminarBtn.TabIndex = 2;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.UseVisualStyleBackColor = true;
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            this.EliminarBtn.Validated += new System.EventHandler(this.EliminarBtn_Click);
            // 
            // ConsultarListaBtn
            // 
            this.ConsultarListaBtn.Location = new System.Drawing.Point(307, 177);
            this.ConsultarListaBtn.Name = "ConsultarListaBtn";
            this.ConsultarListaBtn.Size = new System.Drawing.Size(101, 23);
            this.ConsultarListaBtn.TabIndex = 3;
            this.ConsultarListaBtn.Text = "consultar Lista";
            this.ConsultarListaBtn.UseVisualStyleBackColor = true;
            this.ConsultarListaBtn.Click += new System.EventHandler(this.ConsultarListaBtn_Click);
            // 
            // ConsultarBtn
            // 
            this.ConsultarBtn.Location = new System.Drawing.Point(430, 177);
            this.ConsultarBtn.Name = "ConsultarBtn";
            this.ConsultarBtn.Size = new System.Drawing.Size(75, 23);
            this.ConsultarBtn.TabIndex = 4;
            this.ConsultarBtn.Text = "Consultar";
            this.ConsultarBtn.UseVisualStyleBackColor = true;
            this.ConsultarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // EpNumeroLiquidacion
            // 
            this.EpNumeroLiquidacion.ContainerControl = this;
            // 
            // VentanaEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 340);
            this.Controls.Add(this.ConsultarBtn);
            this.Controls.Add(this.ConsultarListaBtn);
            this.Controls.Add(this.EliminarBtn);
            this.Controls.Add(this.NumeroLiquidacionTxt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaEliminar";
            this.Text = "Eliminar";
            ((System.ComponentModel.ISupportInitialize)(this.EpNumeroLiquidacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumeroLiquidacionTxt;
        private System.Windows.Forms.Button EliminarBtn;
        private System.Windows.Forms.Button ConsultarListaBtn;
        private System.Windows.Forms.Button ConsultarBtn;
        private System.Windows.Forms.ErrorProvider EpNumeroLiquidacion;
    }
}