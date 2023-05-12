using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAtheus
{
    public class StatusDeVida
    {
        public int morto = 0;
        public int vivo = 1;
        public int satisfeito = 2;
        public int StateVc;

        // Status de vida 


        public void StatusVida ()
        {

            if (StateVc == morto)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Você morreu!");
                Console.ResetColor();
            }
            else if (StateVc == satisfeito)
            {
                Console.WriteLine($"Você Sobreviveu, mas é isso mesmo o que você quer?");
            }


            // ################################
        }

    }
}