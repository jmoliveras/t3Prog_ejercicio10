namespace ejercicio_3
{
    partial class frmIntroducirCuadrado
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPosicionY = new System.Windows.Forms.TextBox();
            this.txtPosicionX = new System.Windows.Forms.TextBox();
            this.btnAgregarCuadrado = new System.Windows.Forms.Button();
            this.lblLado = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPosicionY = new System.Windows.Forms.Label();
            this.lblPosicionX = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLado);
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.txtPosicionY);
            this.groupBox1.Controls.Add(this.txtPosicionX);
            this.groupBox1.Controls.Add(this.btnAgregarCuadrado);
            this.groupBox1.Controls.Add(this.lblLado);
            this.groupBox1.Controls.Add(this.lblColor);
            this.groupBox1.Controls.Add(this.lblPosicionY);
            this.groupBox1.Controls.Add(this.lblPosicionX);
            this.groupBox1.Location = new System.Drawing.Point(73, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 418);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Introduzca Los Datos Del Cuadrado";
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(160, 249);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(161, 26);
            this.txtLado.TabIndex = 8;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(160, 195);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(161, 26);
            this.txtColor.TabIndex = 7;
            // 
            // txtPosicionY
            // 
            this.txtPosicionY.Location = new System.Drawing.Point(160, 139);
            this.txtPosicionY.Name = "txtPosicionY";
            this.txtPosicionY.Size = new System.Drawing.Size(161, 26);
            this.txtPosicionY.TabIndex = 6;
            // 
            // txtPosicionX
            // 
            this.txtPosicionX.Location = new System.Drawing.Point(160, 79);
            this.txtPosicionX.Name = "txtPosicionX";
            this.txtPosicionX.Size = new System.Drawing.Size(161, 26);
            this.txtPosicionX.TabIndex = 5;
            // 
            // btnAgregarCuadrado
            // 
            this.btnAgregarCuadrado.Location = new System.Drawing.Point(81, 338);
            this.btnAgregarCuadrado.Name = "btnAgregarCuadrado";
            this.btnAgregarCuadrado.Size = new System.Drawing.Size(308, 50);
            this.btnAgregarCuadrado.TabIndex = 4;
            this.btnAgregarCuadrado.Text = "Añadir Cuadrado";
            this.btnAgregarCuadrado.UseVisualStyleBackColor = true;
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(91, 249);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(74, 30);
            this.lblLado.TabIndex = 3;
            this.lblLado.Text = "Lado:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(91, 191);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(50, 20);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color:";
            // 
            // lblPosicionY
            // 
            this.lblPosicionY.AutoSize = true;
            this.lblPosicionY.Location = new System.Drawing.Point(53, 139);
            this.lblPosicionY.Name = "lblPosicionY";
            this.lblPosicionY.Size = new System.Drawing.Size(87, 20);
            this.lblPosicionY.TabIndex = 1;
            this.lblPosicionY.Text = "Posición Y:";
            // 
            // lblPosicionX
            // 
            this.lblPosicionX.AutoSize = true;
            this.lblPosicionX.Location = new System.Drawing.Point(53, 82);
            this.lblPosicionX.Name = "lblPosicionX";
            this.lblPosicionX.Size = new System.Drawing.Size(87, 20);
            this.lblPosicionX.TabIndex = 0;
            this.lblPosicionX.Text = "Posición X:";
            // 
            // fIntroducirCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "fIntroducirCuadrado";
            this.Text = "fIntroducirCuadrado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPosicionY;
        private System.Windows.Forms.TextBox txtPosicionX;
        private System.Windows.Forms.Button btnAgregarCuadrado;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblPosicionY;
        private System.Windows.Forms.Label lblPosicionX;
    }
}