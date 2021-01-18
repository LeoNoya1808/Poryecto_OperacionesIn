using NUnit.Framework;
using Web_Operaciones.Controllers;

namespace NUnitTestCalculadora
{
    public class TestCalculadora
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSuma1()
        {
            //Arrange=Preparacion
            int num1 = 5;
            int num2 = 7;
            int esperado = 12;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.SumaPost(num1, num2);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestSuma2()
        {
            //Arrange=Preparacion
            int num1 = 2;
            int num2 = 3;
            int esperado = 5;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.SumaPost(num1, num2);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestSuma3()
        {
            //Arrange=Preparacion
            int num1 = 5;
            int num2 = 9;
            int esperado = 14;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.SumaPost(num1, num2);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestSuma4()
        {
            //Arrange=Preparacion
            int num1 = 1;
            int num2 = 3;
            int esperado = 4;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.SumaGet(num1, num2);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestSuma5()
        {
            //Arrange=Preparacion
            int num1 = 2;
            int num2 = 5;
            int esperado = 7;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.SumaGet(num1, num2);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestSuma6()
        {
            //Arrange=Preparacion
            int num1 = 10;
            int num2 = 8;
            int esperado = 18;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.SumaGet(num1, num2);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestResta1()
        {
            //Arrange=Preparacion
            int num1 = 10;
            int num2 = 2;
            int esperado = 8;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.RestaPost(num1, num2);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestResta2()
        {
            //Arrange=Preparacion
            int num1 = 3;
            int num2 = 1;
            int esperado = 2;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.RestaPost(num1, num2);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestResta3()
        {
            //Arrange=Preparacion
            int num1 = 12;
            int num2 = 8;
            int esperado = 4;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.RestaPost(num1, num2);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestResta4()
        {
            //Arrange=Preparacion
            int num1 = 5;
            int num2 = 3;
            int esperado = 2;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.RestaGet(num1, num2);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestResta5()
        {
            //Arrange=Preparacion
            int num1 = 2;
            int num2 = 1;
            int esperado = 1;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.RestaGet(num1, num2);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestResta6()
        {
            //Arrange=Preparacion
            int num1 = 13;
            int num2 = 7;
            int esperado = 6;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.RestaGet(num1, num2);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestMultiplicacion1()
        {
            //Arrange=Preparacion
            int num1 = 5;
            int num2 = 7;
            int esperado = 35;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.MultiplicarPost(num1, num2);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestMultiplicacion2()
        {
            //Arrange=Preparacion
            int num1 = 5;
            int num2 = 8;
            int esperado = 40;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.MultiplicarPost(num1, num2);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestMultiplicacion3()
        {
            //Arrange=Preparacion
            int num1 = 2;
            int num2 = 3;
            int esperado = 6;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.MultiplicarPost(num1, num2);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestMultiplicacion4()
        {
            //Arrange=Preparacion
            int num1 = 2;
            int num2 = 7;
            int esperado = 14;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.MultiplicarGet(num1, num2);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestMultiplicacion5()
        {
            //Arrange=Preparacion
            int num1 = 8;
            int num2 = 9;
            int esperado = 72;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.MultiplicarGet(num1, num2);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestMultiplicacion6()
        {
            //Arrange=Preparacion
            int num1 = 10;
            int num2 = 7;
            int esperado = 70;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.MultiplicarGet(num1, num2);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestDivision1()
        {
            //Arrange=Preparacion
            int num1 = 5;
            int num2 = 0;
            int esperado = 0;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.DividirPost(num1, num2);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestDivision2()
        {
            //Arrange=Preparacion
            int num1 = 6;
            int num2 = 2;
            int esperado = 3;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.DividirPost(num1, num2);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestDivision3()
        {
            //Arrange=Preparacion
            int num1 = 6;
            int num2 = 3;
            int esperado = 2;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.DividirPost(num1, num2);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestDivision4()
        {
            //Arrange=Preparacion
            int num1 = 15;
            int num2 = 3;
            int esperado = 5;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.DividirGet(num1, num2);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestDivision5()
        {
            //Arrange=Preparacion
            int num1 = 18;
            int num2 = 6;
            int esperado = 3;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.DividirGet(num1, num2);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }
        [Test]
        public void TestDivision6()
        {
            //Arrange=Preparacion
            int num1 = 25;
            int num2 = 5;
            int esperado = 5;
            CalculadoraController calc = new CalculadoraController();

            //Act=Ejecucion
            int resultado = calc.DividirGet(num1, num2);

            //Assert=Verificacion
            Assert.AreEqual(esperado, resultado);

        }

    }
}