using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PedidosTest.ClienteServiceReference;

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
        public void T3_ObtenerArticulo()
        {

            ArticulosReference.ArticulosClient proxy = new ArticulosReference.ArticulosClient();
            Articulo articulo = proxy.ObtenerArticulo(1);
            Assert.AreEqual(articulo.Descripcion, "AQUOL 15 ML");


        }
        [TestMethod]
        public void T4_ListarArticulos()
        {
            ArticulosReference.ArticulosClient proxy = new ArticulosReference.ArticulosClient();
            ArticulosReference.Articulo[] listadoClientes = proxy.ListarArticulos();
            Assert.IsTrue(listadoClientes.Length > 0);
        }

        [TestMethod]
        public void T5_CrearCliente()
        {
            ArticulosReference.ArticulosClient proxy = new ArticulosReference.ArticulosClient();
            Articulo resultado = proxy.CrearArticulo("asdasdasd");
            Assert.AreEqual("asdasdasd", resultado.Descripcion);

        }
    }
}
