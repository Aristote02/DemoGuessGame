using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace GuessGame
{
    public class program
    {
        static void Main(string[] args)
        {
            string fullname;
            Console.WriteLine("Enter your fullname:");
            fullname = Console.ReadLine();
            Console.WriteLine("Hello " + fullname + "\n");

            int age;
            Console.WriteLine("Enter your age :");
            age = Convert.ToInt32(Console.ReadLine());

            // this condition will be executed only if the user's age is over 18
            if (age >= 18)
            {
                Console.WriteLine("Answer the Question below, you only have 3 chances to guess");

                int secretWord = 4;
                int guess = 2;
                // guess count gonna count how many time the user tried
                int guessCount = 0;

                //guess limit is set to three times, and that means the user got only 3 chances
                int guesslimit = 3;
                bool OutofGuesses = false;
                /* this while loop gonna keep executing as long as
                 the guess is not equal to a secretword and they are not out of guesses */
                Console.WriteLine("You have six eggs, you take 2, you bust 2 and you fried 2, how many eggs are left");
                while (guess != secretWord && !OutofGuesses)
                {

                    //the condition to see if the user is outta guesses
                    if (guessCount < guesslimit)
                    {

                        Console.Write("Enter guess number: ");

                        string s = Console.ReadLine();

                        try
                        {
                            guess = Int32.Parse(s);
                        }
                        catch
                        {
                            guess = 0;
                        }


                        guessCount++;
                    }
                    else
                    {
                        OutofGuesses = true;
                    }

                }

                if (OutofGuesses)
                {
                    Console.Write("You lose !" + "Thank you for playing , you can play another time");
                }
                else
                {
                    Console.Write("Congratulation,You win !");
                }

                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You are under 18 years old and not allowed to play !");
            }


        }
    }
}

