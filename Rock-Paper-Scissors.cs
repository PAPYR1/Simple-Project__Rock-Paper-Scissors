const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";
Console.Write("Chose [r]ock, [p]aper or [s]cissors: ");
string PlayerMove = Console.ReadLine().ToLower();
while (PlayerMove != Rock && PlayerMove != Paper && PlayerMove != Scissors)
{
    if (PlayerMove == "r" || PlayerMove == "rock" )
    {
        PlayerMove = Rock;
    }
    else if (PlayerMove == "p" || PlayerMove == "paper")
    {
        PlayerMove = Paper;
    }
    else if (PlayerMove == "s" || PlayerMove == "scissors")
    {
        PlayerMove = Scissors;
        
    }
    else
    {
        Console.WriteLine("Invalid Input. Try Again...");
        PlayerMove = Console.ReadLine();
    }
}
Random RNG = new Random();
int computerRandomNumber = RNG.Next(1, 4);
string computerMove = "";
switch (computerRandomNumber)
{
    case 1:
        computerMove = Rock;
        break;
    case 2:
        computerMove = Paper;
        break;
    case 3:
        computerMove = Scissors;
        break;
}
Console.WriteLine($"The computer chose {computerMove}");
if (PlayerMove == Rock && computerMove == Scissors ||
    PlayerMove == Paper && computerMove == Rock ||
    PlayerMove == Scissors && computerMove == Paper)
{
    Console.WriteLine("You win.");
}
else if (PlayerMove == Rock && computerMove == Rock||
    PlayerMove == Paper && computerMove == Paper ||
    PlayerMove == Scissors && computerMove == Scissors)
{
    Console.WriteLine("Draw.");
}
else if (PlayerMove == Rock && computerMove == Paper ||
    PlayerMove == Paper && computerMove == Scissors ||
    PlayerMove == Scissors && computerMove == Rock)
{
    Console.WriteLine("You lose.");
}
else
{
    Console.WriteLine("This game was a draw");
}
