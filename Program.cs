using System.ComponentModel.Design.Serialization;
namespace lab_01;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the greatest Rock, Paper, Scissors game ever!!");
        Console.WriteLine("");
        Console.WriteLine("Do you have what it takes to defeat the all mighty computer?");
        Console.WriteLine("");      
        Console.WriteLine("The instructions are very simple, input R for Rock, P for Paper and S for Scissors.");
        Console.WriteLine("");
        Console.WriteLine("What will it be, Rock, Paper, or Scissors?");
        Console.WriteLine("");
       
        bool keepPlaying = true; //I tried running a loop but i kept getting an issue } was underlined red and wouldnt run on the bottom when trying to implement bool do {}.
        char selection = 'y';


        string[] choice = new string[] { "R", "P", "S" }; //giving user option to pick between Rock, Paper or Scissors
        Random pick = new Random();
        int num = pick.Next(1, 3);
        string userInput = Console.ReadLine().ToUpper(); // even if the user inputs lowercase letters it will still work
        string compInput = choice[num];

        Console.WriteLine("");

        string message = ("The computer played " + compInput + ","); // indicates what the computer has played
        string playerWon = message + " and lets go! You won! :)"; 
        string playerLost = message + " and you have lost! :(";
        string playerDraw = message + " and it was a tie! :/";

        // User pick Rock
        if (userInput == "R" && compInput == "R")  // if both picked rock
        Console.WriteLine(playerDraw);
        
        else if (userInput == "R" && compInput == "P") // if user picked rock and computer picked paper
        Console.WriteLine(playerLost);

        else if (userInput == "R" && compInput == "S") // if user picked rock and computer picked scissor
        Console.WriteLine(playerWon);

        // User pick Paper
        else if (userInput == "P" && compInput == "R") // if user picked paper and computer picked Rock
        Console.WriteLine(playerWon);

        else if (userInput == "P" && compInput == "P") // if both picked paper
        Console.WriteLine(playerDraw);

        else if (userInput == "P" && compInput == "S") // if user picked paper and computer picked scissors
        Console.WriteLine(playerLost);

        // User pick Scissor
        else if (userInput == "S" && compInput == "R") // if user picked scissor and computer picked rock
        Console.WriteLine(playerLost);
       
        else if (userInput == "S" && compInput == "P") // if user picked scissor and computer picked paper
        Console.WriteLine(playerWon);

        else if (userInput == "S" && compInput == "S") // if both picked scissor
        Console.WriteLine(playerDraw);
        

    }

  
  

   } 





    


        

    

