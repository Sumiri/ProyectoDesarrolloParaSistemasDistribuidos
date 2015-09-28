using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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

            using (WebClient client = new WebClient())
            {
                string htmlResponse = client.DownloadString("http://localhost:23440/PedidosREST.svc/ListarPedidos");
                


                DataSet dataSet1 = new DataSet();

                dataSet1.ReadXml("c:\\dsd\\dsd.xml");
                dataGridView1.DataSource = dataSet1;
                dataGridView1.DataMember = "Pedido";

                //dataGridView1.DataSource = XDocument.Parse(htmlResponse);
                //dataGridView1.DataMember = ("Pedido");

                //MessageBox.Show(htmlResponse);

                //foreach (DataGridViewRow row in dataGridView1.Rows)
                //{
                //    int rowEscribir = dataGridView1.Rows.Count - 1;
                //    dataGridView1.Rows.Add(1);

                //    dataGridView1.Rows[rowEscribir].Cells[0].Value = rowEscribir + 1;
                //    dataGridView1.Rows[rowEscribir].Cells[1].Value = "prueba";

                //}

                

            textBox1.Text = htmlResponse;
            }

            
            //"http://localhost:23440/PedidosREST.svc/ListarPedidos";

            
        }
    }
}
