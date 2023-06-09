Console.WriteLine("Bem-vindo(a) ao jogo Adivinha!");

Random segredo = new Random();
int numeroSorteado = 0;
numeroSorteado = Convert.ToInt32(segredo.Next(1, 100));

Console.WriteLine("Você terá 5 chances para chutar um número de 1 a 100. Digite um número! ");

int tentativas = 0;


while (tentativas < 5)
{
    int chute = int.Parse(Console.ReadLine());

    if (numeroSorteado == chute)
    {
        Console.WriteLine("Parabéns!! Você acertou o número, nosso número sorteado era " + numeroSorteado);
        Console.WriteLine("Fim de jogo!");
        break;
    }
    if (chute > numeroSorteado)
    {
        Console.WriteLine("Que pena, você errou. Tente chutar mais baixo!");
    }
    if (chute < numeroSorteado)
    {
        Console.WriteLine("Hum... Chutou muito baixo, tente um número mais alto!");
    }
    tentativas++;
}




