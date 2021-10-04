/* File Name: Week6Lab
 * Programmer: Nasi Bode
 * Problem Statement: Create a guessing game. Randomly get a number between 0-100, keep looping
 *  until you find the number. For each guess the program should say higher or lower if incorrect.
 *  If correct you should end the game and state how many guesses it took to find the right answer.
 *  Overall Plan: 
 *  1. Print welcoming message to the screen
 *  2. Generate a random number between 0 -100
 *  2.5 Create a counter for the amount of guesses (int value)
 *  3. Create a do while loop to loop through the user input
 *  4. Create if statement to determine if the user needs to go higher/lower to get the right answer
 *  5. Exit do-while loop when the correct guess is given
 *  6. Print to screen how many guesses it took to make
 */



using System;

namespace Week6Lab
{
    class Program
    {
        static void Main(string[] args)

        {
            //Print welcoming message to the screen
            Console.WriteLine("This is a guessing game! Guess a number between 0-100.\nLet's see how well you do!");
           
            //Generate random number
            Random Random = new Random();
            //make sure the random number is between 0-100
            int randomNum = Random.Next(0, 100);

            //create value for userInput
            int userInput;

            //create int variable for the amount of guess (counter)
            int amtGuesses = 0;

            //create do while loop 
            do
            {
                //prompt user to enter int value for guess
                Console.WriteLine("Guess a number: ");
                //convert value to int
                userInput = Convert.ToInt32(Console.ReadLine());

                //create if else loop to determine if they need to guess higher or lower
                if (userInput > randomNum)
                {
                    Console.WriteLine("Lower!");
                    //add 1 to the counter
                    amtGuesses++;
                }
                else
                {
                    Console.WriteLine("Higher!");
                    //add 1 to the counter
                    amtGuesses++;
                }

            } while (userInput != randomNum); //end loop when guess is correct
            //print the amount of tries the user took to guess the right number
            Console.WriteLine("It took you {0} tries to guess the right number!", amtGuesses);

        }
    }
}
