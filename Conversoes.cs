using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculos.Aritmetica;

namespace Calculos
{
    internal static class Conversoes
    {
        /// <summary>
        /// Tipo de conversacao de distancias.
        /// </summary>
        public enum ConversaoDistancia
        {
            Nulo = 0,
            MetrosMilhas,
            MilhasMetros
        }

        /// <summary>
        /// Tipo de conversão de temperatura a executar.
        /// </summary>

        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }

        /// <summary>
        /// Conversão de distâncias.
        /// </summary>
        /// <param name="conversao">A Conversão a efetuar.</param>
        /// <param name="distancia">A distância a converter</param>
        /// <returns>Retorna o resultado da conversão da distância.</returns>

        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8000 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return ((temperatura - 32) / 1.8000);
            }

            return -1;
        }

    }
}
