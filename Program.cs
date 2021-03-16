using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber= new Random();// Random number generator ranging from 1-3 
            int number;
            number = randomNumber.Next(1,4);            

            int userChoice = 0; 

            Welcome(); //prompts the menu to allow user to see which option he can choose
          
            UserDecision(userChoice, number); //method that updates userInput variable       
        }
        static void Welcome()
        {
            System.Console.WriteLine("Welcome to rock, paper, scissors!");
            System.Console.WriteLine("1: Rock" + "\n2: Paper" + "\n3: Scissors");
        }
        static void UserDecision(int userChoice, int number)
        {
            System.Console.WriteLine("Please type one of the corresponding numbers to make a selection");
            switch (Console.ReadLine())
            {
                case "1": //if user chooses 1 it give the value of 1 and shows user he has chosen rock
                    userChoice = 1;
                    System.Console.WriteLine("You have chosen rock");
                    ComputerDecision(userChoice, number); // calls the method for the users choice and number
                    break;
                case "2": //if user chooses 2 it gives the value of 2 and shows user he has chosen paper
                    userChoice = 2;
                    System.Console.WriteLine("You have chosen paper"); 
                    ComputerDecision(userChoice, number); // calls the method for the users choice and number
                    break; // returns the user choice
                case "3": //if user chooses 3 it gives the value of 3 and shows user he has chosen scissors
                    userChoice = 3;
                    System.Console.WriteLine("You have chosen scissors");
                    ComputerDecision(userChoice, number); // calls the method for the users choice and number
                    break; 
                default:
                    System.Console.WriteLine("Invalid Choice please choose 1-3"); //prompts user of invalid choice
                    break;
            }
        }
    
        static void ComputerDecision(int userChoice,int number) // allows user to see what choice the CPU made
        {
            if(number == 1) 
            {   
                System.Console.WriteLine("Cpu chooses Rock");
            }
            else if(number == 2)
            {
                System.Console.WriteLine("Cpu chooses Paper");
            }
            else
            {
                System.Console.WriteLine("Cpu chooses Scissors");
            }
            Winner(userChoice, number); // calls the method for winner
        }
            
        static void Winner(int userChoice, int number)
        {
            if (number %3 + 1 == userChoice) //If the remainder of cpu number divided by 3 +1 = userChoice user would win becuase 1(Rock) beats 3(Paper) etc.
            {
                System.Console.WriteLine("You Win");

            }
            else if(userChoice %3 + 1 == number) //same formula except cpu would win
            {
                System.Console.WriteLine("Computer Win");
            }
            else  //if they bot are the same choice its a tie
            {
                System.Console.WriteLine("Its a tie");
            }
        }
    }
}
