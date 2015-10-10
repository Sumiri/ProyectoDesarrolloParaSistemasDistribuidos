using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PedidosWin
{
    public partial class frmComisiones : Form
    {
        public frmComisiones()
        {
            InitializeComponent();
        }

        private void btnGenerarComisiones_Click(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                string htmlResponse = client.DownloadString("http://localhost:23440/ComisionesREST.svc/ListarComisiones");

                DataSet set = new DataSet();
                byte[] buffer = Encoding.UTF8.GetBytes(htmlResponse);
                using (MemoryStream stream = new MemoryStream(buffer))
                {
                    XmlReader reader = XmlReader.Create(stream);
                    set.ReadXml(reader);
                }

                dataGridView1.DataSource = set;
                dataGridView1.DataMember = "Comision";

                dataGridView1.Columns["CodUsuarioVendedor"].DisplayIndex = 0;
                dataGridView1.Columns["CodUsuarioVendedor"].HeaderText = "Código";
                dataGridView1.Columns["CodUsuarioVendedor"].Width = 100;
                dataGridView1.Columns["CodUsuarioVendedor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dataGridView1.Columns["DesUsuario"].DisplayIndex = 1;
                dataGridView1.Columns["DesUsuario"].HeaderText = "Vendedor";
                dataGridView1.Columns["DesUsuario"].Width = 330;

                dataGridView1.Columns["ImporteSolVendido"].DisplayIndex = 2;
                dataGridView1.Columns["ImporteSolVendido"].HeaderText = "Importe Vendido S/.";
                dataGridView1.Columns["ImporteSolVendido"].Width = 110;
                dataGridView1.Columns["ImporteSolVendido"].ValueType = typeof(System.Double);
                dataGridView1.Columns["ImporteSolVendido"].DefaultCellStyle.Format = "#,0.##";
                dataGridView1.Columns["ImporteSolVendido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dataGridView1.Columns["PorcentajeComision"].DisplayIndex = 3;
                dataGridView1.Columns["PorcentajeComision"].HeaderText = "% Comisión";
                dataGridView1.Columns["PorcentajeComision"].Width = 110;
                dataGridView1.Columns["PorcentajeComision"].ValueType = typeof(System.Double);
                dataGridView1.Columns["PorcentajeComision"].DefaultCellStyle.Format = "#,0.##";
                dataGridView1.Columns["PorcentajeComision"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dataGridView1.Columns["ImporteComisionSol"].DisplayIndex = 4;
                dataGridView1.Columns["ImporteComisionSol"].HeaderText = "Comisión S/.";
                dataGridView1.Columns["ImporteComisionSol"].Width = 110;
                dataGridView1.Columns["ImporteComisionSol"].ValueType = typeof(System.Double);
                dataGridView1.Columns["ImporteComisionSol"].DefaultCellStyle.Format = "#,0.##";
                dataGridView1.Columns["ImporteComisionSol"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                /*dataGridView1.Columns["ImporteComisionUsd"].DisplayIndex = 3;
                dataGridView1.Columns["ImporteComisionUsd"].HeaderText = "Comisión $.";
                dataGridView1.Columns["ImporteComisionUsd"].Width = 110;
                dataGridView1.Columns["ImporteComisionUsd"].ValueType = typeof(System.Double);
                dataGridView1.Columns["ImporteComisionUsd"].DefaultCellStyle.Format = "#,0.##";
                dataGridView1.Columns["ImporteComisionUsd"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;*/

                //dataGridView1.Columns["Anho"].Visible = false;
            }

        }

        private void frmComisiones_Load(object sender, EventArgs e)
        {
            //
            txtAno.Text = DateTime.Now.Year.ToString();
            //
            DateTimeFormatInfo formatoFecha = CultureInfo.CurrentCulture.DateTimeFormat;
            string nombreMes = formatoFecha.GetMonthName(10);
            txtMes.Text = nombreMes;
        }
    }
}
