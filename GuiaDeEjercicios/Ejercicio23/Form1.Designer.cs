namespace Ejercicio23
{
    partial class frmConversorDinero
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEuroAConvertir = new System.Windows.Forms.TextBox();
            this.lblEuroH = new System.Windows.Forms.Label();
            this.lblDolarH = new System.Windows.Forms.Label();
            this.lblPesosH = new System.Windows.Forms.Label();
            this.txtDolarAConvertir = new System.Windows.Forms.TextBox();
            this.txtPesosAConvertir = new System.Windows.Forms.TextBox();
            this.btnConvertirEuro = new System.Windows.Forms.Button();
            this.btnConvertirPesos = new System.Windows.Forms.Button();
            this.btnConvertirDolar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtEuroAPesos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDolarAPesos = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtPesosAPesos = new System.Windows.Forms.TextBox();
            this.txtPesosADolar = new System.Windows.Forms.TextBox();
            this.txtPesosAEuro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEuroAConvertir
            // 
            this.txtEuroAConvertir.Location = new System.Drawing.Point(79, 39);
            this.txtEuroAConvertir.Name = "txtEuroAConvertir";
            this.txtEuroAConvertir.Size = new System.Drawing.Size(100, 20);
            this.txtEuroAConvertir.TabIndex = 0;
            // 
            // lblEuroH
            // 
            this.lblEuroH.AutoSize = true;
            this.lblEuroH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuroH.Location = new System.Drawing.Point(13, 41);
            this.lblEuroH.Name = "lblEuroH";
            this.lblEuroH.Size = new System.Drawing.Size(40, 18);
            this.lblEuroH.TabIndex = 1;
            this.lblEuroH.Text = "Euro";
            // 
            // lblDolarH
            // 
            this.lblDolarH.AutoSize = true;
            this.lblDolarH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolarH.Location = new System.Drawing.Point(13, 78);
            this.lblDolarH.Name = "lblDolarH";
            this.lblDolarH.Size = new System.Drawing.Size(44, 18);
            this.lblDolarH.TabIndex = 2;
            this.lblDolarH.Text = "Dolar";
            // 
            // lblPesosH
            // 
            this.lblPesosH.AutoSize = true;
            this.lblPesosH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesosH.Location = new System.Drawing.Point(13, 115);
            this.lblPesosH.Name = "lblPesosH";
            this.lblPesosH.Size = new System.Drawing.Size(51, 18);
            this.lblPesosH.TabIndex = 3;
            this.lblPesosH.Text = "Pesos";
            // 
            // txtDolarAConvertir
            // 
            this.txtDolarAConvertir.Location = new System.Drawing.Point(79, 76);
            this.txtDolarAConvertir.Name = "txtDolarAConvertir";
            this.txtDolarAConvertir.Size = new System.Drawing.Size(100, 20);
            this.txtDolarAConvertir.TabIndex = 4;
            // 
            // txtPesosAConvertir
            // 
            this.txtPesosAConvertir.Location = new System.Drawing.Point(79, 116);
            this.txtPesosAConvertir.Name = "txtPesosAConvertir";
            this.txtPesosAConvertir.Size = new System.Drawing.Size(100, 20);
            this.txtPesosAConvertir.TabIndex = 5;
            // 
            // btnConvertirEuro
            // 
            this.btnConvertirEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirEuro.Location = new System.Drawing.Point(199, 39);
            this.btnConvertirEuro.Name = "btnConvertirEuro";
            this.btnConvertirEuro.Size = new System.Drawing.Size(75, 23);
            this.btnConvertirEuro.TabIndex = 6;
            this.btnConvertirEuro.Text = "->";
            this.btnConvertirEuro.UseVisualStyleBackColor = true;
            this.btnConvertirEuro.Click += new System.EventHandler(this.btnConvertirEuro_Click);
            // 
            // btnConvertirPesos
            // 
            this.btnConvertirPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirPesos.Location = new System.Drawing.Point(199, 116);
            this.btnConvertirPesos.Name = "btnConvertirPesos";
            this.btnConvertirPesos.Size = new System.Drawing.Size(75, 23);
            this.btnConvertirPesos.TabIndex = 7;
            this.btnConvertirPesos.Text = "->";
            this.btnConvertirPesos.UseVisualStyleBackColor = true;
            this.btnConvertirPesos.Click += new System.EventHandler(this.btnConvertirPesos_Click);
            // 
            // btnConvertirDolar
            // 
            this.btnConvertirDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirDolar.Location = new System.Drawing.Point(199, 76);
            this.btnConvertirDolar.Name = "btnConvertirDolar";
            this.btnConvertirDolar.Size = new System.Drawing.Size(75, 23);
            this.btnConvertirDolar.TabIndex = 8;
            this.btnConvertirDolar.Text = "->";
            this.btnConvertirDolar.UseVisualStyleBackColor = true;
            this.btnConvertirDolar.Click += new System.EventHandler(this.btnConvertirDolar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Euro";
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Location = new System.Drawing.Point(289, 39);
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.Size = new System.Drawing.Size(100, 20);
            this.txtEuroAEuro.TabIndex = 10;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Location = new System.Drawing.Point(406, 39);
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.Size = new System.Drawing.Size(100, 20);
            this.txtEuroADolar.TabIndex = 11;
            // 
            // txtEuroAPesos
            // 
            this.txtEuroAPesos.Location = new System.Drawing.Point(521, 39);
            this.txtEuroAPesos.Name = "txtEuroAPesos";
            this.txtEuroAPesos.Size = new System.Drawing.Size(100, 20);
            this.txtEuroAPesos.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(430, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Dolar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(540, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pesos";
            // 
            // txtDolarAPesos
            // 
            this.txtDolarAPesos.Location = new System.Drawing.Point(521, 76);
            this.txtDolarAPesos.Name = "txtDolarAPesos";
            this.txtDolarAPesos.Size = new System.Drawing.Size(100, 20);
            this.txtDolarAPesos.TabIndex = 17;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Location = new System.Drawing.Point(406, 76);
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolarADolar.TabIndex = 16;
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Location = new System.Drawing.Point(289, 76);
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.Size = new System.Drawing.Size(100, 20);
            this.txtDolarAEuro.TabIndex = 15;
            // 
            // txtPesosAPesos
            // 
            this.txtPesosAPesos.Location = new System.Drawing.Point(521, 115);
            this.txtPesosAPesos.Name = "txtPesosAPesos";
            this.txtPesosAPesos.Size = new System.Drawing.Size(100, 20);
            this.txtPesosAPesos.TabIndex = 20;
            // 
            // txtPesosADolar
            // 
            this.txtPesosADolar.Location = new System.Drawing.Point(406, 115);
            this.txtPesosADolar.Name = "txtPesosADolar";
            this.txtPesosADolar.Size = new System.Drawing.Size(100, 20);
            this.txtPesosADolar.TabIndex = 19;
            // 
            // txtPesosAEuro
            // 
            this.txtPesosAEuro.Location = new System.Drawing.Point(289, 115);
            this.txtPesosAEuro.Name = "txtPesosAEuro";
            this.txtPesosAEuro.Size = new System.Drawing.Size(100, 20);
            this.txtPesosAEuro.TabIndex = 18;
            // 
            // frmConversorDinero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 171);
            this.Controls.Add(this.txtPesosAPesos);
            this.Controls.Add(this.txtPesosADolar);
            this.Controls.Add(this.txtPesosAEuro);
            this.Controls.Add(this.txtDolarAPesos);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEuroAPesos);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvertirDolar);
            this.Controls.Add(this.btnConvertirPesos);
            this.Controls.Add(this.btnConvertirEuro);
            this.Controls.Add(this.txtPesosAConvertir);
            this.Controls.Add(this.txtDolarAConvertir);
            this.Controls.Add(this.lblPesosH);
            this.Controls.Add(this.lblDolarH);
            this.Controls.Add(this.lblEuroH);
            this.Controls.Add(this.txtEuroAConvertir);
            this.Name = "frmConversorDinero";
            this.Text = "Conversor Dinero";
            this.Load += new System.EventHandler(this.frmConversorDinero_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEuroAConvertir;
        private System.Windows.Forms.Label lblEuroH;
        private System.Windows.Forms.Label lblDolarH;
        private System.Windows.Forms.Label lblPesosH;
        private System.Windows.Forms.TextBox txtDolarAConvertir;
        private System.Windows.Forms.TextBox txtPesosAConvertir;
        private System.Windows.Forms.Button btnConvertirEuro;
        private System.Windows.Forms.Button btnConvertirPesos;
        private System.Windows.Forms.Button btnConvertirDolar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEuroAEuro;
        private System.Windows.Forms.TextBox txtEuroADolar;
        private System.Windows.Forms.TextBox txtEuroAPesos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDolarAPesos;
        private System.Windows.Forms.TextBox txtDolarADolar;
        private System.Windows.Forms.TextBox txtDolarAEuro;
        private System.Windows.Forms.TextBox txtPesosAPesos;
        private System.Windows.Forms.TextBox txtPesosADolar;
        private System.Windows.Forms.TextBox txtPesosAEuro;
    }
}

