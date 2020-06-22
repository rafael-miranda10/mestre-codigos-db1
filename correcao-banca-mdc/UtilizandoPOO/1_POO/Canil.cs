using System.Collections;

namespace UtilizandoPOO._1_POO
{
    public class Canil : IEnumerable
    {
        private Cachorro[] _cachorrosCanil;

        public Canil(Cachorro[] cachorrosCanil)
        {
            _cachorrosCanil = cachorrosCanil;
        }
        public IEnumerator GetEnumerator()
        {
            return new Canis(_cachorrosCanil);
        }
    }
}
