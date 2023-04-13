// Funções
Console.WriteLine(@$"
Esse aqui é Matheus

             [°-°]
              /|\
              / \
");

Console.WriteLine($"Matheus é um grande código, sei lá. O que aconteceu com Matheus, ele tá vivo ou morto?");
string estado = Console.ReadLine().ToLower();


while( estado != "morto" && estado !="vivo")
{
    {
     Console.WriteLine(@$"
    Não sei o que você escreveu, mas Matheus está ali. ESCREVA O DESTINO DE MATHEUS

             [°-°]
              /|\
              / \     ????
    ");
    estado = Console.ReadLine().ToLower();
    }
}

if( estado == "morto")
{
    Console.WriteLine(@$"
    Matheus morreu

             [*~*]
              /|\
              / \     Seu Monstro
    ");
}
else 
{
    Console.WriteLine(@$"
    Matheus está vivo

             [°W°]
              /|\
              / \     Obrigado!
    ");
}


    


