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
        public string rucCliente { get; set; }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            //OBTIENE EL LISTADO DE CLIENTES REGISTRADOS
            //A TRAVES DEL SERVICIO SOAP CLIENTES - ListarClientes()
            ClientesServiceReference.ClientesClient client = new ClientesServiceReference.ClientesClient();
            dataGridView1.DataSource = client.ListarClientes(); 

            dataGridView1.Columns[0].Visible = false;

            dataGridView1.Columns["RUC"].DisplayIndex = 1;
            dataGridView1.Columns["RUC"].HeaderText = "Número RUC";
            dataGridView1.Columns["RUC"].Width = 100;
            dataGridView1.Columns["RUC"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["RazonSocial"].DisplayIndex = 0;
            dataGridView1.Columns["RazonSocial"].HeaderText = "Razón Social";
            dataGridView1.Columns["RazonSocial"].Width = 200;

            dataGridView1.Columns["Correo"].DisplayIndex = 2;
            dataGridView1.Columns["Correo"].HeaderText = "Correo Electrónico";
            dataGridView1.Columns["Correo"].Width = 200;

            dataGridView1.Rows[0].Selected = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cierra el formulario
            razonSocial = dataGridView1.CurrentRow.Cells["RazonSocial"].Value.ToString();
            codigoCliente = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
            rucCliente = dataGridView1.CurrentRow.Cells["RUC"].Value.ToString();
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
