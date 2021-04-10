using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesParte2
{
    public abstract class Animal //uma classe abstrata não pode ser instanciada 
    {
        public string   Nome    { get; }
        public int      Idade   { get; }
        public abstract Som SomEmitido { get; } //essa prop deverá ser implementada por cada classe filha
        public virtual string Locomocao { get { return "Está andando"; } }

        public Animal(string nome, int idade)
        {
            Nome    = nome;
            Idade   = idade;
        }
    }
}
