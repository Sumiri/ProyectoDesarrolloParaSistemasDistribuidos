using SOAPServices.Dominio;
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
            txtCantidad.Text = "0";
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
            //MostraFormularioCliente();
            frmCliente oFrmCliente = new frmCliente();
            if (oFrmCliente.ShowDialog() == DialogResult.OK)
            {
                string razonSocial = oFrmCliente.razonSocial;
                string codigoCliente = oFrmCliente.codigoCliente;
                
                txtCliente.Text = razonSocial;
                txtCodigoCliente.Text = codigoCliente;
            }
        }

        private void btnArticulo_Click(object sender, EventArgs e)
        {
            // Llamo al formulario de artículos
            //MostraFormularioArticulo();
            frmArticulo oFrmArticulo = new frmArticulo();
            if (oFrmArticulo.ShowDialog() == DialogResult.OK)
            {
                string codigoArticulo = oFrmArticulo.codigoArticulo;
                string descripcionArticulo = oFrmArticulo.descripcionArticulo;
                decimal precioArticulo = oFrmArticulo.precioArticulo;

                txtCodigoArticulo.Text = codigoArticulo;
                txtProducto.Text = descripcionArticulo;
                txtPrecio.Text = precioArticulo.ToString();    
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowEscribir = dataGridView1.Rows.Count - 1;

            dataGridView1.Rows.Add(1);

            dataGridView1.Rows[rowEscribir].Cells[0].Value = rowEscribir + 1;
            dataGridView1.Rows[rowEscribir].Cells[1].Value = txtCodigoArticulo.Text;
            dataGridView1.Rows[rowEscribir].Cells[2].Value = txtProducto.Text;
            dataGridView1.Rows[rowEscribir].Cells[3].Value = Convert.ToDouble(txtPrecio.Text);
            dataGridView1.Rows[rowEscribir].Cells[4].Value = txtCantidad.Text;
            dataGridView1.Rows[rowEscribir].Cells[5].Value = Convert.ToDouble(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Text);

            double total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToDouble(row.Cells["colTotal"].Value);
            }
            txtSubTotal.Text = string.Format("{0:#,##0.00}", total);
            txtIGV.Text = string.Format("{0:#,##0.00}", total * 0.18);
            txtTotal.Text = string.Format("{0:#,##0.00}", total * 1.18);
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            //variables para completar cabecera
            int CODCOMPANIA = 1;
            int CODSUCURSALCIA = 1;
            int ANO = 2015;
            DateTime FECPEDIDO = Convert.ToDateTime(this.dateTimePicker1.Value);
            int CODCLIENTE = Convert.ToInt32(txtCodigoCliente.Text);
            int CODSUCURSAL = 1;
            string CODUSUARIOVENDEDOR = "VENDEDOR";
            int CODDOCUMENTOFACTURACION = 1;
            string NUMEROORDENCOMPRA = "A001";
            int CODMONEDA = 1;
            double IMPORTETOTALBRUTO = Convert.ToDouble(txtSubTotal.Text);
            double IMPORTETOTALDESCUENTO = 0.00;
            double PORCENTAJEIGV = 18.00;
            double IMPORTETOTALIGV = Convert.ToDouble(txtIGV.Text);
            double IMPORTETOTALNETO = Convert.ToDouble(txtTotal.Text);
            int CODESTADOATENCION = 1;
            int CODALMACEN = 1;
            int CODESTADOREGISTRO = 1;
            string CODUSUARIOCREADOR = "CREADOR";
            DateTime FECCREACION = Convert.ToDateTime(this.dateTimePicker1.Value);
            string CODUSUARIOUPDATE = "ACTUALIZADOR";
            DateTime FECUPDATE = Convert.ToDateTime(this.dateTimePicker1.Value);

            PedidosWS.PedidosClient proxyP = new PedidosWS.PedidosClient();
            Pedido resultadoP = proxyP.CrearPedido(CODCOMPANIA, CODSUCURSALCIA, ANO, FECPEDIDO, CODCLIENTE, CODSUCURSAL, CODUSUARIOVENDEDOR, CODDOCUMENTOFACTURACION, 
                NUMEROORDENCOMPRA, CODMONEDA, IMPORTETOTALBRUTO, IMPORTETOTALDESCUENTO, PORCENTAJEIGV, IMPORTETOTALIGV, IMPORTETOTALNETO, CODESTADOATENCION, CODALMACEN,
                CODESTADOREGISTRO, CODUSUARIOCREADOR, FECCREACION, CODUSUARIOUPDATE, FECUPDATE);

            int NUMEROPEDIDO = resultadoP.NumeroPedido;
            //variables para completar detalle
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int NUMEROITEM = Convert.ToInt32(row.Cells["colItem"].Value);

                if (NUMEROITEM == 0)
                {
                    break;
                }

                int CODITEMARTICULO = Convert.ToInt32(row.Cells["colCodigo"].Value);
                int UNIDADESPEDIDAS = Convert.ToInt32(row.Cells["colCantidad"].Value);
                int UNIDADESCOMPROMETIDAS = Convert.ToInt32(row.Cells["colCantidad"].Value);
                double IMPORTEPRECIOUNITARIOSIGV = Convert.ToDouble(row.Cells["colPrecio"].Value);
                double IMPORTEPRECIOUNITARIOCIGV = Convert.ToDouble(row.Cells["colPrecio"].Value) * 1.18;
                double IMPORTESUBTOTALBRUTO = Convert.ToDouble(row.Cells["colTotal"].Value);
                double PORCENTAJEDESCUENTO = 0.00;
                double IMPORTESUBTOTALDESCUENTO = 0.00;
                double IMPORTESUBTOTALNETO = Convert.ToDouble(row.Cells["colTotal"].Value);

                PedidoDetallesWS.PedidoDetallesClient proxyD = new PedidoDetallesWS.PedidoDetallesClient();
                PedidoDetalle resultadoD = proxyD.CrearPedidoDetalle(CODCOMPANIA, CODSUCURSALCIA, ANO,NUMEROPEDIDO,NUMEROITEM,CODITEMARTICULO,UNIDADESPEDIDAS,
                    UNIDADESCOMPROMETIDAS,IMPORTEPRECIOUNITARIOSIGV,IMPORTEPRECIOUNITARIOCIGV,IMPORTESUBTOTALBRUTO,PORCENTAJEDESCUENTO,IMPORTESUBTOTALDESCUENTO,
                    IMPORTESUBTOTALNETO, CODESTADOATENCION, CODESTADOREGISTRO, CODUSUARIOCREADOR, FECCREACION, CODUSUARIOUPDATE, FECUPDATE);
            }
            MessageBox.Show("Pedido Registrado");
            this.Close();
        }     
    }
}
