using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesParte2
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Cachorro("Rex",5);
            var g = new Gato("Ana",3);

            Animal a = new Gato("Felix", 5); //Polimorfismo: o gato também é um animal

            ExibeAnimal(c); //recebe argumento do tipo cachorro
            ExibeAnimal(g); //recebe argumento do tipo gato
            ExibeAnimal(a); //recebe argumento do tipo animal

            //object o = new Cachorro("Totó", 10);
        }

        public static void ExibeAnimal(Animal animal)
        {
            Console.WriteLine($"Nome: {animal.Nome}");
            Console.WriteLine($"Idade: {animal.Idade}");
            Console.WriteLine($"Som: {animal.SomEmitido}");
            Console.WriteLine($"Locomocao: {animal.Locomocao}");
            Console.WriteLine("\n");
        }
    }
}
