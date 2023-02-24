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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private async void bt_calcular_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(tb_cantidad.Text);
            int precio = Convert.ToInt32(tb_precio.Text);

            tb_sub.Text = (" " + await SubTotalAsync(cantidad, precio));
            tb_des.Text = (" " + await DescuentoAsync(cantidad, precio));
            tb_total.Text = (" " + await TotalPagarAsync(cantidad, precio));
        }
        //=================================================================
        public int SubTotal(int cantidad, int precio)
        {
            return cantidad * precio;
        }

        public async Task<int> SubTotalAsync(int cantidad, int precio)
        {
            var SubTotal = await Task.Run(() => {
                return cantidad * precio;
            });
            return SubTotal;
        }
        //==================================================================
        public double Descuento(int cantidad, int precio)
        {
            return (cantidad * precio) * 0.15;
        }
       
        public async Task<double> DescuentoAsync(int cantidad, int precio)
        {
            var Descuento = await Task.Run(() => {
                return (cantidad * precio) * 0.15;
            });
            return Descuento;
        }

        //===================================================================
        public double TotalPagar(int cantidad, int precio)
        {
            return ((cantidad * precio) - (cantidad * precio) * 0.15);
        }
        public async Task<double> TotalPagarAsync(int cantidad, int precio)
        {
            var TotalPagar = await Task.Run(() => {
                return ((cantidad * precio) - (cantidad * precio) * 0.15);
            });
            return TotalPagar;
        }
        //===================================================================
        public void Limpiar()
        {
            tb_sub.Text = " ";
            tb_des.Text = " ";
            tb_total.Text = " ";
            tb_producto.Text = " ";
            tb_precio.Text = " ";
            tb_cantidad.Text = " ";
        }

        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
