using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAtheus
{
    public class Barra
    {
        public static void BarraCarregamento(string texto, int Ponto, int Tempo)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write(texto);

            for (var i = 0; i < Ponto; i++)
            {
                Console.Write($".");
                Thread.Sleep(Tempo);
            }
            Console.ResetColor();
        }
    }
}