using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PedidosWin
{
    public partial class frmEstadisticas : Form
    {
        public frmEstadisticas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
              using (WebClient client = new WebClient())
            {
                try
                {

                    string htmlResponse = client.DownloadString("http://localhost:23440/PedidosREST.svc/ListarPedidos2/" + this.textBox1.Text);
              
                DataSet set = new DataSet();
                byte[] buffer = Encoding.UTF8.GetBytes(htmlResponse);
                using (MemoryStream stream = new MemoryStream(buffer))
                {
                    XmlReader reader = XmlReader.Create(stream);
                    set.ReadXml(reader);
                }
               
                dataGridView1.DataSource = set;
                dataGridView1.DataMember = "Pedido";

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
                dataGridView1.Columns["Direccion"].Visible =false;


            }


                catch (Exception)
                {

                    MessageBox.Show("No se encontró fecha indicada");




                }
            }
        }
    }
}
