using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidosWin
{
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {

        }

        private void MostraFormularioCliente()
        {
            frmCliente oFrmCliente= new frmCliente();
            oFrmCliente.Show();
        }

        private void MostraFormularioArticulo()
        {
            frmArticulo oFrmArticulo = new frmArticulo();
            oFrmArticulo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Llamo al formulario de clientes
            MostraFormularioCliente();
        }

        private void btnArticulo_Click(object sender, EventArgs e)
        {
            // Llamo al formulario de artículos
            MostraFormularioArticulo();
        }

    }
}
