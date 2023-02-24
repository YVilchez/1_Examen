
namespace Yohanna_Examen
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_apellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Lista_Numeros = new System.Windows.Forms.ListBox();
            this.bt_mostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMERACION 1 / 100";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(99, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(464, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "*****************************************";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese su 1 nombre:";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(264, 113);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(183, 26);
            this.tb_nombre.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ingrese su 1 Apellido:";
            // 
            // tb_apellido
            // 
            this.tb_apellido.Location = new System.Drawing.Point(264, 161);
            this.tb_apellido.Name = "tb_apellido";
            this.tb_apellido.Size = new System.Drawing.Size(183, 26);
            this.tb_apellido.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(353, 275);
            this.label5.TabIndex = 6;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(639, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "______________________________________________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 547);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 8;
            // 
            // Lista_Numeros
            // 
            this.Lista_Numeros.FormattingEnabled = true;
            this.Lista_Numeros.ItemHeight = 20;
            this.Lista_Numeros.Location = new System.Drawing.Point(420, 254);
            this.Lista_Numeros.Name = "Lista_Numeros";
            this.Lista_Numeros.Size = new System.Drawing.Size(230, 284);
            this.Lista_Numeros.TabIndex = 9;
            // 
            // bt_mostrar
            // 
            this.bt_mostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_mostrar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.bt_mostrar.Location = new System.Drawing.Point(508, 133);
            this.bt_mostrar.Name = "bt_mostrar";
            this.bt_mostrar.Size = new System.Drawing.Size(122, 32);
            this.bt_mostrar.TabIndex = 10;
            this.bt_mostrar.Text = "MOSTRAR";
            this.bt_mostrar.UseVisualStyleBackColor = true;
            this.bt_mostrar.Click += new System.EventHandler(this.bt_mostrar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 592);
            this.Controls.Add(this.bt_mostrar);
            this.Controls.Add(this.Lista_Numeros);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_apellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.tb_nombre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_apellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox Lista_Numeros;
        private System.Windows.Forms.Button bt_mostrar;
    }
}