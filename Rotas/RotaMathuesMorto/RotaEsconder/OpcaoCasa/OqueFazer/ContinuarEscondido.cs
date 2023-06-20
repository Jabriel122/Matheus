using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAtheus.Rotas.RotaMathuesMorto.RotaEsconder.OpcaoCasa.OqueFazer
{
    public class ContinuarEscondido : StatusDeVida
    {
        public void Escondido()
        {
            Console.WriteLine($" Você decide continuar escondido");
            Console.ReadLine();

            Console.WriteLine($" O armário é muito claustrofobico ");
            Console.ReadLine();

            Console.WriteLine($"Mas você de alguma maneira consêgue se infia entre as roupas");
            Console.ReadLine();

            Console.WriteLine($"Alguns segundos se passa ");
            Console.ReadLine();
            
            Console.WriteLine($"O tempo passa");
            Console.ReadLine();
            
            Console.WriteLine($"Ela demora");
            Console.ReadLine();

            Console.WriteLine($"Sua respiração está pesada, é como se uma pedra precionasse o seus pulmões ");
            Console.ReadLine();
            
            Console.WriteLine($"Com tempo passando, você percebe o clima abafado no armário, junto a isso você sente uma gota de suor na sua testa e percebe que ela escorrega pela a testa até a sua boca.");
            Console.ReadLine();
            
            Console.WriteLine($" O gosto salgado do suor te incomoda, mas isso não importa, o que importa é que a qualquer momento ela vai entrar no seu quarto");
            Console.ReadLine();
            
            Console.WriteLine($"A qualquer momento você ouvirá o barulho da porta se abrindo");
            Console.ReadLine();
            
            Console.WriteLine($"E quando você menos espera");
            Console.ReadLine();
            
            Console.WriteLine($"*NHÉÉ");
            Console.ReadLine();
            
            Console.WriteLine($"O barulho da porta se abrindo");
            Console.ReadLine();
            
            Console.WriteLine($"Você ouve os passos firmes dela e percebe só pelo o andar que não está ali para conversar");
            Console.ReadLine();
            
            Console.WriteLine($"Você percebe que ela está andando e revistando pelo o quarto");
            Console.ReadLine();
            
            Console.WriteLine($"Você sente que precisa dar uma olhada por uma fresta no armário");
            Console.ReadLine();

            Console.WriteLine($"Os passos parece distante no armário");
            
            
            Console.WriteLine(@$"
                        Olhar?
                        (S/N)
            ");

            string olhar1 = Console.ReadLine().ToUpper();

            if(olhar1 == "S")
            {
                Console.WriteLine($"Você abre com cuidado uma fresta no armário.");
                Console.ReadLine();
                
                Console.WriteLine($"Com a festa aberta você tenta olhar para fora do armário");
                Console.ReadLine();
                
                Console.WriteLine($"No ponto seu ponto de vista você não enxerga ela, mas sabe que ela está ali");
                Console.ReadLine();

                Console.WriteLine($"Você sabe que a porta está na direção onde ela não está, ou seja, no seu ponto de vista. Você não sabe onde ela está, mas da para correr para fora do quarto");
                
                Console.WriteLine(@$"
                        Correr para porta?
                              (S/N)
                ");
                string Correr1 = Console.ReadLine().ToUpper();
            
                if(Correr1 == "S")
                {

                }  
                else if (Correr1 == "N")
                {
                    Console.WriteLine($"Você fecha a fresta no armário com cuidado ");
                Console.ReadLine();
                
                Console.WriteLine($"Seus olhos estão fixo na porta e sua tomando o maior cuidado para a porta não abrir sozinha");
                Console.ReadLine();
                
                Console.WriteLine($"Seus ouvidos estão fixado nos sons dos passos dela");
                Console.ReadLine();
                
                Console.WriteLine($"Você sente que ela está mais próxima");
                Console.ReadLine();
                
                Console.WriteLine(@$"
                        Olhar?
                        (S/N)
                ");
                string olhar2 = Console.ReadLine().ToUpper();
                
                if(olhar2 == "S")
                {
                    Console.WriteLine($"Você novamente abre a porta do armário para fazer uma fresta");
                    Console.ReadLine();
                    
                    Console.WriteLine($"Pela fresta você tenta olhar");
                    Console.ReadLine();
                    
                    Console.WriteLine($"Você consegue ver a silhueta dela, ela está olhando para sua cama ");
                    Console.ReadLine();
                    
                    Console.WriteLine($"Ela está perto da porta");
                    Console.ReadLine();
                    
                    Console.WriteLine($"Você sente que se você sair agora para a porta terá que enfrentar ela de alguma forma");

                     Console.WriteLine(@$"
                        Correr para porta?
                              (S/N)
                ");
                    string Correr2 = Console.ReadLine().ToUpper();

                    if(Correr2 == "S")
                    {
                        
                    }
                    
                    
                    
                }             
                
                }
                
                
                
                
                
                
                
            }

            
            
            
            
            
            
            
            
            
            
                        
            
        }
    }
}