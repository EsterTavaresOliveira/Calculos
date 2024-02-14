using System;

namespace Calculos
{  // Implementa operações aritméticas 
    internal class Aritmetica
    {


        /// <summary>
        /// Tipo de conversÃ£o de temperatura a executar.
        /// </summary>

        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }

        public double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
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


        //operação soma
        //retorna soma de 2 valores
        public int Somar (int x, int y)
        {
            return x + y;
        }
        //operação subtração
        //retorna subtração de 2 valores
        public int Subtrair(int x, int y)
        {
            return x - y;
        }
        //operação multiplicação
        //retorna multiplicação de 2 valores
        public int Multiplicar (int x, int y)
        {
            return x * y;
        }


    }
}
