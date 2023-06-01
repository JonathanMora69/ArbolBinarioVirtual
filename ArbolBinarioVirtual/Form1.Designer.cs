namespace ArbolBinarioVirtual
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
            this.valor = new System.Windows.Forms.NumericUpDown();
            this.ingresaBoton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nombreArchivo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.valor)).BeginInit();
            this.SuspendLayout();
            // 
            // valor
            // 
            this.valor.Location = new System.Drawing.Point(59, 74);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(120, 20);
            this.valor.TabIndex = 0;
            this.valor.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ingresaBoton
            // 
            this.ingresaBoton.Location = new System.Drawing.Point(59, 112);
            this.ingresaBoton.Name = "ingresaBoton";
            this.ingresaBoton.Size = new System.Drawing.Size(75, 23);
            this.ingresaBoton.TabIndex = 1;
            this.ingresaBoton.Text = "Ingresa";
            this.ingresaBoton.UseVisualStyleBackColor = true;
            this.ingresaBoton.Click += new System.EventHandler(this.ingresaBoton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(59, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 245);
            this.panel1.TabIndex = 2;
            // 
            // nombreArchivo
            // 
            this.nombreArchivo.Location = new System.Drawing.Point(209, 73);
            this.nombreArchivo.Name = "nombreArchivo";
            this.nombreArchivo.Size = new System.Drawing.Size(114, 20);
            this.nombreArchivo.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nombreArchivo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ingresaBoton);
            this.Controls.Add(this.valor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.valor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown valor;
        private System.Windows.Forms.Button ingresaBoton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nombreArchivo;
    }
}

