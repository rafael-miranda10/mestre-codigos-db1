using System;
using System.Collections;

namespace UtilizandoPOO.Exercicio_1
{
    public class Canil : IEnumerable
    {
        private Cachorro[] _cachorros;

        public Canil(Cachorro[] cArray)
        {
            _cachorros = cArray;

            //_cachorros = new Cachorro[cArray.Length];
            //for (int i = 0; i<cArray.Length; i++)
            //{
            //    _cachorros[i] = cArray[i];
            //}
        }

        public IEnumerator GetEnumerator()
        {
            return new CanilEnum(_cachorros);
        }
    }
}
