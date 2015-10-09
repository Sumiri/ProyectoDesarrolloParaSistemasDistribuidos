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
            //OBTIENE EL LISTADO DE ARTICULOS REGISTRADOS
            //A TRAVES DEL SERVICIO SOAP ARTICULOS - ListarArticulos()
            ArticulosServiceReference.ArticulosClient client = new ArticulosServiceReference.ArticulosClient();
            dataGridView1.DataSource = client.ListarArticulos();

            dataGridView1.Columns["Codigo"].DisplayIndex = 0;
            dataGridView1.Columns["Codigo"].HeaderText = "Código";
            dataGridView1.Columns["Codigo"].Width = 70;
            dataGridView1.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns["Descripcion"].DisplayIndex = 1;
            dataGridView1.Columns["Descripcion"].HeaderText = "Descripción";
            dataGridView1.Columns["Descripcion"].Width = 200;

            dataGridView1.Columns["Precio"].DisplayIndex = 2;
            dataGridView1.Columns["Precio"].HeaderText = "Precio Unitario";
            dataGridView1.Columns["Precio"].Width = 100;
            dataGridView1.Columns["Precio"].ValueType = typeof(System.Double);
            dataGridView1.Columns["Precio"].DefaultCellStyle.Format = "#,##0.00";
            dataGridView1.Columns["Precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
