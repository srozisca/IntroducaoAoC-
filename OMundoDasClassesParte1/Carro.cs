using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMundoDasClassesParte1
{
    public class Carro
    {
        //Atributos do carro
        public  int     Portas  { get; }
        public  string  Modelo  { get; }
        public  Cor     Cor     { get; set; }

        private bool    ligado = false; // private = só a classe tem acesso

        public bool Ligado //propriedade = define uma maneira de acessar atributos
        {
            get //retorna valor
            {
                return ligado;
            }
            //set //atribui valor
            //{
            //    ligado = value;
            //}
        }

        //Método construtor da classe
        public Carro(Cor cor, int portas, string modelo)
        {
            Cor = cor;
            Portas = portas;
            Modelo = modelo;
        }

        //Comportamentos do carro
        public string Ligar()
        {
            ligado = true;
            return "O carro foi ligado.";
        }

        public string Desligar()
        {
            ligado = false;
            return "O carro foi desligado.";
        }

        public string Andar()
        {
            if (ligado)
                return "O carro está andando.";
            else
                return "O carro está desligado.";
        }
    }
}
