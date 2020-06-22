using System.Collections;

namespace UtilizandoPOO._1_POO
{
    public class Canis : IEnumerator
    {
        public Cachorro[] _cachorros;
        private int _current = -1;
        public object Current => _current;

        public Canis(Cachorro[] cachorros)
        {
            _cachorros = cachorros;
        }

        object IEnumerator.Current => _cachorros[_current];

        public bool MoveNext()
        {
            _current++;
            return (_current < _cachorros.Length);
        }

        public void Reset()
        {
            _current = -1;
        }
    }
}
