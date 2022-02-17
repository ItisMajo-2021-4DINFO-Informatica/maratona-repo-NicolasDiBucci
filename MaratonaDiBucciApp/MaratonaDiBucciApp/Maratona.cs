using System;

namespace MaratonaDiBucciApp
{
     class Maratona
    {
        public string Nome { get; set; }
        public string Società { get; set; }
        public int TempoInMinuti { get; set; }
        public string Città { get; set; }

        internal object TempoSec(Maratona maratoneta)
        {
            throw new NotImplementedException();
        }
    }
}