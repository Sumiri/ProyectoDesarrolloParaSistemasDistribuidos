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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        //propiedad
        public string razonSocial { get; set; }
        public string codigoCliente { get; set; }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            ClientesServiceReference.ClientesClient client = new ClientesServiceReference.ClientesClient();
            dataGridView1.DataSource = client.ListarClientes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cierra el formulario
            razonSocial = dataGridView1.CurrentRow.Cells["RazonSocial"].Value.ToString();
            codigoCliente = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
