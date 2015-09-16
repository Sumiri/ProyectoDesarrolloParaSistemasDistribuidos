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
    }
}
