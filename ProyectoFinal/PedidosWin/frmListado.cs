using RESTServices.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Messaging;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Xml;

namespace PedidosWin
{
    public partial class frmListado : Form
    {
        public frmListado()
        {
            InitializeComponent();
        }

        private void frmListado_Load(object sender, EventArgs e)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string htmlResponse = client.DownloadString("http://localhost:23440/PedidosREST.svc/ListarPedidos");

                    DataSet set = new DataSet();
                    byte[] buffer = Encoding.UTF8.GetBytes(htmlResponse);
                    using (MemoryStream stream = new MemoryStream(buffer))
                    {
                        XmlReader reader = XmlReader.Create(stream);
                        set.ReadXml(reader);
                    }

                    dataGridView1.DataSource = set;
                    dataGridView1.DataMember = "Pedido";

                    dataGridView1.Columns["Numero"].DisplayIndex = 0;
                    dataGridView1.Columns["Numero"].HeaderText = "Número Pedido";
                    dataGridView1.Columns["Numero"].Width = 50;
                    dataGridView1.Columns["Numero"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dataGridView1.Columns["Fecha"].DisplayIndex = 1;
                    dataGridView1.Columns["Fecha"].HeaderText = "Fecha y Hora";
                    dataGridView1.Columns["Fecha"].Width = 150;
                    dataGridView1.Columns["Fecha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dataGridView1.Columns["Cliente"].DisplayIndex = 2;
                    dataGridView1.Columns["Cliente"].HeaderText = "Razón Social";
                    dataGridView1.Columns["Cliente"].Width = 200;

                    dataGridView1.Columns["Direccion"].DisplayIndex = 3;
                    dataGridView1.Columns["Direccion"].HeaderText = "Dirección";
                    dataGridView1.Columns["Direccion"].Width = 150;

                    dataGridView1.Columns["Moneda"].DisplayIndex = 4;
                    dataGridView1.Columns["Moneda"].HeaderText = "Moneda";
                    dataGridView1.Columns["Moneda"].Width = 50;
                    dataGridView1.Columns["Moneda"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dataGridView1.Columns["Importe"].DisplayIndex = 5;
                    dataGridView1.Columns["Importe"].HeaderText = "Importe a Cobrar";
                    dataGridView1.Columns["Importe"].Width = 100;
                    dataGridView1.Columns["Importe"].ValueType = typeof(System.Double);
                    dataGridView1.Columns["Importe"].DefaultCellStyle.Format = "#,0.##";
                    dataGridView1.Columns["Importe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    dataGridView1.Columns["Anho"].Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("No Hay Pedidos pendientes");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String numero = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            String cliente = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            String fecha = "01/10/2016";
            String importe = dataGridView1.CurrentRow.Cells[5].Value.ToString();


            string postdata = "{\"bumero\":\"" + numero + "\",\"Fecha\":\"" + fecha + "\",\"Cliente\":\"" + cliente + "\",\"ImporteBruto\":\"" + importe + "\",\"ImporteVenta\":\"" + importe + "\",\"ImporteIGV\":\"" + importe + "\",\"ImporteTotalVenta\":\"" + importe + "\"}";
            //MessageBox.Show(postdata, "Sistema de Pedidos");
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(postdata);
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:23440/Facturas.svc/Facturas");
                req.Method = "POST";
                req.ContentLength = data.Length;
                req.ContentType = "application/json";
                var reqStream = req.GetRequestStream();
                reqStream.Write(data, 0, data.Length);
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string compraJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                RESTServices.Dominio.Factura mensaje = js.Deserialize<RESTServices.Dominio.Factura>(compraJson);
                MessageBox.Show("Pedido Facturado satisfactoriamente ", "Sistema de Pedidos");
            }
            catch
            {

                string rutaCola = @".\private$\facturas";
                if (!MessageQueue.Exists(rutaCola))
                    MessageQueue.Create(rutaCola);
                MessageQueue cola = new MessageQueue(rutaCola);
                System.Messaging.Message mensaje = new System.Messaging.Message();
                mensaje.Label = "Factura " + numero;
                mensaje.Body = new Factura() { Numero = numero, Cliente = cliente, Fecha = fecha, ImporteBruto = importe, ImporteIGV = importe, ImporteVenta = importe, ImporteTotalVenta = importe };
                cola.Send(mensaje);
                MessageBox.Show("Factura enviada por MSMQ", "Error");
            }



        }
    }
}
