using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MAtheus;
using MAtheus.Rotas.RotaMathuesMorto.RotaEsconder.Opcao;

namespace MAtheus.Rotas.RotaMathuesMorto
{

    public class Rota1M : StatusDeVida
    {

        OpcaoCasa o1 = new OpcaoCasa();
        OpcaoCasaAbandonada o2 = new OpcaoCasaAbandonada();
        OpcaoCasaDeMatheus o3 = new OpcaoCasaDeMatheus();
        public void RotaEsconder()
        {
            ConsoleKeyInfo EsconderEscolha;

            Console.WriteLine(@$"A onde você quer se esconder?
                Opções:

                1 - Casa
                2 - Casa Abandonada
                3 - Casa de Matheus 
                ");
            EsconderEscolha = Console.ReadKey(true);

            switch (EsconderEscolha.Key)
            {
                case ConsoleKey.D1:
                    o1.casa();
                    break;
                case ConsoleKey.D2:
                    o2.CasaAbandonada();

                    break;
                case ConsoleKey.D3:
                    o3.CasaMatheus();
                    break;

                default:
                    break;
            }


        }
    }
}