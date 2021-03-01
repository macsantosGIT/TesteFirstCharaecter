using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    public class Program
    {
        static void Main(string[] args)
        {
            var str = "aAbBABacfe";
            TesteStream.Stream stream = new TesteStream.Stream(str);
            TesteStream.FindFirstVogal findVogal = new TesteStream.FindFirstVogal();
            char result = findVogal.FirstChar(stream, str);
            Console.Write($"Primeira vogal após uma consoante: {result}");
            Console.ReadKey();
        }
    }
}
