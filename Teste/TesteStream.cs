using System;

namespace Teste
{
    public class TesteStream
    {
        /// <summary>
        /// Interface Stream
        /// </summary>
        public interface IStream
        {
            char getNext();
            Boolean hasNext();
        }

        /// <summary>
        /// Classe Stream que implementa os meétos de interfave IStream para percorrer a cadeia de caracteres. 
        /// </summary>
        public class Stream : IStream
        {
            public String stream;
            private int indexOf = 0;

            /// <summary>
            /// Construtor que recebe a string
            /// </summary>
            /// <param name="stream"></param>
            public Stream(String stream)
            {
                this.stream = stream;
            }
            /// <summary>
            /// Retorna próximo caracter do stream 
            /// </summary>
            /// <returns></returns>
            public char getNext()
            {
                return this.stream[indexOf++];
            }

            /// <summary>
            /// Valida se existem mais caracteres
            /// </summary>
            /// <returns></returns>
            public Boolean hasNext()
            {
                return (this.stream.Length > indexOf);
            }
        }

        public class FindFirstVogal
        {
            /// <summary>
            /// Classe resposável por retorno o primeiro caractere vogal após uma consoante
            /// </summary>
            /// <param name="input"></param>
            /// <param name="str"></param>
            /// <returns></returns>
            public char FirstChar(IStream input, string str)
            {
                string vogais = "aeiouAEIOU";

                char c;
                int index = 0;
                int indexVogal = 0;
                int predecessor = 0;
                int vogal = 0;

                string[] res = new string[((Stream)(input)).stream.Length];

                char[] chars = new char[((Stream)(input)).stream.Length];
                char[] charsStream = str.ToCharArray();

                while (input.hasNext())
                {
                    c = input.getNext();
                    chars[index] = c;
                    vogal = vogais.Contains(c.ToString()) ? 1 : 2;
                    if (index == 0)
                    {
                        predecessor = vogais.Contains(c.ToString()) ? 1 : 2;
                    }
                    else
                    {
                        var c1 = charsStream[index - 1];
                        predecessor = vogais.Contains(c1.ToString()) ? 1 : 2;
                    }
                    var qtdRepete = QuantidadeRepeticao(c.ToString().ToLower(), charsStream);

                    var result = $"{index.ToString()},{qtdRepete.ToString()},{predecessor.ToString()},{vogal.ToString()}";

                    res[index] = result;

                    index++;
                }

                for (int i = 0; i < res.Length; i++)
                {
                    var result = res[i].Split(',');

                    if (result[1] == "1" && result[2] == "2" && result[3] == "1")
                    {

                        indexVogal = Convert.ToInt32(result[0]);
                        break;
                    }
                }

                return chars[indexVogal];
            }

            /// <summary>
            /// Método que verifica a quantidade de repetição do caractere.
            /// </summary>
            /// <param name="letra"></param>
            /// <param name="input"></param>
            /// <returns></returns>
            private int QuantidadeRepeticao(string letra, char[] input)
            {
                int repete = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i].ToString().Contains(letra))
                        repete++;
                }
                return repete;
            }

        }
    }
}
