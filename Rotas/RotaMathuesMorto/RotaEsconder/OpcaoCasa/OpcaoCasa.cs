using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MAtheus.Rotas.RotaMathuesMorto.RotaEsconder.OpcaoCasa.OqueFazer;

namespace MAtheus.Rotas.RotaMathuesMorto.RotaEsconder.Opcao
{
    public class OpcaoCasa : StatusDeVida
    {

        EquiparEAtacar e1 = new EquiparEAtacar();
        ContinuarEscondido e2 = new ContinuarEscondido();
        Fugir e3 = new Fugir();

        public void casa()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Você escolhe esconder em sua casa. Existe vários lugares para se esconder, mas, você escolhe entrar no armário e se enfia entre as camisas. O lugar em si é muito claustrofóbico. Você sente. Ela está vindo.");
            Console.ResetColor();

            Barra.BarraCarregamento("Mudando Perspectiva", 8, 300);
            Console.WriteLine($"");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Você está caçando o assasino do seu Namorado. Você sabe quem foi, pois só podia ser ele. Então você vai para a casa dele, com uma faca ná mão e sangue nos olhos. Você se encontra parada frente a porta da casa, se ouve alguns movimentos dentro da casa. Ele está lá. Você tenta abrir a porta mas não consegue, a porta está trancada. Você tenta arrombar a porta mas te falta força, então você quebra a janela e entra na casa");
            Console.WriteLine($" A casa do Assassino é bem simples, mas longe da sociedade, perfeita para alguém que gosta de matar. Você não se importa com os detalhes, só quer que page pela a Morte de Matheues.");
            Console.ResetColor();

            Console.ReadLine();
            Barra.BarraCarregamento("Mudando Perspectiva", 8, 300);
            Console.WriteLine($"");
            Console.ReadLine();


            ConsoleKeyInfo oQueFazer;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Ela está dentro da sua casa, você sente isso. Sua respiração fica pesada e sua boca fica seca. Algo precisa ser feito o que pretende fazer?");
            Console.ReadLine();
            Console.WriteLine($"");
            Console.WriteLine($"1 - Se equipar e atacar ela");
            Console.WriteLine($"2 - Continua escondido");
            Console.WriteLine($"3 - Fugir");
            Console.ResetColor();

            oQueFazer = Console.ReadKey(true);

            switch (oQueFazer.Key)
            {
                case ConsoleKey.D1:
                    e1.fazer();
                    break;
                case ConsoleKey.D2:
                    {
                        e2.Escondido();
                        break;
                    }
                case ConsoleKey.D3:
                    {
                        e3.run();
                        break;
                    }
                default:
                    break;
            }
            Console.ResetColor();
        }
    }
}