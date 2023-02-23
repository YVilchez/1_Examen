
namespace Yohanna_Examen
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_calcular = new System.Windows.Forms.Button();
            this.Mostrar_Interes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "L. 200,000.00";
            // 
            // bt_calcular
            // 
            this.bt_calcular.Location = new System.Drawing.Point(361, 78);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(119, 76);
            this.bt_calcular.TabIndex = 1;
            this.bt_calcular.Text = "CALCULAR";
            this.bt_calcular.UseVisualStyleBackColor = true;
            this.bt_calcular.Click += new System.EventHandler(this.bt_calcular_Click);
            // 
            // Mostrar_Interes
            // 
            this.Mostrar_Interes.FormattingEnabled = true;
            this.Mostrar_Interes.ItemHeight = 20;
            this.Mostrar_Interes.Location = new System.Drawing.Point(12, 170);
            this.Mostrar_Interes.Name = "Mostrar_Interes";
            this.Mostrar_Interes.Size = new System.Drawing.Size(776, 264);
            this.Mostrar_Interes.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mostrar_Interes);
            this.Controls.Add(this.bt_calcular);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_calcular;
        private System.Windows.Forms.ListBox Mostrar_Interes;
    }
}

