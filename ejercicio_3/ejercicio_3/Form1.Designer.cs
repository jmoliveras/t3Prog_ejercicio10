namespace ejercicio_3
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMostrarCuadrados = new System.Windows.Forms.Button();
            this.btnMostrarCirculos = new System.Windows.Forms.Button();
            this.btnMostrarFiguras = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIntroducirCuadrado = new System.Windows.Forms.Button();
            this.btnIntroducirCirculo = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMostrarCuadrados);
            this.groupBox2.Controls.Add(this.btnMostrarCirculos);
            this.groupBox2.Controls.Add(this.btnMostrarFiguras);
            this.groupBox2.Location = new System.Drawing.Point(364, 26);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(281, 298);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnMostrarCuadrados
            // 
            this.btnMostrarCuadrados.Location = new System.Drawing.Point(35, 211);
            this.btnMostrarCuadrados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarCuadrados.Name = "btnMostrarCuadrados";
            this.btnMostrarCuadrados.Size = new System.Drawing.Size(212, 54);
            this.btnMostrarCuadrados.TabIndex = 6;
            this.btnMostrarCuadrados.Text = "Mostrar Cuadrados";
            this.btnMostrarCuadrados.UseVisualStyleBackColor = true;
            this.btnMostrarCuadrados.Click += new System.EventHandler(this.btnMostrarCuadrados_Click);

            // 
            // btnMostrarCirculos
            // 
            this.btnMostrarCirculos.Location = new System.Drawing.Point(35, 122);
            this.btnMostrarCirculos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarCirculos.Name = "btnMostrarCirculos";
            this.btnMostrarCirculos.Size = new System.Drawing.Size(212, 54);
            this.btnMostrarCirculos.TabIndex = 5;
            this.btnMostrarCirculos.Text = "Mostrar Círculos";
            this.btnMostrarCirculos.UseVisualStyleBackColor = true;
            this.btnMostrarCirculos.Click += new System.EventHandler(this.btnMostrarCirculos_Click);
            // 
            // btnMostrarFiguras
            // 
            this.btnMostrarFiguras.Location = new System.Drawing.Point(36, 41);
            this.btnMostrarFiguras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarFiguras.Name = "btnMostrarFiguras";
            this.btnMostrarFiguras.Size = new System.Drawing.Size(212, 54);
            this.btnMostrarFiguras.TabIndex = 4;
            this.btnMostrarFiguras.Text = "Mostrar Todas Las Figuras";
            this.btnMostrarFiguras.UseVisualStyleBackColor = true;
            this.btnMostrarFiguras.Click += new System.EventHandler(this.btnMostrarFiguras_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIntroducirCuadrado);
            this.groupBox1.Controls.Add(this.btnIntroducirCirculo);
            this.groupBox1.Location = new System.Drawing.Point(43, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(281, 298);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnIntroducirCuadrado
            // 
            this.btnIntroducirCuadrado.Location = new System.Drawing.Point(35, 189);
            this.btnIntroducirCuadrado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIntroducirCuadrado.Name = "btnIntroducirCuadrado";
            this.btnIntroducirCuadrado.Size = new System.Drawing.Size(212, 54);
            this.btnIntroducirCuadrado.TabIndex = 3;
            this.btnIntroducirCuadrado.Text = "Introducir Cuadrado";
            this.btnIntroducirCuadrado.UseVisualStyleBackColor = true;
            this.btnIntroducirCuadrado.Click += new System.EventHandler(this.btnIntroducirCuadrado_Click);

            // 
            // btnIntroducirCirculo
            // 
            this.btnIntroducirCirculo.Location = new System.Drawing.Point(35, 41);
            this.btnIntroducirCirculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIntroducirCirculo.Name = "btnIntroducirCirculo";
            this.btnIntroducirCirculo.Size = new System.Drawing.Size(212, 54);
            this.btnIntroducirCirculo.TabIndex = 2;
            this.btnIntroducirCirculo.Text = "Introducir Círculo";
            this.btnIntroducirCirculo.UseVisualStyleBackColor = true;
            this.btnIntroducirCirculo.Click += new System.EventHandler(this.btnIntroducirCirculo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMostrarCuadrados;
        private System.Windows.Forms.Button btnMostrarCirculos;
        private System.Windows.Forms.Button btnMostrarFiguras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIntroducirCuadrado;
        private System.Windows.Forms.Button btnIntroducirCirculo;
    }
}

