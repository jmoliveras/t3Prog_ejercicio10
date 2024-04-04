namespace ejercicio_3
{
    partial class frmIntroducirCirculo
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
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPosicionY = new System.Windows.Forms.TextBox();
            this.txtPosicionX = new System.Windows.Forms.TextBox();
            this.btnAgregarCirculo = new System.Windows.Forms.Button();
            this.lblRadio = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPosicionY = new System.Windows.Forms.Label();
            this.lblPosicionX = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRadio);
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.txtPosicionY);
            this.groupBox1.Controls.Add(this.txtPosicionX);
            this.groupBox1.Controls.Add(this.btnAgregarCirculo);
            this.groupBox1.Controls.Add(this.lblRadio);
            this.groupBox1.Controls.Add(this.lblColor);
            this.groupBox1.Controls.Add(this.lblPosicionY);
            this.groupBox1.Controls.Add(this.lblPosicionX);
            this.groupBox1.Location = new System.Drawing.Point(74, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 418);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Introduzca Los Datos Del Círculo";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(160, 249);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(161, 26);
            this.txtRadio.TabIndex = 8;
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
            // btnAgregarCirculo
            // 
            this.btnAgregarCirculo.Location = new System.Drawing.Point(81, 338);
            this.btnAgregarCirculo.Name = "btnAgregarCirculo";
            this.btnAgregarCirculo.Size = new System.Drawing.Size(308, 50);
            this.btnAgregarCirculo.TabIndex = 4;
            this.btnAgregarCirculo.Text = "Añadir Círculo";
            this.btnAgregarCirculo.UseVisualStyleBackColor = true;
            this.btnAgregarCirculo.Click += new System.EventHandler(this.btnAgregarCirculo_Click);
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(91, 249);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(55, 20);
            this.lblRadio.TabIndex = 3;
            this.lblRadio.Text = "Radio:";
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
            this.lblPosicionX.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmIntroducirCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 503);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmIntroducirCirculo";
            this.Text = "fIntroducirCirculo";
            this.Load += new System.EventHandler(this.fIntroducirCirculo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPosicionX;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblPosicionY;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPosicionY;
        private System.Windows.Forms.TextBox txtPosicionX;
        private System.Windows.Forms.Button btnAgregarCirculo;
    }
}