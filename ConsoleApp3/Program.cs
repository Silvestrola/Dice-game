// See https://aka.ms/new-console-template for more information

using System.Globalization;

int pontuacao1 = 0, pontuacao2 = 0, rodada = 0;
string nome1, nome2, placar, ganhou = "";

Console.Write("Jogador 1 digite seu nome: ");
nome1 = Console.ReadLine();
Console.WriteLine();
Console.Write("Jogador 2 digite seu nome: ");
nome2 = Console.ReadLine();
Console.Clear();

while (true)
{
    placar = $"Placar: {nome1}  {pontuacao1}   |   {nome2}  {pontuacao2} \n"; Console.WriteLine(placar);
    
    Console.Write(nome1 + " aperte ENTER para girar o dado");
    Console.ReadLine(); 
    
    Random numAleatorio = new Random();
    int n1 = numAleatorio.Next(1, 7);
    Console.WriteLine("Número sorteado: " + n1 + "\n");

    Console.Write(nome2 + " aperte ENTER para girar o dado");
    Console.ReadLine();

    Random numAleatorio2 = new Random();
    int n2 = numAleatorio.Next(1, 7);
    Console.WriteLine("Número sorteado: " + n2 + "\n");

    Console.Write("Aperte ENTER para continuar");
    Console.ReadLine();

    Console.Clear();

    if (n1 > n2)
    {
        rodada++;
        pontuacao1++;
        ganhou = $"{nome1} você ganhou a {rodada}° rodada";
    }
    else if (n2 > n1)
    {
        rodada++;
        pontuacao2++;
        ganhou = $"{nome2} você ganhou a {rodada}° rodada";
    }
    else if (n1 == n2)
    {
        rodada++;
        ganhou = $"{nome1} e {nome2} vocês empataram na {rodada}° rodada";
    }
    
    placar = $"Placar: {nome1}  {pontuacao1}   |   {nome2}  {pontuacao2}\n"; Console.WriteLine(placar);

    if (pontuacao1 == 3 || pontuacao2 == 3){
        ganhou = "";
    }
    Console.Write(ganhou);
    if (pontuacao1 == 3){
        Console.Write(nome1 + " GANHOU\n");
        break;
    }
    else if (pontuacao2 == 3){
        Console.Write(nome2 + " GANHOU\n");
        break;
    }
    Console.WriteLine();
    Console.WriteLine("\nAperte ENTER para ir para proxíma rodada");
    Console.ReadLine();
    Console.Clear();
 }
