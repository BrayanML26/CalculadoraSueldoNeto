namespace CalculadoraSueldoNeto
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSueldoBrutoMensual = new System.Windows.Forms.TextBox();
            this.txtSueldoBrutoQuincenal = new System.Windows.Forms.TextBox();
            this.txtPagoSFSQuincenal = new System.Windows.Forms.TextBox();
            this.txtPagoAFPQuincenal = new System.Windows.Forms.TextBox();
            this.txtPagoISRQuincenal = new System.Windows.Forms.TextBox();
            this.txtSueldoNetoQuincenal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSueldoBrutoAnual = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sueldo Bruto Mensual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sueldo Bruto Quincenal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pago de SFS Quincenal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pago de AFP Quincenal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pago de ISR Quincenal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sueldo Neto Quincenal";
            // 
            // txtSueldoBrutoMensual
            // 
            this.txtSueldoBrutoMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoBrutoMensual.Location = new System.Drawing.Point(34, 50);
            this.txtSueldoBrutoMensual.Name = "txtSueldoBrutoMensual";
            this.txtSueldoBrutoMensual.Size = new System.Drawing.Size(182, 22);
            this.txtSueldoBrutoMensual.TabIndex = 6;
            this.txtSueldoBrutoMensual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSueldoBrutoMensual_KeyPress);
            // 
            // txtSueldoBrutoQuincenal
            // 
            this.txtSueldoBrutoQuincenal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSueldoBrutoQuincenal.Enabled = false;
            this.txtSueldoBrutoQuincenal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoBrutoQuincenal.Location = new System.Drawing.Point(231, 95);
            this.txtSueldoBrutoQuincenal.Name = "txtSueldoBrutoQuincenal";
            this.txtSueldoBrutoQuincenal.Size = new System.Drawing.Size(168, 19);
            this.txtSueldoBrutoQuincenal.TabIndex = 7;
            // 
            // txtPagoSFSQuincenal
            // 
            this.txtPagoSFSQuincenal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPagoSFSQuincenal.Enabled = false;
            this.txtPagoSFSQuincenal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagoSFSQuincenal.Location = new System.Drawing.Point(231, 137);
            this.txtPagoSFSQuincenal.Name = "txtPagoSFSQuincenal";
            this.txtPagoSFSQuincenal.Size = new System.Drawing.Size(168, 19);
            this.txtPagoSFSQuincenal.TabIndex = 8;
            // 
            // txtPagoAFPQuincenal
            // 
            this.txtPagoAFPQuincenal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPagoAFPQuincenal.Enabled = false;
            this.txtPagoAFPQuincenal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagoAFPQuincenal.Location = new System.Drawing.Point(231, 177);
            this.txtPagoAFPQuincenal.Name = "txtPagoAFPQuincenal";
            this.txtPagoAFPQuincenal.Size = new System.Drawing.Size(168, 19);
            this.txtPagoAFPQuincenal.TabIndex = 9;
            // 
            // txtPagoISRQuincenal
            // 
            this.txtPagoISRQuincenal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPagoISRQuincenal.Enabled = false;
            this.txtPagoISRQuincenal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagoISRQuincenal.Location = new System.Drawing.Point(231, 217);
            this.txtPagoISRQuincenal.Name = "txtPagoISRQuincenal";
            this.txtPagoISRQuincenal.Size = new System.Drawing.Size(168, 19);
            this.txtPagoISRQuincenal.TabIndex = 10;
            // 
            // txtSueldoNetoQuincenal
            // 
            this.txtSueldoNetoQuincenal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSueldoNetoQuincenal.Enabled = false;
            this.txtSueldoNetoQuincenal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoNetoQuincenal.Location = new System.Drawing.Point(231, 259);
            this.txtSueldoNetoQuincenal.Name = "txtSueldoNetoQuincenal";
            this.txtSueldoNetoQuincenal.Size = new System.Drawing.Size(168, 19);
            this.txtSueldoNetoQuincenal.TabIndex = 11;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCalcular.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(281, 39);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(118, 38);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(234, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sueldo Bruto Anual";
            // 
            // txtSueldoBrutoAnual
            // 
            this.txtSueldoBrutoAnual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSueldoBrutoAnual.Enabled = false;
            this.txtSueldoBrutoAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoBrutoAnual.Location = new System.Drawing.Point(238, 348);
            this.txtSueldoBrutoAnual.Name = "txtSueldoBrutoAnual";
            this.txtSueldoBrutoAnual.Size = new System.Drawing.Size(161, 19);
            this.txtSueldoBrutoAnual.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(420, 386);
            this.Controls.Add(this.txtSueldoBrutoAnual);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSueldoNetoQuincenal);
            this.Controls.Add(this.txtPagoISRQuincenal);
            this.Controls.Add(this.txtPagoAFPQuincenal);
            this.Controls.Add(this.txtPagoSFSQuincenal);
            this.Controls.Add(this.txtSueldoBrutoQuincenal);
            this.Controls.Add(this.txtSueldoBrutoMensual);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora Sueldo Neto";
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
        private System.Windows.Forms.TextBox txtSueldoBrutoMensual;
        private System.Windows.Forms.TextBox txtSueldoBrutoQuincenal;
        private System.Windows.Forms.TextBox txtPagoSFSQuincenal;
        private System.Windows.Forms.TextBox txtPagoAFPQuincenal;
        private System.Windows.Forms.TextBox txtPagoISRQuincenal;
        private System.Windows.Forms.TextBox txtSueldoNetoQuincenal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSueldoBrutoAnual;
    }
}

