using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PedidosTest.ClienteServiceReference;
using System.Text;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace PedidosTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void T1_CrearCliente()
        {
            ClienteServiceReference.ClientesClient proxy = new ClienteServiceReference.ClientesClient();
            Cliente resultado = proxy.CrearCliente("CLINICA AMERICANA", "clinicaa@gmail.com");
            Assert.AreEqual("CLINICA AMERICANA", resultado.RazonSocial);
            Assert.AreEqual("clinicaa@gmail.com", resultado.Correo);
        }

        [TestMethod]
        public void T2_ListarClientes()
        {
            ClienteServiceReference.ClientesClient proxy = new ClienteServiceReference.ClientesClient();
            ClienteServiceReference.Cliente[] listadoClientes = proxy.ListarClientes();
            Assert.IsTrue(listadoClientes.Length > 0);
        }

        [TestMethod]
        public void TestModificar()
        {
            string postdata = "{\"Numero\":\"1\",\"Fecha\":\"11/11/2015\",\"Moneda\":\"2\"}";
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:23440/PedidosREST.svc/Pedidos");
            req.Method = "PUT";
            req.ContentLength = data.Length;
            req.ContentType = "application/json";
            var reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            var res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string pedidoJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Pedido pedidoModificado = js.Deserialize<Pedido>(pedidoJson);
            Assert.AreEqual("1", pedidoModificado.Numero);
            Assert.AreEqual("11/11/2015 12:00:00 a.m.", pedidoModificado.Fecha);
            Assert.AreEqual("2", pedidoModificado.Moneda);
        }


        [TestMethod]
        public void TestEliminar()
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:23440/PedidosREST.svc/Pedidos/1");
            req.Method = "DELETE";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();

            req = (HttpWebRequest)WebRequest.Create("http://localhost:23440/PedidosREST.svc/Pedidos/1");
            req.Method = "GET";
            res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string pedidoJson = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Pedido pedidoEliminado = js.Deserialize<Pedido>(pedidoJson);
            Assert.IsNull(pedidoEliminado);
        }

        //[TestMethod]
        //public void T3_ObtenerArticulo()
        //{

        //    ArticulosReference.ArticulosClient proxy = new ArticulosReference.ArticulosClient();
        //    Articulo articulo = proxy.ObtenerArticulo(1);
        //    Assert.AreEqual(articulo.Descripcion, "AQUOL 15 ML");


        //}
        //[TestMethod]
        //public void T4_ListarArticulos()
        //{
        //    ArticulosReference.ArticulosClient proxy = new ArticulosReference.ArticulosClient();
        //    ArticulosReference.Articulo[] listadoClientes = proxy.ListarArticulos();
        //    Assert.IsTrue(listadoClientes.Length > 0);
        //}

        //[TestMethod]
        //public void T5_CrearCliente()
        //{
        //    ArticulosReference.ArticulosClient proxy = new ArticulosReference.ArticulosClient();
        //    Articulo resultado = proxy.CrearArticulo("asdasdasd");
        //    Assert.AreEqual("asdasdasd", resultado.Descripcion);

        //}
    }
}
