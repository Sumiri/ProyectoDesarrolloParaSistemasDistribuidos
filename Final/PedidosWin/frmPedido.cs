using SOAPServices.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PedidosWin
{
    public partial class frmPedido : Form
    {
        public frmPedido()
        {
            InitializeComponent();
        }

        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    // You could potentially name the column based on the DGV column name (beware of dupes)
                    // or assign a type based on the data type of the data bound to this DGV column.                    
                    dt.Columns.Add();
                }
            }

            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }

            return dt;
        }
        private void frmPedido_Load(object sender, EventArgs e)
        {
            txtCantidad.Text = "0";
            //dataGridView1.AllowUserToAddRows = false;
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
                string rucCliente = oFrmCliente.rucCliente;
                
                txtCliente.Text = razonSocial;
                txtCodigoCliente.Text = codigoCliente;
                txtRUC.Text = rucCliente;
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
                txtPrecio.Text = string.Format("{0:#,##0.00}", precioArticulo);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtCodigoArticulo.Text == "")
            {
                MessageBox.Show("Debe seleccionar el Producto", "Sistema de Pedidos");
            }
            else
            {

                if (Convert.ToInt32(txtCantidad.Text) > 0)
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
                    this.button1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Debe indicar la cantidad del Producto", "Sistema de Pedidos");
                }
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (txtCodigoCliente.Text == "")
            {
                MessageBox.Show("Debe seleccionar el Cliente", "Sistema de Pedidos");
            }
            else
            {
                if (dataGridView1.Rows.Count == 1)
                {
                    MessageBox.Show("Debe agregar Productos al Pedido", "Sistema de Pedidos");
                }
                else
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

                    //DataTable dT = GetDataTableFromDGV(dataGridView1);
                    //DataSet dS = new DataSet();
                    //dS.Tables.Add(dT);
                    //dS.WriteXml(@"C:\DSD\ProyectoDSD_v3\PedidosWin\XMLFile1.xml", XmlWriteMode.WriteSchema);

                    //XmlDocument XMLDocu = new XmlDocument();
                    //XMLDocu.Load("C:\\DSD\\ProyectoDSD_v3\\PedidosWin\\XMLFile1.xml");
                    //String XMLasString = XMLDocu.OuterXml;

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
                        PedidoDetalle resultadoD = proxyD.CrearPedidoDetalle(CODCOMPANIA, CODSUCURSALCIA, ANO, NUMEROPEDIDO, NUMEROITEM, CODITEMARTICULO, UNIDADESPEDIDAS,
                            UNIDADESCOMPROMETIDAS, IMPORTEPRECIOUNITARIOSIGV, IMPORTEPRECIOUNITARIOCIGV, IMPORTESUBTOTALBRUTO, PORCENTAJEDESCUENTO, IMPORTESUBTOTALDESCUENTO,
                            IMPORTESUBTOTALNETO, CODESTADOATENCION, CODESTADOREGISTRO, CODUSUARIOCREADOR, FECCREACION, CODUSUARIOUPDATE, FECUPDATE);
                    }
                    MessageBox.Show("Pedido Registrado", "Sistema de Pedidos");
                    this.Close();

                    frmListado oFrmListado = new frmListado();
                    oFrmListado.Show();
                }
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Sistema de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index < dataGridView1.Rows.Count-1)
            {
                //Eliminamos fila
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                double total = 0;
                int rowEscribir = 0;
                //Renumeramos items
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if ((rowEscribir < dataGridView1.Rows.Count - 1))
                    {
                        dataGridView1.Rows[rowEscribir].Cells[0].Value = rowEscribir + 1;
                        total += Convert.ToDouble(row.Cells["colTotal"].Value);
                        rowEscribir++;
                    }
                }
                txtSubTotal.Text = string.Format("{0:#,##0.00}", total);
                txtIGV.Text = string.Format("{0:#,##0.00}", total * 0.18);
                txtTotal.Text = string.Format("{0:#,##0.00}", total * 1.18);
            }
            else
            {
                MessageBox.Show("Ningún registro para eliminar", "Sistema de Pedidos");
            }
        }
    }
}
