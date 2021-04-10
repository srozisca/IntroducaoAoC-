using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesParte1
{
    class Program  //sem modificador de acesso explícito = internal por padrão
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro(Cor.Branco, 4, "Gol G6"); //criando carro

            //exibindo atributos do carro
            Console.WriteLine("O carro é um " + carro.Modelo + " de cor " + carro.Cor + " e tem " + carro.Portas);

            Console.WriteLine(carro.Ligar()); //Ligar carro
            Console.WriteLine("Ligado? " +  carro.Ligado); 
            Console.WriteLine(carro.Andar()); //Andar com carro

            Console.WriteLine(carro.Desligar());
            Console.WriteLine("Ligado? " +  carro.Ligado);

            carro.Cor = Cor.Azul; //pintando o carro de azul
            Console.WriteLine("A nova cor do carro é " + carro.Cor);
        }
    }
}
 