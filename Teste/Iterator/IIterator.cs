using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Iterator
{
    /// <summary>
    /// Define uma interface iteradora personalizada. (Inspirado um pouco pelo iterador Java).
    /// </summary>
    /// <remarks>
    /// Às vezes, é vantajoso ter uma propriedade HasNext e uma propriedade Current. 
    /// Parece que, ao escrever analisadores / lexers, estou sempre tendo que implementar manualmente uma variável "hasNext". 
    /// Essa interface do Iterator simplifica esses usos.
    /// </remarks>
    /// <typeparam name="T"></typeparam>
    public interface IIterator<out T> : IDisposable
    {
        // Perhaps this should be renamed HasCurrent
        bool HasNext { get; }
        T Current { get; }
        void MoveNext();
    }
}
