
static string RockPapperScissors()
{
    Random rnd = new Random();
    int k = rnd.Next(1, 3);
    string l = "I broke";
    switch (k)
    {
        case 1: return "Paper";
        case 2: return "Rock";
        case 3: return "Scissors";
        default: return l;
    }

}
static void Statistic(int win, int lose) 
{
    Console.WriteLine($"Your stats wins:[{win}] lose[{lose}]");
}
Console.WriteLine("Rock ? Paper ? Scissors? Choose");
string Me = Convert.ToString(Console.ReadLine());
int win = 0;
int lose = 0;
while (Me == "Rock" || Me == "Paper" || Me == "Scissors" || Me != "Stop")
{
    string Robot = RockPapperScissors();
    Console.WriteLine(Robot);
    if (Robot == "Paper" && Me == "Scissors")
    {
        Console.WriteLine("You Won, Do you want again?");
        win++;
        string Answer = Console.ReadLine();
        if (Answer == "+")
        {

            Console.WriteLine("Rock ? Paper ? Scissors? Choose");
            string i = Convert.ToString(Console.ReadLine());
            Me = i;
            continue;
        }
        else
        {
            Statistic(win,lose);
            Console.WriteLine("Bye");
            break;
        }
    }
    else if (Robot == "Rock" && Me == "Paper")
    {
        Console.WriteLine("You Won, Do you want again?");
        win++;
        string Answer = Console.ReadLine();
        if (Answer == "+")
        {
            Console.WriteLine("Rock ? Paper ? Scissors? Choose");
            string i = Convert.ToString(Console.ReadLine());
            Me = i;
            continue;
        }
        else
        {
            Statistic(win, lose);
            Console.WriteLine("Bye");
            break;
        }
    }
    else if (Robot == "Scissors" && Me == "Rock")
    {
        Console.WriteLine("You Won, Do you want again?");
        win++;
        string Answer = Console.ReadLine();
        if (Answer == "+")
        {
            Console.WriteLine("Rock ? Paper ? Scissors? Choose");
            string i = Convert.ToString(Console.ReadLine());
            Me = i;
            continue;
        }
        else
        {
            Statistic(win, lose);
            Console.WriteLine("Bye");
            break;
        }
    }
    else if (Robot == Me)
    {
        Console.WriteLine("All Lose, Do you want again?");
        lose++;
        string Answer = Console.ReadLine();
        if (Answer == "+")
        {
            Console.WriteLine("Rock ? Paper ? Scissors? Choose");
            string i = Convert.ToString(Console.ReadLine());
            Me = i;
            continue;
        }
        else
        {
            Statistic(win, lose);
            Console.WriteLine("Bye");
            break;
        }
    }
    else 
    {
        Console.WriteLine("You Lose, Do you want again? + or -");
        lose++;
        string Answer = Console.ReadLine();
        if (Answer == "+")
        {
            Console.WriteLine("Rock ? Paper ? Scissors? Choose");
            string i = Convert.ToString(Console.ReadLine());
            Me = i;
            continue;
        }
        else
        {
            Statistic(win, lose);
            Console.WriteLine("Bye");
            break;
        }
    }
    

}

