using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yohanna_Examen
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_nombre_Load(object sender, EventArgs e)
        {

        }

        private void bt_mostrar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }
        //=============================================================
        private void Mostrar()
        {
            string Nombre = tb_nombre.Text;
            string Apellido = tb_apellido.Text;

            for (int i = 1; i <= 100; i++)
            {


                if (i % 3 == 0 && i % 5 == 0)
                {
                    Lista_Numeros.Items.Add(i + "  " + Nombre + " " + Apellido);
                }
                else
                {
                    if (i % 5 == 0)
                    {
                        Lista_Numeros.Items.Add(i + "  " + Apellido);
                    }
                    else
                    {
                        if (i % 3 == 0)
                        {
                            Lista_Numeros.Items.Add(i + "  " + Nombre);
                        }
                    }
                }
                if (i % 3 != 0 && i % 5 != 0 && (i % 3 != 0))
                {
                    Lista_Numeros.Items.Add(i + "  ");
                }
            }
        }
    }
}


