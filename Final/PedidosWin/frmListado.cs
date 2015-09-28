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
    public partial class frmListado : Form
    {
        public frmListado()
        {
            InitializeComponent();
        }

        private void frmListado_Load(object sender, EventArgs e)
        {

            //string url = "http://localhost:23440/PedidosREST.svc/ListarPedidos";
            //string Datos = "";
            //string resp = RESTHeper.RESTHeper.Ejecutar(url, Datos, "POST");
            //List lstEstudiante = resp.DeserializarJsonTo();
            //dataGridView1.DataSource = lstEstudiante;

            dataGridView1.DataSource = "http://localhost:23440/PedidosREST.svc/ListarPedidos";

            
        }
    }
}
