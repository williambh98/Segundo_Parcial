using Microsoft.VisualStudio.TestTools.UnitTesting;
using SegundoParcial.BLL;
using SegundoParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoParcial.BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Vendedor vendedor = new Vendedor();
            vendedor.VendedorID = 1003;
            vendedor.Nombre = "William";
            vendedor.Restencion = 12;
            vendedor.Sueldo= 100000;
            vendedor.Total = 200000;
            vendedor.FechaVendedor = DateTime.Now;

            RepositorioBase<Vendedor> repositorio;
            repositorio = new RepositorioBase<Vendedor>();
            Assert.IsTrue(repositorio.Guardar(vendedor));
        }
    }
}