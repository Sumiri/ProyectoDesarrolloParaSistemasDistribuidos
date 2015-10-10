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

namespace PedidosWin
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void registroDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedido oFrPedido = new frmPedido();
            oFrPedido.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListado oFrmListado = new frmListado();
            oFrmListado.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void estadísticasDePedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticas ofrmEstadisticas = new frmEstadisticas();
            ofrmEstadisticas.Show();
        }

<<<<<<< HEAD
        private void recuperarFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaCola = @".\private$\facturas";
                if (!MessageQueue.Exists(rutaCola))
                    MessageQueue.Create(rutaCola);
                MessageQueue cola = new MessageQueue(rutaCola);
                cola.Formatter = new XmlMessageFormatter(new Type[] { typeof(Factura) });
                int total = cola.GetAllMessages().Count();
                while (cola.GetAllMessages().Count() != 0)
                {
                    System.Messaging.Message mensaje = cola.Receive();
                    Factura facturaItem = (Factura)mensaje.Body;
                    string postdata = "{\"Numero\":\"" + facturaItem.Numero + "\",\"Fecha\":\"" + facturaItem.Fecha + "\",\"Cliente\":\"" + facturaItem.Cliente + "\",\"ImporteBruto\":\"" + facturaItem.ImporteBruto + "\",\"ImporteVenta\":\"" + facturaItem.ImporteVenta + "\",\"ImporteIGV\":\"" + facturaItem.ImporteIGV + "\",\"ImporteTotalVenta\":\"" + facturaItem.ImporteTotalVenta + "\"}";
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

                }
                MessageBox.Show(total + " facturas recuperadas", "Facturas Recuperadas");
            }
            catch {
                MessageBox.Show("Error de comunicación", "Error");
            }
        }

=======
        private void consolidadoDeComisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmComisiones ofrmComisiones = new frmComisiones();
            ofrmComisiones.Show();
        }
>>>>>>> 52e56b45aa6904acc3df60d316ef42fd33968554
    }
}