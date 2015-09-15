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
    public partial class frmArticulo : Form
    {
        public frmArticulo()
        {
            InitializeComponent();
        }

        //propiedad
        public string descripcionArticulo { get; set; }
        public string codigoArticulo { get; set; }
        public decimal precioArticulo { get; set; }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            ArticulosServiceReference.ArticulosClient client = new ArticulosServiceReference.ArticulosClient();
            dataGridView1.DataSource = client.ListarArticulos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cierra el formulario
            codigoArticulo = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
            descripcionArticulo = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
            precioArticulo = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["Precio"].Value.ToString());
            DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
