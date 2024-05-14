namespace Calculadora
{
    partial class Form1
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblResta = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblMultiplicacion = new System.Windows.Forms.Label();
            this.txtS = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(16, 37);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(83, 16);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "NUMERO 1: ";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(16, 102);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(83, 16);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "NUMERO 2: ";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(456, 37);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(46, 16);
            this.lblSuma.TabIndex = 2;
            this.lblSuma.Text = "SUMA";
            // 
            // lblResta
            // 
            this.lblResta.AutoSize = true;
            this.lblResta.Location = new System.Drawing.Point(456, 89);
            this.lblResta.Name = "lblResta";
            this.lblResta.Size = new System.Drawing.Size(53, 16);
            this.lblResta.TabIndex = 3;
            this.lblResta.Text = "RESTA";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(456, 148);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(64, 16);
            this.lblDivision.TabIndex = 4;
            this.lblDivision.Text = "DIVISION";
            // 
            // lblMultiplicacion
            // 
            this.lblMultiplicacion.AutoSize = true;
            this.lblMultiplicacion.Location = new System.Drawing.Point(456, 203);
            this.lblMultiplicacion.Name = "lblMultiplicacion";
            this.lblMultiplicacion.Size = new System.Drawing.Size(116, 16);
            this.lblMultiplicacion.TabIndex = 5;
            this.lblMultiplicacion.Text = "MULTIPLICACION";
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(603, 31);
            this.txtS.Name = "txtS";
            this.txtS.ReadOnly = true;
            this.txtS.Size = new System.Drawing.Size(100, 22);
            this.txtS.TabIndex = 6;
            this.txtS.TextChanged += new System.EventHandler(this.txtS_TextChanged);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(603, 82);
            this.txtR.Name = "txtR";
            this.txtR.ReadOnly = true;
            this.txtR.Size = new System.Drawing.Size(100, 22);
            this.txtR.TabIndex = 7;
            this.txtR.TextChanged += new System.EventHandler(this.txtR_TextChanged);
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(603, 141);
            this.txtD.Name = "txtD";
            this.txtD.ReadOnly = true;
            this.txtD.Size = new System.Drawing.Size(100, 22);
            this.txtD.TabIndex = 8;
            this.txtD.TextChanged += new System.EventHandler(this.txtD_TextChanged);
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(603, 196);
            this.txtM.Name = "txtM";
            this.txtM.ReadOnly = true;
            this.txtM.Size = new System.Drawing.Size(100, 22);
            this.txtM.TabIndex = 9;
            this.txtM.TextChanged += new System.EventHandler(this.txtM_TextChanged);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(132, 30);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 22);
            this.txtNum1.TabIndex = 10;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(132, 95);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 22);
            this.txtNum2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.lblMultiplicacion);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.lblResta);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblResta;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblMultiplicacion;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
    }
}

