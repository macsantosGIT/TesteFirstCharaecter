using Microsoft.VisualStudio.TestTools.UnitTesting;
using Teste;

namespace TesteUnitario
{
    [TestClass]
    public class TestFindFirstVogal
    {
        [TestMethod]
        public void TestFindFirstVogalValid()
        {
            var str = "aAbBABacfe";
            TesteStream.Stream stream = new TesteStream.Stream(str);
            TesteStream.FindFirstVogal findFirstVogal = new TesteStream.FindFirstVogal();

            char resultado;
            try
            {
                resultado = findFirstVogal.FirstChar(stream, str);
            }
            catch (System.Exception)
            {
                resultado = ' ';
            }
            Assert.IsTrue(resultado != ' ');
        }

        [TestMethod]
        public void TestFindFirstVogalInvalid()
        {
            var str = "bbbbrtoRWp";
            TesteStream.Stream stream = new TesteStream.Stream(str);
            TesteStream.FindFirstVogal findFirstVogal = new TesteStream.FindFirstVogal();

            char resultado;
            try
            {
                resultado = findFirstVogal.FirstChar(stream, str);
            }
            catch (System.Exception)
            {
                resultado = ' ';
            }
            Assert.IsTrue(resultado != ' ');
        }
    }
}
