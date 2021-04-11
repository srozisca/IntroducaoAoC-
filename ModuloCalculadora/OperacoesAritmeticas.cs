using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloCalculadora
{
    //Uma classe estática: não pode ser instanciada, não pode herdar, nem ser herdada, só pode conter membros estáticos.
    /// <summary>
    /// Classe com as operações matemáticas básicas de adição, subtração, multiplicação e divisão.
    /// </summary>
    public static class OperacoesAritmeticas 
    {
        /// <summary>
        /// Operação básica de adição
        /// </summary>
        /// <param name="parcela1">
        /// A primeira parcela
        /// </param>
        /// <param name="parcela2">
        /// A segunda parcela
        /// </param>
        /// <returns>A soma dos números informados</returns>
        public static double Adicao(double parcela1, double parcela2)
        {
            return parcela1 + parcela2;
        }

        /// <summary>
        /// Operação básica de subtração
        /// </summary>
        /// <param name="minuando">
        /// O minuendo
        /// </param>
        /// <param name="subtraendo">
        /// O subtraendo
        /// </param>
        /// <returns>
        /// A diferença dos números informados.
        /// </returns>
        public static double Subtracao(double minuando, double subtraendo)
        {
            return minuando - subtraendo;
        }

        /// <summary>
        /// Operação básica de multiplicação
        /// </summary>
        /// <param name="multiplicando">
        /// O multiplicando
        /// </param>
        /// <param name="multiplicador">
        /// O multiplicador
        /// </param>
        /// <returns>O produto dos números informados.</returns>
        public static double Multiplicacao(double multiplicando, double multiplicador)
        {
            return multiplicando * multiplicador;
        }

        /// <summary>
        /// Operação básica de divisão
        /// </summary>
        /// <param name="dividendo">
        /// O dividendo
        /// </param>
        /// <param name="divisor">
        /// O divisor
        /// </param>
        /// <returns>O quociente dos números informados</returns>
        public static double Divisao(double dividendo, double divisor)
        {
            return dividendo / divisor;
        }

    }
}
