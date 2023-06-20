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
            Console.WriteLine($"Você escolhe esconder em sua casa.");
            Console.ReadLine();
            
            Console.WriteLine($"Existe vários lugares para se esconder, mas, você escolhe entrar no armário e se enfia entre as camisas. O lugar em si é muito claustrofóbico.");
            Console.ReadLine();
            
        
            Console.WriteLine($" Mas isso não importa.");
            Console.ReadLine();
            
            Console.WriteLine($"Pois você sabe.");
            Console.ReadLine();

            Console.WriteLine($"Ela está vindo.");
            Console.ReadLine();
        
            Console.ResetColor();

            Barra.BarraCarregamento("Mudando Perspectiva", 8, 300);
            Console.WriteLine($"");
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Você está caçando o assasino do seu Namorado.");
            Console.ReadLine();
            
            Console.WriteLine($"Você sabe quem foi, pois só podia ser ele.");
            Console.ReadLine();
            
            Console.WriteLine($"Então você vai para a casa dele, com uma faca ná mão e um ódio descumunal em seu olhar.");
            Console.ReadLine();
            
            Console.WriteLine($"Você se encontra parada frente a porta da casa, se ouve alguns movimentos dentro dela.");
            Console.ReadLine();
            
            Console.WriteLine($"Ele está lá.");
            Console.ReadLine();

            Console.WriteLine($"Você tenta abrir a porta mas não consegue,ela parece está trancada.");
            Console.ReadLine();
            
            Console.WriteLine($"Você tenta arrombar ela mas te falta força. Então, com um tijolo, quebra a janela e entra na casa");
            Console.ReadLine();
            
            Console.WriteLine($"A casa do Assassino é bem simples, com poucos moveis e cores frias");
            Console.ReadLine();
            
            Console.WriteLine($"Mas você não se importa com isso, só quer que ele page pela a Morte de Matheus.");
            Console.ReadLine();
            Console.ResetColor();

            
            Barra.BarraCarregamento("Mudando Perspectiva", 8, 300);
            Console.WriteLine($"");
            Console.ReadLine();


            ConsoleKeyInfo oQueFazer;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Ela está dentro da sua casa, você sente isso. Sua respiração fica pesada e sua boca fica seca. Algo precisa ser feito o que pretende fazer?");
            Console.ReadLine();
            Console.WriteLine($"");
            Console.WriteLine($"1 - Se equipar e se esconder");
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
                    e2.Escondido();
                    break;
                case ConsoleKey.D3:
                    e3.run();
                    break;
                default:
                    break;
            }
            Console.ResetColor();
        }
    }
}