using MAtheus;
using MAtheus.Rotas.RotaMatheusVivo;
using MAtheus.Rotas.RotaMathuesMorto;
using MAtheus.Rotas.RotaMathuesMorto.RotaEsconder.Opcao;
using MAtheus.Rotas.RotaMathuesMorto.Fugir1;
using MAtheus.Rotas.RotaMathuesMorto.RotaConversaComEla;
using MAtheus.Rotas.RotaMathuesMorto.SaiNaPorrada;
// using MAtheus.Rotas.RotaMathuesMorto.RotaEsconder;


StatusDeVida s1 = new StatusDeVida();
FugirM f1 = new FugirM();
RotaConversaM c1 = new RotaConversaM();
Punch p1 = new Punch();

// Rota esconder(Funções)
Rota1M r1 = new Rota1M();
OpcaoCasa r2 = new OpcaoCasa();
OpcaoCasaAbandonada r3 = new OpcaoCasaAbandonada();
OpcaoCasaDeMatheus r4 = new OpcaoCasaDeMatheus();

s1.StateVc = s1.vivo;

ConsoleKeyInfo escolha;
ConsoleKeyInfo opcoes;


do
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(@$"

                                                    Menu
                                                
                                            (1) - Jogar 
                                            (2) - Carregar

                                            (0) - Sair
");
    Console.ResetColor();
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
                Console.ReadLine();
                
                Console.WriteLine($"No dia em que ele morreu, ela iria visitá-lo depois de longos anos sem se verem...");
                Console.ReadLine();
                
                Console.WriteLine($"Digite qualquer tecla para mudar de perspectiva");
                Console.ReadLine();
                
                Console.ResetColor();

                string change = Console.ReadLine();

                Barra.BarraCarregamento("Mudando Perspectiva", 8, 300);
                Console.WriteLine($"");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@$" Você toca campainha, um tempo se passa e ninguem aparece, mas isso não importa pois você tem a chave da casa dele, com ela você destranca a porta e entra na casa.

    A casa é bem estruturada e organizada, uma casa que concerteza só uma pessoa com uma grande quantia de dinhero possui. Mas isso não te abala mais pois você nem da muita atenção a mobilias diferentes que estavam nos comodos. Você anda em direção para o quarto de Matheus, sem pestanejar, a saudade é grande.
         
    Parada na porta do quarto você bate três vez, você chama ele, mas ninguem responde... Um sintimento ruim invade sua cabeça, algo como uma paranoia, você sente que algo não está certo. Você lentamente gira maçaneta e lentamente você empurra a porta... Por um segundo, alívio, Matheus estava lá, mas rapidamente esse alívio é substuido por um olhar de terror e lá você vê Matheus morto.
         ");

            Console.WriteLine($"Frente a uma casa grande você se encherga pequena, você tá feliz, pois finalmente irá ve-lo.");
            Console.ReadLine();
            
            Console.WriteLine($"Você estava no Canada fazendo intercambio, mas agora você está aqui, frente a casa do seu Namorado Matheus.");
            Console.ReadLine();
            
            
            
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
                s1.StatusVida();
            }
        
            break;
        case ConsoleKey.D2:
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Escolha qual parte você parou e digite a senha da Rota/Escolha");

            Console.WriteLine($"######-Primeiramente Matheus está vivo/morto?-######");
            estado = Console.ReadLine();
            

             while (estado != "morto" && estado != "vivo")
            {
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Não sei o que você escreveu, mas Matheus está ali. ESCREVA O DESTINO DE MATHEU ");

                    estado = Console.ReadLine().ToLower();
                }


            }
            if(estado == "morto")
            {
                Console.WriteLine(@$" 
                        Matheus está morto. Você o matou. A namorada dele está o perseguindo. 
                                        Qual rota você quer começar 
                                        (Para entrar na rota escreva a senha dela)

                                    1 - Fugir (#####)
                                    2 - Conversa com 'ela' (#######)
                                    3 - Esconder (#####)
                                    4 - Sai na Porrada (#####)
                        ");

                        string senha1 = Console.ReadLine().ToLower();
                        
                        if(senha1 == "20933")
                        {
                            Console.WriteLine(@$"
                            Você quer começar pela rota Fuga ou ir para outras rotas

                                (1) - Começar pela rota fuga
                                (2) - Outras rotas 
                            ");
                            ConsoleKeyInfo escolha2;
                            escolha2 = Console.ReadKey(true);
                        
                            if(escolha2.Key == ConsoleKey.D1)
                            {
                                f1.fuigr();
                            }
                            else if(escolha2.Key == ConsoleKey.D2)
                            {
                                Console.WriteLine($"Em desenvolvimento");
                            }
                            
                        }
                        else if(senha1 =="empatia")
                        {
                                                       Console.WriteLine(@$"
                            Você quer começar pela rota 'Conversar com ela' ou ir para outras rotas

                                (1) - Começar pela rota Conversa com ela
                                (2) - Outras rotas 
                            ");

                            ConsoleKeyInfo escolha3;
                            escolha3 = Console.ReadKey(true); 

                             if(escolha3.Key == ConsoleKey.D1)
                            {
                                c1.Taliking();
                            }
                            else if(escolha3.Key == ConsoleKey.D2)
                            {
                                Console.WriteLine($"Em desenvolvimento");
                            }    
                        }
                        else if(senha1 == "89031")
                        {
                                                           Console.WriteLine(@$"
                            Você quer começar pela rota 'Escondido' ou ir para outras rotas

                                (1) - Começar pela rota Escondido
                                (2) - Outras rotas 
                            ");

                            ConsoleKeyInfo escolha4;
                            escolha4 = Console.ReadKey(true); 

                             if(escolha4.Key == ConsoleKey.D1)
                            {
                                r1.RotaEsconder();
                            }
                            else if(escolha4.Key == ConsoleKey.D2)
                            {
                                Console.WriteLine(@$"
                                            Onde você quer se esconder?
                                    (1) - Sua casa (####)
                                    (2) - Casa Abandonada (####)
                                    (3) - Casa de Matheus (####)
                                            ");
                                     ConsoleKeyInfo SubEscolha4;
                                    SubEscolha4 = Console.ReadKey(true);        

                                    if(SubEscolha4.Key == ConsoleKey.D1)
                                    {

                                        Console.WriteLine(@$"
                                              (1) - Sua casa 
                                            Digite a senha:(####)
                                        ");
                                        string senha2 = Console.ReadLine();
                                        if(senha2 == "1590")
                                        {
                                           r2.casa(); 
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Senha errada!");
                                            
                                        }
                                    }
                                    else if(SubEscolha4.Key == ConsoleKey.D2)
                                    {
                                        Console.WriteLine(@$"
                                            (2) - Casa Abandonada 
                                            Digite a senha:(####)
                                        ");
                                        string senha2 = Console.ReadLine();
                                        if(senha2 == "3201")
                                        {
                                           r3.CasaAbandonada(); 
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Senha errada!");
                                            
                                        }
                                    }
                                    else if(SubEscolha4.Key == ConsoleKey.D3)
                                    {
                                        Console.WriteLine(@$"
                                            (3) - Casa de Matheus 
                                            Digite a senha:(####)
                                        ");
                                        string senha2 = Console.ReadLine();
                                        if(senha2 == "5402")
                                        {
                                           r4.CasaMatheus(); 
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Senha errada!");
                                            
                                        }
                                    }
                            }    
                        }
                        else if(senha1 == "Punch")
                        {
                            p1.Punching();
                        }
            }

            Console.ResetColor();
            break;
        case ConsoleKey.D0:
            Console.WriteLine($"Tchau!!!");

            break;
        default:
            break;
    }
}
while (opcoes.Key != ConsoleKey.D0);











