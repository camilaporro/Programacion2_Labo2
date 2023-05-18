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
            string input = "";
            int esperado = 0;

            //act
            int resultado = calculadora.Add(input);

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
            string input = value;
            int esperado = int.Parse(input);

            //act
            int resultado = calculadora.Add(input);

            //assert
            Assert.AreEqual(esperado, resultado);            
        }

        [TestMethod]
        [DataRow("1,32", 33)]
        [DataRow("2,8", 10)]
        [DataRow("3,7", 10)]
        public void Add_IngresaDosNumerosSeparadosPorComa_RetornaLaSumaDeLosNumeros(string value, int esperado)
        {
            //arrange
            string input = value;

            //act
            int resultado = calculadora.Add(input);

            //assert
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        [DataRow("1,32,3", 36)]
        [DataRow("2,8,5,2", 17)]
        [DataRow("3,7,1,5,100", 116)]
        public void Add_IngresaXNumerosSeparadosPorComa_RetornaLaSumaDeLosNumeros(string value, int esperado)
        {
            //arrange
            string input = value;

            //act
            int resultado = calculadora.Add(input);

            //assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}