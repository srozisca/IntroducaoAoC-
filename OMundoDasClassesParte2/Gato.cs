using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesParte2
{
    public class Gato : Animal
    {
        public Gato(string nome, int idade) 
            : base(nome, idade) //invoca o construtor da classe base Animal
        {
        }

        public override Som SomEmitido => Som.Miado;
        public override string Locomocao => "Pulando";
    }
}
