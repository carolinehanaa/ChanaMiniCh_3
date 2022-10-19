//Caroline Hana
//10-19-2022
/*Ask your name
Ask what time you woke up
Print out "Your name woke up today at time"
Peer Review- 
*/

Console.Clear();
string? playAgain = "yes";
while (playAgain == "yes" )

{

    string? myName, time;
    int number1;

    Console.WriteLine("Goodmorning, what is your name?");
    myName = Console.ReadLine();

    Console.WriteLine("What time did you wake up today?");
    time = Console.ReadLine();

    bool validNum = Int32.TryParse(time, out number1);

    if(!validNum){
        Console.WriteLine("Invalid Number");
        playAgain = "yes";
    }else
    {
    Console.WriteLine($"{myName} woke up today at {time}");
    }
    string? answer = "";
    while (answer != "yes" && answer != "no")
    {
        Console.WriteLine("Would you like to play again? (yes or no)");
        answer = Console.ReadLine();
        answer = answer.ToLower();
        if (answer == "yes")
        {
            playAgain = answer;
        }
        else if (answer == "no")
        {
            playAgain = answer;
        }
        else
        {
            Console.WriteLine("Invalid Answer");
        }

    }

}