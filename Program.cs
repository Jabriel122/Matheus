using MAtheus;


int morto = 0;
int vivo = 1;
int satisfeito = 2;
int StateVc = vivo;

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
                        Console.WriteLine(@$"A onde você quer se esconder?
            Opções:

            1 - Casa
            2 - Casa Abandonada
            3 - Casa de Matheus 
            ");

                        ConsoleKeyInfo EsconderEscolha;
                        EsconderEscolha = Console.ReadKey(true);

                        switch (EsconderEscolha.Key)
                        {
                            case ConsoleKey.D1:
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

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Ela está dentro da sua casa, você sente isso. Sua respiração fica pesada e sua boca fica seca. Algo precisa ser feito o que pretende fazer?");
                                Console.WriteLine($"");
                                Console.WriteLine($"1 - Se equipar e atacar ela");
                                Console.WriteLine($"2 - Continua escondido");
                                Console.WriteLine($"3 - Fugir");
                                Console.ResetColor();

                                ConsoleKeyInfo oQueFazer;
                                oQueFazer = Console.ReadKey(true);

                                switch (oQueFazer.Key)
                                {
                                    case ConsoleKey.D1:
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine($"Você encontra um estile no seu quarto. Você pega. Volta a se esconde do armário e espera ela.");
                                        Console.ResetColor();

                                        Console.WriteLine($"");
                                        Barra.BarraCarregamento("Passagem de tempo", 3, 300);
                                        Console.WriteLine($"");

                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine($"...");
                                        Console.WriteLine($"*Tchuk *tchuk (barulho de passos)");

                                        Console.ReadLine();
                                        Console.WriteLine($"...");
                                        Console.WriteLine($"*Nheeeuu (Barulho da porta abrindo)");
                                        Console.WriteLine($"Ela está dentro do seu quarto.");

                                        Console.ReadLine();
                                        Console.WriteLine($"Você prende a respiração e ouve os passos pesados dela.");

                                        Console.ReadLine();
                                        Console.WriteLine($"Ela não esconde sua presença, quer que saiba que está ali.");

                                        Console.ReadLine();
                                        Console.WriteLine($"Você lentamente sobe a lamina do estilete e se prepara");

                                        Console.ReadLine();
                                        Console.WriteLine($"Você se pergunta quando você pode atacar, se agora é a hora certa.");

                                        Console.ReadLine();
                                        Console.WriteLine($"O ideal é espera ela ficar de costa, mas não tem como saber se ela está de costa.");

                                        Console.ReadLine();
                                        Console.WriteLine($"Talvez o ideal seja espera ela abrir o armário");

                                        Console.ReadLine();
                                        Console.WriteLine($"Mas isso fária ela ter a oportunidade de me atacar.");

                                        Console.ReadLine();
                                        Console.WriteLine(@$"
                                                Atacar?
                                                (S/N)
                                ");
                                        string atacar = Console.ReadLine().ToLower();

                                        if (atacar == "sim" || atacar == "s" || atacar == "atacar")
                                        {
                                            Console.WriteLine($"Você não aguenta mais esperar.");
                                            Console.ReadLine();

                                            Console.WriteLine($"Numa epifania espôntania você abre a porta com tudo, junto a isso um grito sai de sua boca ");
                                            Console.ReadLine();

                                            Console.WriteLine($"Você levanta o braço que segura o estilete e mira nela.");
                                            Console.ReadLine();

                                            Console.WriteLine($"Mas...");
                                            Console.ReadLine();

                                            Console.WriteLine($"Antes de acerta, você sente algo na sua barriga");
                                            Console.ReadLine();

                                            Console.WriteLine($"Na sua barriga, tinha uma faca enfiada. Você vê a mulher na sua frente tirando a faca com tudo.");
                                            Console.ReadLine();

                                            Console.WriteLine($"Você está fraco. Muito sangue está saindo do seu corpo.");
                                            Console.ReadLine();

                                            Console.WriteLine($"Você vê ela falando algo, mas você não ouve. Você só sente");
                                            Console.ReadLine();

                                            Console.WriteLine($"Você sente várias coisa.. mas nada mais importa, pois tá muito frio.");
                                            Console.ReadLine();


                                            StateVc = morto;
                                        }

                                        else if (atacar == "não" || atacar == "n" || atacar == "Não atacar")
                                        {
                                            Console.WriteLine($"Você espera");
                                            Console.ReadLine();

                                            Console.WriteLine($"Sente que o momento certo para atacar ela será quando ela abrir o armário ");
                                            Console.ReadLine();

                                            Console.WriteLine($"Então, pacientemente você espera");
                                            Console.ReadLine();

                                            Console.WriteLine($"Ela te procura e você espera.");
                                            Console.ReadLine();

                                            Console.WriteLine($"Ouve-se ela, desesperadamente procurando você. Sua respiração pesada e passos firmes, ainda continuam os mesmo.");
                                            Console.ReadLine();

                                            Console.WriteLine($"Você sente, a qualquer momento ela vai abrir essa porta");
                                            Console.ReadLine();

                                            Console.WriteLine($"Você prepara a sua mente para atacar ela");
                                            Console.ReadLine();

                                            Console.WriteLine($"E agora, prepara o seu corpo");
                                            Console.ReadLine();

                                            Console.WriteLine($"Por um instante. Silêncio");
                                            Console.ReadLine();

                                            Console.WriteLine($"*Tchuk *Tchuk (Barulhos de passos)");
                                            Console.ReadLine();

                                            Console.WriteLine($"A porta se abre");
                                            Console.ReadLine();

                                            Console.WriteLine($"A Luz do seu quarto é tampada por uma silhueta de uma mulher");
                                            Console.ReadLine();

                                            Console.WriteLine($"Mesmo estando frente a ela, você percebe, ela não te vê");
                                            Console.ReadLine();

                                            Console.WriteLine($"Você se aproveita disso...");
                                            Console.ReadLine();

                                            Console.WriteLine($"Numa epifania espôntania você empurra ela com tudo no chão, junto a isso um grito sai de sua boca ");
                                            Console.ReadLine();

                                            Console.WriteLine($"Você levanta o braço que segura o estilete e mira nela.");
                                            Console.ReadLine();

                                            Console.WriteLine($"Ela, surpresa, se dabate contra você. Em movimento rápidos você prende ela usando suas pernas e braços");
                                            Console.ReadLine();

                                            Console.WriteLine($"Ela começa a grita e se desesperar, mas você não entende ela, pois a única coisa que você consegue pensar é acabar logo com isso.");
                                            Console.ReadLine();

                                            Console.WriteLine($"Então, você levanta o braço");
                                            Console.ReadLine();

                                            Console.WriteLine($"E se prepara para finalizar ela");
                                            Console.ReadLine();

                                            Console.WriteLine(@$"
                                                    Matar-lá?
                                                    (S/N)
                                    ");
                                            string esocolha2 = Console.ReadLine().ToLower();


                                            if (esocolha2 == "sim" || esocolha2 == "s" || esocolha2 == "matar")
                                            {
                                                Console.WriteLine($"Você enfia o seu estilete com tudo no pescoço dela");
                                                Console.ReadLine();

                                                Console.WriteLine($"A cena é horrosa, você vê ela aos poucos se engasgando com o próprio sangue.");
                                                Console.ReadLine();

                                                Console.WriteLine($"Lágrimas de despero começa a sair de seus olhos.");
                                                Console.ReadLine();

                                                Console.WriteLine($"O Sangue começa a se espalha no chão do seu quarto");
                                                Console.ReadLine();

                                                Console.WriteLine($"Ela morreu");
                                                Console.ReadLine();

                                                Console.WriteLine($"Satisfeito?");

                                                StateVc = satisfeito;
                                            }
                                            else if (esocolha2 == "não" || esocolha2 == "n" || esocolha2 == "Não Matar")
                                            {
                                                Console.WriteLine($"Você olha para ela");
                                                Console.ReadLine();

                                                Console.WriteLine($"Você reluta sobre matar ela");
                                                Console.ReadLine();

                                                Console.WriteLine($"Você sabe que deveria, mas não vái. Então.. Você fala");
                                                Console.ReadLine();

                                                Console.WriteLine($"'...Desculpa'");
                                                Console.ReadLine();

                                                Console.ResetColor();

                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine($"'Desculpa?'");
                                                Console.ReadLine();

                                                Console.WriteLine($"'Depois de matar o Matheus, você se desculpa??'");
                                                Console.ReadLine();

                                                Console.WriteLine($"'NÃO! NÃO! Eu não aceito suas desculpas!'");
                                                Console.ReadLine();
                                                Console.ResetColor();

                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine($"'... Entendo'");
                                                Console.ReadLine();

                                                Console.WriteLine($"'Sabe... Eu não queria matar ele.'");
                                                Console.ReadLine();

                                                Console.WriteLine($"'Eu não queria ter matado ele '");
                                                Console.ReadLine();

                                                Console.WriteLine($"'Mas tive que fazer isso'");
                                                Console.ReadLine();

                                                Console.WriteLine($"'Até porque, Matheus iria fazer o mesmo'");
                                                Console.ReadLine();

                                                Console.WriteLine($"'Você entende não?'");
                                                Console.ReadLine();

                                                Console.ResetColor();

                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine($"'...'");
                                                Console.ReadLine();

                                                Console.WriteLine($"'...Ele iria fazer mesmo?'");
                                                Console.ReadLine();

                                                Console.ResetColor();

                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine($"'... Sim'");
                                                Console.ReadLine();

                                                Console.ResetColor();

                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine($"'...'");
                                                Console.ReadLine();

                                                Barra.BarraCarregamento("Mudando Perspectiva", 8, 300);
                                                Console.WriteLine($"");
                                                Console.ResetColor();

                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine($"Você veio aqui para matar o assassino do seu namorado");
                                                Console.ReadLine();

                                                Console.WriteLine($"Você queria uma batalha justa, se vinga, matar aquele que matou a sua pessoa amada");
                                                Console.ReadLine();

                                                Console.WriteLine($"Mas aquele que você quer matar, pede por perdão e não parece que vai revidar");
                                                Console.ReadLine();

                                                Console.WriteLine($"Você se sente frustrada");
                                                Console.ReadLine();

                                                Console.WriteLine($"Você pega a faca ,que estava derrubada no chão.");
                                                Console.ReadLine();

                                                Console.WriteLine($"E percebe, aqui você tem uma escolha");

                                                Console.WriteLine($@"
                                                            Matar ele?
                                                            (S)/(N)
                                        ");
                                                Console.ResetColor();
                                                string escolha3 = Console.ReadLine();

                                                if (escolha3 == "não" || escolha3 == "n" || escolha3 == "Não Matar")
                                                {
                                                    Console.ResetColor();

                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"'Me fala o porque!'");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"'Você me deve isso!'");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"...");
                                                    Console.ReadLine();

                                                    Console.ResetColor();

                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine($"...");
                                                    Console.ReadLine();


                                                    Console.WriteLine($"'Matheus iria me matar'");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"'Porque eu e ele estamos dentro de uma espécie de jogo'");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Não sei o objetivo do jogo, mas é Matar ou morrer'");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"'E se eu não matasse ele eu morreria, a mesma coisa com ele'");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Enquanto você tenta explicar a situação, você percebe uma coisa, uma picada no pulso");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"No seu pulso tinha uma pulseira");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Um liquído venenoso é espalhado no seu corpo");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Você sabe, em poucos segundos você irá morrer");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Eles estavam observando esse tempo todo");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Ouvindo tudo que você falava");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"É matar ou morrer");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Um jogo da morte");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"E em um jogo sempretem regras e você quebro ela");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"'...Dro-ga...'");
                                                    Console.ReadLine();

                                                    Console.ResetColor();

                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"'Ei!'");
                                                    Console.ReadLine();

                                                    Console.ResetColor();

                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine($"'Vá para casa abandonada, lá você entenderá o que vái acontecer a senha é essa: -2047-'");
                                                    Console.ReadLine();

                                                    Console.ResetColor();

                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"'O que?'");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"'Ei!'");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"'Acorda!'");
                                                    Console.ReadLine();

                                                    Console.ResetColor();

                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine($"Você sente sua vida se desvaindo");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Sua visão está toda embaçada");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"A mulher que estava com você meche sua boca, mas você não ouve nada");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Ela deixa você caido no chão ");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"E sai do seu campo de visão");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"A morte está vindo");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Alguns segundos se passam");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"E quando menos você esperava");
                                                    Console.ReadLine();

                                                    StateVc = morto;


                                                }
                                                else if (escolha3 == "sim" || escolha3 == "s" || escolha3 == "Matar")
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine($"Você segura a faca com firmeza");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"E lembra de ver o corpo de Matheus no chão");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Você se lembra do mar vermelho que o Matheus estava em cima");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Você lembra da dor que é perder alguém importante");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Você quer vingança");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Queria que fosse me circunstancias diferentes, mas isso não importa");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Essa é a melhor oportunidade de se livrar dele.");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Você posiciona o seu corpo em uma posição de ataque");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Um barulho alto sai da sua boca");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Você sente a suas cordas bocais tremendo");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"E quando você vê");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"O momento de impacto aconteceu, A faca foi enfiada no peito dele");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Você por um momento se assustou, mas, com uma frieza rasga a pele dele, como se fosse papelão");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"O homem a sua frente grita de agunia");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Ele chora");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Parece que está tendo dificulade para respirar");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Você tira a faca");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Um pouco de sangue espirra em sua cara");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Você vê o mesmo mar de sangue que viu antes");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Você se sente bem");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Mas depois não sente nada");
                                                    Console.ReadLine();

                                                    Console.ResetColor();

                                                    Barra.BarraCarregamento("Mudando Perspectiva", 8, 300);
                                                    Console.WriteLine($"");
                                                    Console.ForegroundColor = ConsoleColor.Green;

                                                    Console.WriteLine($"Seus últimos momentos foi dolorido");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"A menina sua frente olha para você assustada");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Ela parece está chorando, parecia que não tinha percibido");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Ela se assusta com suas lagrimas e sai correndo do quarto");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"No fim su visão fica embaçada");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Tudo fica frio");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Você já não encherga mais nada");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"E não sente mais nada");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Poucos segundos se passa");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Ai você percebe");
                                                    Console.ReadLine();

                                                    Console.ResetColor();

                                                    StateVc = morto;
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;

                                                    Console.WriteLine($"Você não se entende mais");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Depois de tanto caos");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Depois de tentar ter vingança");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Você não se entende mais");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Nada o que você quer faz sentido");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Eu queria matar ele, mas não tinha certeza o que fazer. Eu tinha que responder 'Sim' ou 'Não'. Mas respondi {escolha3}.");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Não sei o que fazer");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Você decide pegar a faca");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"Mata o homem a sua frente");
                                                    Console.ReadLine();

                                                    Console.WriteLine($"E se mata");
                                                    Console.ReadLine();

                                                    Console.ResetColor();

                                                    StateVc = morto;
                                                }
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;

                                                Console.WriteLine($"Escolha errada, vulgo, não existe.");
                                                Console.ReadLine();

                                                Console.WriteLine($"Sua cabeça começa a ser sugada por algo, você sente uma enorme pressão na cabeça");
                                                Console.ReadLine();

                                                Console.WriteLine($"Você sente o molhado no seus ouvidos...");
                                                Console.ReadLine();

                                                Console.WriteLine($"Você ouve: 'Escolha certo na próxima vez'");
                                                Console.ReadLine();

                                                Console.WriteLine($"Sua cabeça explode");
                                                Console.ReadLine();

                                                StateVc = morto;
                                            }


                                        }

                                        else
                                        {

                                            Console.ForegroundColor = ConsoleColor.Green;

                                            Console.WriteLine($"Escolha errada, vulgo, não existe.");
                                            Console.ReadLine();

                                            Console.WriteLine($"Sua cabeça começa a ser sugada por algo, você sente uma enorme pressão na cabeça");
                                            Console.ReadLine();

                                            Console.WriteLine($"Você sente o molhado no seus ouvidos...");
                                            Console.ReadLine();

                                            Console.WriteLine($"Você ouve: 'Escolha certo na próxima vez'");
                                            Console.ReadLine();

                                            Console.WriteLine($"Sua cabeça explode");
                                            Console.ReadLine();

                                            StateVc = morto;

                                        }








                                        Console.ResetColor();




                                        break;
                                    case ConsoleKey.D2:
                                        {
                                            Console.WriteLine($" Você decide continuar escondido");
                                            Console.ReadLine();

                                            Console.WriteLine($"O armário é muito claustrofobico ");
                                            Console.ReadLine();

                                            Console.WriteLine($"Mas você de alguma maneira consêgue se infia entre as roupas");
                                            Console.ReadLine();

                                            Console.WriteLine($"Alguns segundos se passa ");




                                            break;
                                        }
                                    case ConsoleKey.D3:
                                        {


                                            break;
                                        }
                                    default:
                                        break;
                                }






                                Console.ResetColor();
                                break;
                            case ConsoleKey.D2:


                                break;
                            case ConsoleKey.D3:


                                break;

                            default:
                                break;
                        }



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

                StateVc = morto;
            }

            // Status de vida 
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











