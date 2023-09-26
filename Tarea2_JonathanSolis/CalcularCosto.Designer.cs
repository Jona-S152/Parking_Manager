namespace Tarea2_JonathanSolis
{
    partial class CalcularCosto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCalcularTotal = new System.Windows.Forms.Button();
            this.lblCostoTotalCC = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblTotalHorasCC = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cbTipoVehiculoCC = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHSalidaCC = new System.Windows.Forms.Label();
            this.lblHEntradaCC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHEntrada = new System.Windows.Forms.Label();
            this.lblPlacaCC = new System.Windows.Forms.Label();
            this.lblInformePlaca = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.btnCalcularTotal);
            this.panel1.Controls.Add(this.lblCostoTotalCC);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.lblTotalHorasCC);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.cbTipoVehiculoCC);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblHSalidaCC);
            this.panel1.Controls.Add(this.lblHEntradaCC);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblHEntrada);
            this.panel1.Controls.Add(this.lblPlacaCC);
            this.panel1.Controls.Add(this.lblInformePlaca);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 322);
            this.panel1.TabIndex = 0;
            // 
            // btnCalcularTotal
            // 
            this.btnCalcularTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnCalcularTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcularTotal.FlatAppearance.BorderSize = 0;
            this.btnCalcularTotal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(78)))), ((int)(((byte)(82)))));
            this.btnCalcularTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularTotal.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularTotal.ForeColor = System.Drawing.Color.White;
            this.btnCalcularTotal.Location = new System.Drawing.Point(299, 257);
            this.btnCalcularTotal.Name = "btnCalcularTotal";
            this.btnCalcularTotal.Size = new System.Drawing.Size(160, 34);
            this.btnCalcularTotal.TabIndex = 52;
            this.btnCalcularTotal.Text = "Calcular costo total";
            this.btnCalcularTotal.UseVisualStyleBackColor = false;
            this.btnCalcularTotal.Click += new System.EventHandler(this.btnCalcularTotal_Click);
            // 
            // lblCostoTotalCC
            // 
            this.lblCostoTotalCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCostoTotalCC.AutoSize = true;
            this.lblCostoTotalCC.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTotalCC.ForeColor = System.Drawing.Color.White;
            this.lblCostoTotalCC.Location = new System.Drawing.Point(562, 211);
            this.lblCostoTotalCC.Name = "lblCostoTotalCC";
            this.lblCostoTotalCC.Size = new System.Drawing.Size(34, 19);
            this.lblCostoTotalCC.TabIndex = 50;
            this.lblCostoTotalCC.Text = "0,0";
            this.lblCostoTotalCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(532, 180);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(92, 19);
            this.label25.TabIndex = 49;
            this.label25.Text = "Costo total";
            // 
            // lblTotalHorasCC
            // 
            this.lblTotalHorasCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalHorasCC.AutoSize = true;
            this.lblTotalHorasCC.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHorasCC.ForeColor = System.Drawing.Color.White;
            this.lblTotalHorasCC.Location = new System.Drawing.Point(182, 211);
            this.lblTotalHorasCC.Name = "lblTotalHorasCC";
            this.lblTotalHorasCC.Size = new System.Drawing.Size(29, 19);
            this.lblTotalHorasCC.TabIndex = 48;
            this.lblTotalHorasCC.Text = "00";
            this.lblTotalHorasCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(136, 180);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(123, 19);
            this.label23.TabIndex = 47;
            this.label23.Text = "Total de horas";
            // 
            // cbTipoVehiculoCC
            // 
            this.cbTipoVehiculoCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.cbTipoVehiculoCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoVehiculoCC.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoVehiculoCC.ForeColor = System.Drawing.Color.White;
            this.cbTipoVehiculoCC.FormattingEnabled = true;
            this.cbTipoVehiculoCC.Items.AddRange(new object[] {
            "Motocicletas",
            "Livianos",
            "Medianos",
            "Pesados"});
            this.cbTipoVehiculoCC.Location = new System.Drawing.Point(557, 102);
            this.cbTipoVehiculoCC.Name = "cbTipoVehiculoCC";
            this.cbTipoVehiculoCC.Size = new System.Drawing.Size(179, 27);
            this.cbTipoVehiculoCC.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(413, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 19);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tipo de vehículo:";
            // 
            // lblHSalidaCC
            // 
            this.lblHSalidaCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHSalidaCC.AutoSize = true;
            this.lblHSalidaCC.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHSalidaCC.ForeColor = System.Drawing.Color.White;
            this.lblHSalidaCC.Location = new System.Drawing.Point(210, 133);
            this.lblHSalidaCC.Name = "lblHSalidaCC";
            this.lblHSalidaCC.Size = new System.Drawing.Size(173, 19);
            this.lblHSalidaCC.TabIndex = 44;
            this.lblHSalidaCC.Text = "00/0/0000 00:00:00";
            this.lblHSalidaCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHEntradaCC
            // 
            this.lblHEntradaCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHEntradaCC.AutoSize = true;
            this.lblHEntradaCC.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHEntradaCC.ForeColor = System.Drawing.Color.White;
            this.lblHEntradaCC.Location = new System.Drawing.Point(16, 133);
            this.lblHEntradaCC.Name = "lblHEntradaCC";
            this.lblHEntradaCC.Size = new System.Drawing.Size(173, 19);
            this.lblHEntradaCC.TabIndex = 43;
            this.lblHEntradaCC.Text = "00/0/0000 00:00:00";
            this.lblHEntradaCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(237, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 19);
            this.label5.TabIndex = 42;
            this.label5.Text = "Hora de salida";
            // 
            // lblHEntrada
            // 
            this.lblHEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHEntrada.AutoSize = true;
            this.lblHEntrada.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHEntrada.ForeColor = System.Drawing.Color.White;
            this.lblHEntrada.Location = new System.Drawing.Point(34, 104);
            this.lblHEntrada.Name = "lblHEntrada";
            this.lblHEntrada.Size = new System.Drawing.Size(136, 19);
            this.lblHEntrada.TabIndex = 41;
            this.lblHEntrada.Text = "Hora de entrada";
            // 
            // lblPlacaCC
            // 
            this.lblPlacaCC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlacaCC.AutoSize = true;
            this.lblPlacaCC.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacaCC.ForeColor = System.Drawing.Color.White;
            this.lblPlacaCC.Location = new System.Drawing.Point(196, 68);
            this.lblPlacaCC.Name = "lblPlacaCC";
            this.lblPlacaCC.Size = new System.Drawing.Size(24, 19);
            this.lblPlacaCC.TabIndex = 40;
            this.lblPlacaCC.Text = "...";
            this.lblPlacaCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInformePlaca
            // 
            this.lblInformePlaca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInformePlaca.AutoSize = true;
            this.lblInformePlaca.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformePlaca.ForeColor = System.Drawing.Color.White;
            this.lblInformePlaca.Location = new System.Drawing.Point(34, 68);
            this.lblInformePlaca.Name = "lblInformePlaca";
            this.lblInformePlaca.Size = new System.Drawing.Size(156, 19);
            this.lblInformePlaca.TabIndex = 6;
            this.lblInformePlaca.Text = "Placa del vehículo:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(294, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calcular costo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalcularCosto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(793, 322);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalcularCosto";
            this.Text = "CalcularCosto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInformePlaca;
        private System.Windows.Forms.Label lblPlacaCC;
        private System.Windows.Forms.Label lblHSalidaCC;
        private System.Windows.Forms.Label lblHEntradaCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHEntrada;
        private System.Windows.Forms.ComboBox cbTipoVehiculoCC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalHorasCC;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblCostoTotalCC;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnCalcularTotal;
    }
}