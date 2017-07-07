//@author Anjan Pandey

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        public static void Main(string[] args)
        {
            displayMenu();

            int userInput = Int32.Parse(Console.ReadLine());

            while (userInput >= 1 && userInput <= 3)
            {
                if (userInput == 1)
                {
                    diceGame(userInput);

                }

                else if (userInput == 2)
                {
                    Console.WriteLine(enteredTwo(userInput));
                    Console.WriteLine("The product of 2 and any other number is always EVEN!!!");
                }
                else 
                {
                    Console.WriteLine("Let's flip a coin..hey that's a game");
                    Console.WriteLine("This is a " + userInput + " step game!!!");
                    Console.WriteLine("If you guess it right, you will earn 1 point. You can earn maximum " + userInput + " points.");
                    Console.WriteLine("Here random number 1 is heads and 2 is tails..");
                    Console.WriteLine("Your total point/s was " + recursiveGame(userInput, 0) + " out of "+ userInput+".");

                }

                Console.WriteLine("Press '0' to exit. Press any key from '1' to '3' to PLAY ANOTHER GAME!!!");
                userInput = Int32.Parse(Console.ReadLine());
            }

            if (userInput == 0)
            {
                Console.WriteLine("Quitting the game!!!");
                System.Threading.Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Please follow the game rule !!!");
            }
        }

        public static void displayMenu()
        {

            Console.WriteLine("***********************************************************");
            Console.WriteLine("WELCOME TO THE FUNNY GAME!!!");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("Press '0' to exit. Press any key from '1' to '3' to PLAY!!!");
            Console.WriteLine("***********************************************************");
        }


        public static string enteredTwo(int val)
        {

            Console.WriteLine("You entered " + val + ".This is a multiplication game.");
            Console.WriteLine("Generating a random number from 0 to 100");
            System.Threading.Thread.Sleep(1000);
            Random randomObject = new Random();
            int ranNum = randomObject.Next(101);
            Console.WriteLine("Okay the number was " + ranNum);
            Console.WriteLine("Multiplying your number with random number..");
            int product = val * ranNum;

            return ("The answer was " + product + ".");
        }

        public static void diceGame(int value, int nextTry = 0)
        {

            Random randomObject = new Random();
            Console.WriteLine("This is a dice Game!!!");
            Console.WriteLine("Rolling the dice....");
            int ranNum = randomObject.Next(6) + 1;
            Console.WriteLine("The number was " + ranNum);

            if (value == ranNum)
            {

                Console.WriteLine("Hey you entered " + value + ", and the random number was also " + ranNum + ".");
                Console.WriteLine("YOU WON THE GAME....");
            }
            else
            {
                Console.WriteLine("Sorry you entered " + value + ", and the random number was " + ranNum + ".");
                Console.WriteLine("YOU LOSE THE GAME....");
                Console.WriteLine("Wanna try one more time. Enter 'yes' to play or 'no' to exit this game!!!");
                string reply = Console.ReadLine();
                if (reply == "yes")
                {
                    Console.WriteLine("Enter any key from '1' to '6' to PLAY!!!");
                    nextTry = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Rolling the dice....");
                    ranNum = randomObject.Next(6) + 1;
                    if (value == ranNum)
                    {

                        Console.WriteLine("Hey you entered " + nextTry + ", and the random number was also " + ranNum + ".");
                        Console.WriteLine("YOU WON THE GAME....");
                    }
                    else
                    {
                        Console.WriteLine("Sorry you entered " + nextTry + ", and the random number was " + ranNum + ".");
                        Console.WriteLine("YOU LOSE THE GAME AGAIN :(....");

                    }

                }
            }

        }
        /*******************************
         * This method use recursion to play "heads and tails." We have 3 recursive steps to decide a winner. 
         * 
         * @param input is the input of the user that decides number of rounds to play
         * @param points is the sum of point that a user earns at each recursive step
         * @return points is the total score of a match.
         * 
         *******************************/
        public static int recursiveGame(int input, int points)
        {

            if (input > 0)
            {
                Random randomObject = new Random();
                int ranNum = randomObject.Next(2) + 1;
                Console.WriteLine("Okay a number was generated.");
                Console.WriteLine("....heads or tails??");
                string store = Console.ReadLine();
                if (store == "head" && ranNum == 1)
                {
                    Console.WriteLine("You won the Game!!!");
                    points++;
                }
                else if (store == "tail" && ranNum == 2)
                {
                    Console.WriteLine("You won the Game!!!");
                    points++;
                }
                else if (store == "tail" && ranNum == 1)
                {
                    Console.WriteLine("You lose the Game!!!");
                }
                else if (store == "head" && ranNum == 2)
                {
                    Console.WriteLine("You lose the Game!!!");
                }
                return recursiveGame(input - 1, points);
            }

            else
            {
                Console.WriteLine("OK this is the end of this game!!!");
                return points;
            }
        }
        ///<summary>
        ///method overloading is a feature that allows a class to have two or more methods having same name
        /// if there argument lists are different. 
        /// </summary>

    }
}
