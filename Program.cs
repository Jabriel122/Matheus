using MAtheus;
using MAtheus.Rotas.RotaMatheusVivo;
using MAtheus.Rotas.RotaMathuesMorto;
using MAtheus.Rotas.RotaMathuesMorto.RotaEsconder.Opcao;

Rota1M r1 = new Rota1M();
StatusDeVida s1 = new StatusDeVida();

s1.StateVc = s1.vivo;

ConsoleKeyInfo escolha;
ConsoleKeyInfo opcoes;


do
{
    Console.WriteLine(@$"

                                                    Menu
                                                
                                            (1) - Jogar 
                                            (2) - Carregar

                                            (0) - Sair
");

    opcoes = Console.ReadKey(true);

    switch (opcoes.Key)
    {
        case ConsoleKey.D1:
            Console.WriteLine(@$"
            Esse aqui é Matheus

                       [°-°]
                        /|\
                        / \
");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Matheus é um grande código, sei lá. O que aconteceu com Matheus, ele tá vivo ou morto?");
            Console.ResetColor();
            string estado = Console.ReadLine().ToLower();


            while (estado != "morto" && estado != "vivo")
            {
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@$"
    Não sei o que você escreveu, mas Matheus está ali. ESCREVA O DESTINO DE MATHEUS

             [°-°]
              /|\
              / \     ????
    ");
                    Console.ResetColor();
                    estado = Console.ReadLine().ToLower();
                }
            }

            if (estado == "morto")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@$"
    Matheus morreu

             [*~*]
              /|\
              / \     Seu Monstro
    ");
                Console.ResetColor();

                Console.WriteLine($"");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Matheus morreu em um quarto escuro e vázio, você não sabia, mas Matheus tinha uma namorada. No dia em que ele morreu, ela iria visitá-lo depois de longos anos sem se verem...");
                Console.WriteLine($"Digite qualquer tecla para mudar de perspectiva");
                Console.ResetColor();

                string change = Console.ReadLine();

                Barra.BarraCarregamento("Mudando Perspectiva", 8, 300);
                Console.WriteLine($"");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@$"Frente a uma casa grande você se encherga pequena, você tá feliz, pois finalmente irá ve-lo Aquele que não via faz tempo, você estava no Canada fazendo intercambio, mas agora você está aqui, frente a casa do seu Namorado Matheus. Você toca campainha, um tempo se passa e ninguem aparece, mas isso não importa pois você tem a chave da casa dele, com ela você destranca a porta e entra na casa.

    A casa é bem estruturada e organizada, uma casa que concerteza só uma pessoa com uma grande quantia de dinhero possui. Mas isso não te abala mais pois você nem da muita atenção a mobilias diferentes que estavam nos comodos. Você anda em direção para o quarto de Matheus, sem pestanejar, a saudade é grande.
         
    Parada na porta do quarto você bate três vez, você chama ele, mas ninguem responde... Um sintimento ruim invade sua cabeça, algo como uma paranoia, você sente que algo não está certo. Você lentamente gira maçaneta e lentamente você empurra a porta... Por um segundo, alívio, Matheus estava lá, mas rapidamente esse alívio é substuido por um olhar de terror e lá você vê Matheus morto.
         ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@$"
        _______
        /[0O0]\
          /|\       Você matou Matheus....Irei me vingar!!!
          / \
    ");
                Console.ResetColor();

                Console.WriteLine($"");

                Barra.BarraCarregamento("Mudando Perspectiva", 8, 300);
                Console.WriteLine($"");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Namorada de Matheus está te caçando o que você quer fazer?");
                Console.WriteLine(@$" 
                Opções:
            1 - Esconder-se
            2 - Conversar com Ela
            3 - Fugir
            4 - Sai na porrada
    ");
                Console.ResetColor();
                escolha = Console.ReadKey(true);

                switch (escolha.Key)
                {
                    case ConsoleKey.D1:
                            r1.RotaEsconder();
                           break;
                    case ConsoleKey.D2:
                        {


                            break;
                        }
                    case ConsoleKey.D3:
                        {


                            break;
                        }
                    case ConsoleKey.D4:
                        {

                            break;
                        }
                    default:
                        break;
                }



            }
            else
            {
                Console.WriteLine(@$"
                Matheus está vivo

                           [°W°]
                            /|\
                            / \     Obrigado!
    ");

                s1.StateVc = s1.morto;
            }

            // Status de vida 
            if (s1.StateVc == s1.morto)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Você morreu!");
                Console.ResetColor();
            }
            else if (s1.StateVc == s1.satisfeito)
            {
                Console.WriteLine($"Você Sobreviveu, mas é isso mesmo o que você quer?");
            }


            // ################################
            break;
        case ConsoleKey.D2:
            Console.WriteLine($"Escolha qual parte você parou e digite a senha da Rota/Escolha");

            break;
        case ConsoleKey.D0:
            Console.WriteLine($"Tchau!!!");

            break;
        default:
            break;
    }
}
while (opcoes.Key != ConsoleKey.D0);











