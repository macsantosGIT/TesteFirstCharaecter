using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Iterator
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Fornece um método de extensão que obtém um iterador para IEnumerables. 
        /// Isso torna tão fácil obter um iterador quanto obter um enumerador.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable"></param>
        /// <returns></returns>
        public static IIterator<T> GetIterator<T>(this IEnumerable<T> enumerable)
        {
            return EnumerableIterator<T>.GetIterator(enumerable);
        }
    }

}
