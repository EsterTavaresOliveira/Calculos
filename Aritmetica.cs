using System;

namespace Calculos
{  // Implementa operações aritméticas 
    internal static class Aritmetica
    {
        //operação soma
        //retorna soma de 2 valores
        public static int Somar (int x, int y)
        {
            return x + y;
        }
        //operação subtração
        //retorna subtração de 2 valores
        public static int Subtrair(int x, int y)
        {
            return x - y;
        }
        //operação multiplicação
        //retorna multiplicação de 2 valores
        public static int Multiplicar(int x, int y)
        {
            return x * y;
        }
        //operação dividir
        //retorna dividir de 2 valores
        public static int Dividir(int x, int y)
        {
            return x / y;
        }
    }
}
