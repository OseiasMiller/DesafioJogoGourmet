using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmet
{
    class TipoPrato
    {
        public string Nome { get; set; }
        public List<Prato> Pratos { get; set; }

        public TipoPrato(string name)
        {
            Nome = name;
            Pratos = new List<Prato>();
           
        }
    }
}
