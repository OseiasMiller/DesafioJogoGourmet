using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmet
{
    class Prato
    {
        public string Nome { get; set; }

        public Prato(string nome)
        {
            Nome = nome;
        }

        internal void Deconstruct(out int index, out Prato prato)
        {
            throw new NotImplementedException();
        }
    }
}
