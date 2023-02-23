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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double[] Interes_men = new double[12];
        string[] Mes = {"Enero             ",
                        "Febrero          ",
                        "Marzo            ",
                        "Abril               ",
                        "Mayo             ",
                        "Junio             ",
                        "Julio               ",
                        "Agosto           ",
                        "Septiembre    ",
                        "Octubre         ",
                        "Noviembre     ",
                        "Diciembre      "};

        double InteresAcum = 0;

        //============================================================================
        private void bt_calcular_Click(object sender, EventArgs e)
        {
            //LLAMAR FUNSION Calculos
            Calculos();

        }

        //==============================================================================
        private void Calculos ()
        {
            for(int i=0; i< Interes_men.Length; i++)
            {
                Interes_men[i] =(200000 * 0.015 * 12) / 12;
                InteresAcum = InteresAcum + (200000 * 0.015 * 12);
                Mostrar_Interes.Items.Add("Mes: " + Mes[i] + "Su Interes Mensual es: " + Interes_men[i] + 
                                       "             Su Interes Acumulado es: " + InteresAcum);
                Mostrar_Interes.Items.Add("_______________________________________________________________________________________________" );
            }
        }
    }
}
