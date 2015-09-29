﻿using System;
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
              
                DataSet set = new DataSet();
                byte[] buffer = Encoding.UTF8.GetBytes(htmlResponse);
                using (MemoryStream stream = new MemoryStream(buffer))
                {
                    XmlReader reader = XmlReader.Create(stream);
                    set.ReadXml(reader);
                }
               
                dataGridView1.DataSource = set;
                dataGridView1.DataMember = "Pedido";
            }
        }
    }
}
