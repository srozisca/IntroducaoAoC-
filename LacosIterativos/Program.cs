using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosIterativos
{
	class Program
	{
		static void Main(string[] args)
		{
			//Laços iterativos => estruturas que repetem um bloco de código determinado número de vezes

			//Laço for
			for (int i = 0; i < 5; i++) // i++ significa que i será incrementado de 1 em 1
			{
				Console.WriteLine("Valor de i é: " + i);
			}

			//While
			int contador = 3;
			while (contador < 10)
			{
				Console.WriteLine(contador);
				contador++;
			}
			//Do while
			//Execução garantida pelo menos uma vez, pois primeiro executa e depois testa a condição
			double j = 10;
			do
			{
				Console.WriteLine(j);
				j = j * 1.5;
			} while (j < 100);

			//Foreach
			//percorre todos os elementos de um conjunto
			int[] conjunto = { 1, 2, 3, 4, 7 };
			foreach (int numero in conjunto)
			{
				Console.WriteLine("Esse elemento do conjunto tem valor: " + numero + "! Somando esse va" +
					"lor a 10, temos: " + (numero+10));
			}
		}
	}
}
