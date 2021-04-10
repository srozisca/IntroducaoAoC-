using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Laços condicionais => execução mediante determinada condição/situação satisfeita
            int hora = 18;

            // Laço if, else if e else

            //if (hora >= 15) //se a hora for maior ou igual a 15, será impressa a mensagem no console
            //    Console.WriteLine("Já são 15h ou mais!");
            //else if (hora <= 17)
            //    Console.WriteLine("A hora é maior que 13!");
            //else //o else garante a execução do  bloco de código seguinte a ele
            //{
            //    if(hora == 18)
            //        Console.WriteLine("São 18h!");
            //    else
            //        Console.WriteLine("Já passou das 18h!");
            //}

            //switch..case
            // Geralmente a expressão avaliada é uma constante
            // Em nenhuma hipótese, dois casos serão executados simultaneamente.
            //switch(hora)
            //{
            //    case 15: // o teste condicional aqui é exato
            //        Console.WriteLine("São 15h!");
            //        break;
            //    case 18: // o teste condicional aqui é exato
            //        Console.WriteLine("São 18h!");
            //        break;
            //}

            PrimeiroSemestre mes = PrimeiroSemestre.Maio;
            if(mes == PrimeiroSemestre.Maio)
                Console.WriteLine("Estamos em Maio com o if.");

            switch(mes)
            {
                case PrimeiroSemestre.Janeiro:
                    Console.WriteLine("Estamos em Janeiro.");
                    break;
                case PrimeiroSemestre.Fevereiro:
                    Console.WriteLine("Estamos em Fevereiro.");
                    break;
                case PrimeiroSemestre.Marco:
                    Console.WriteLine("Estamos em Março.");
                    break;
                //case PrimeiroSemestre.Abril:
                //    Console.WriteLine("Estamos em Abril.");
                //    break;
                //case PrimeiroSemestre.Maio:
                //    Console.WriteLine("Estamos em Maio.");
                //    break;
                //case PrimeiroSemestre.Junho:
                //    Console.WriteLine("Estamos em Junho");
                //    break;
                default:
                    Console.WriteLine("O mês atual não é nem Janeiro, Fevereiro, ou Março. É " + mes);
                    break;
            }
        }

    }

    public enum PrimeiroSemestre
    {
        Janeiro, Fevereiro, Marco, Abril, Maio, Junho
    }
}
