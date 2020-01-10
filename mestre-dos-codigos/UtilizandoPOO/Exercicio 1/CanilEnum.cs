using System.Collections;

namespace UtilizandoPOO.Exercicio_1
{
    public class CanilEnum : IEnumerator
    {
        public Cachorro[] cachorro;
        private int _current = -1;
        public int Current => _current;

        public CanilEnum(Cachorro[] lista)
        {
            cachorro = lista;
        }

        object IEnumerator.Current => cachorro[_current];

        public bool MoveNext()
        {
            _current++;
            return (_current < cachorro.Length);
        }

        public void Reset()
        {
            _current = -1;
        }


    }
}
