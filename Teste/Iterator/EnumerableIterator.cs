using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Iterator
{
    /// <summary>
    /// Define uma implementação de <see cref = "IIterator {T}" /> que
    /// funciona em qualquer instância <see cref = "IEnumerable {T}" />.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class EnumerableIterator<T> : IIterator<T>
    {
        private readonly IEnumerator<T> enumerator;
        private bool hasNext;

        public bool HasNext
        {
            get { return hasNext; }
        }

        public T Current
        {
            get { return enumerator.Current; }
        }

        public void MoveNext()
        {
            hasNext = enumerator.MoveNext();
        }

        private EnumerableIterator(IEnumerator<T> enumerator)
        {
            this.enumerator = enumerator;
            this.hasNext = enumerator.MoveNext();
        }

        /// <summary>
        /// Obtém um iterador para o enumerável especificado.
        /// </summary>
        /// <param name="enumerable"></param>
        /// <returns></returns>
        public static IIterator<T> GetIterator(IEnumerable<T> enumerable)
        {
            return new EnumerableIterator<T>(enumerable.GetEnumerator());
        }

        public void Dispose()
        {
            enumerator.Dispose();
        }
    }
}
