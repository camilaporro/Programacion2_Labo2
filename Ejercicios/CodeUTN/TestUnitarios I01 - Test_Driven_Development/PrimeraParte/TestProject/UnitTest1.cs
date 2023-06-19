using Newtonsoft.Json.Linq;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        Calculadora calculadora = new Calculadora();

        [TestMethod]
        public void Add_CuandoStringEstaVacio_DevuelveCero()
        {
            //arrange
            string imput = "";
            int esperado = 0;

            //act
            int resultado = calculadora.Add(imput);

            //assert
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        [DataRow("1")]
        [DataRow("2")]
        [DataRow("3")]
        public void Add_IngresaUnSoloNumero_RetornaEseNumero(string value)
        {
            //arrange
            string imput = value;
            int esperado = int.Parse(imput);

            //act
            int resultado = calculadora.Add(imput);

            //assert
            Assert.AreEqual(esperado, resultado);            
        }

        [TestMethod]
        public void Add_IngresaNumerosConComa_RetornaLaSumaDeLosNumeros()
        {
            //arrange
            string imput = "1,20";
            int esperado = 21;

            //act
            int resultado = calculadora.Add(imput);

            //assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}