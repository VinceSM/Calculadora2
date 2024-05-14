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
            this.lblNum1.Location = new System.Drawing.Point(12, 30);
            this.lblNum1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(70, 13);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "NUMERO 1: ";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(12, 83);
            this.lblNum2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(70, 13);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "NUMERO 2: ";
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(342, 30);
            this.lblSuma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(38, 13);
            this.lblSuma.TabIndex = 2;
            this.lblSuma.Text = "SUMA";
            // 
            // lblResta
            // 
            this.lblResta.AutoSize = true;
            this.lblResta.Location = new System.Drawing.Point(342, 72);
            this.lblResta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResta.Name = "lblResta";
            this.lblResta.Size = new System.Drawing.Size(43, 13);
            this.lblResta.TabIndex = 3;
            this.lblResta.Text = "RESTA";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(342, 120);
            this.lblDivision.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(54, 13);
            this.lblDivision.TabIndex = 4;
            this.lblDivision.Text = "DIVISION";
            // 
            // lblMultiplicacion
            // 
            this.lblMultiplicacion.AutoSize = true;
            this.lblMultiplicacion.Location = new System.Drawing.Point(342, 165);
            this.lblMultiplicacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMultiplicacion.Name = "lblMultiplicacion";
            this.lblMultiplicacion.Size = new System.Drawing.Size(96, 13);
            this.lblMultiplicacion.TabIndex = 5;
            this.lblMultiplicacion.Text = "MULTIPLICACION";
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(452, 25);
            this.txtS.Margin = new System.Windows.Forms.Padding(2);
            this.txtS.Name = "txtS";
            this.txtS.ReadOnly = true;
            this.txtS.Size = new System.Drawing.Size(122, 20);
            this.txtS.TabIndex = 6;
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(452, 67);
            this.txtR.Margin = new System.Windows.Forms.Padding(2);
            this.txtR.Name = "txtR";
            this.txtR.ReadOnly = true;
            this.txtR.Size = new System.Drawing.Size(122, 20);
            this.txtR.TabIndex = 7;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(452, 115);
            this.txtD.Margin = new System.Windows.Forms.Padding(2);
            this.txtD.Name = "txtD";
            this.txtD.ReadOnly = true;
            this.txtD.Size = new System.Drawing.Size(122, 20);
            this.txtD.TabIndex = 8;
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(452, 159);
            this.txtM.Margin = new System.Windows.Forms.Padding(2);
            this.txtM.Name = "txtM";
            this.txtM.ReadOnly = true;
            this.txtM.Size = new System.Drawing.Size(122, 20);
            this.txtM.TabIndex = 9;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(99, 24);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(2);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(76, 20);
            this.txtNum1.TabIndex = 10;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(99, 77);
            this.txtNum2.Margin = new System.Windows.Forms.Padding(2);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(76, 20);
            this.txtNum2.TabIndex = 11;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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

