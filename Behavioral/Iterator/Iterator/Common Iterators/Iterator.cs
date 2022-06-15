using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        public abstract int  Key();       // Возвращает ключ текущего элемента
        public abstract object Current(); // Возвращает текущий элемент.
        public abstract bool MoveNext();  // Переходит к следующему элементу.
        public abstract void Reset();     // Перематывает Итератор к первому элементу.
    }
}
