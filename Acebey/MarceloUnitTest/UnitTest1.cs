using Microsoft.VisualStudio.TestTools.UnitTesting;
using Marcelo;

namespace MarceloUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Organizar

            double cantidadInicial = 100.00;
            double cantidadRetirada = 45.00;
            double cantidadEsperada = 55.00;
            Company objeto = new Company("Marcelito", cantidadInicial);

            //Actuar

            objeto.Spend(cantidadRetirada);

            //Verificar

            double cantidad = objeto.SaveProject;
            Assert.AreEqual(cantidadEsperada, cantidad, 0.001, "Cantidad no Retirada correctamente");

        }

        [TestMethod]
        public void TestMethod2()
        {
            //Organizar

            double cantidadInicial = 100.00;
            double cantidadIngresada = 45.00;
            double cantidadEsperada = 145.00;
            Company objeto = new Company("Marcelito", cantidadInicial);

            //Actuar

            objeto.Save(cantidadIngresada);

            //Verificar

            double cantidad = objeto.SaveProject;
            Assert.AreEqual(cantidadEsperada, cantidad, 0.001, "Cantidad no Ingresada correctamente");

        }
        [TestMethod]
        public void TestMethod3()
        {
            //Organizar
            string nombreini = "Marcelito";
            string nombrecamb = "Antonio";
            string nombreesperado = nombrecamb;
            Company objeto = new Company(nombreini, 100.00);
            //Actuar
            objeto.ChangeName(nombrecamb);
            //Verificar
            string nombre = objeto.Name;
            Assert.AreEqual(nombreesperado, nombre,"", "Nombre sin cambios Error");
        }
    }
}
