using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cows and Bulls Starter Framework Code

            static void Main(string[] args)
            {
                int numberOfCows = 0;
                int numberOfBulls = 0;
                int userGuess1 = 0;
                int userGuess2 = 0;
                int userGuess3 = 0;
                int userGuess4 = 0;
                int userAttempts = 0;
                Random random1 = new Random();
                int randomNumber1 = random1.Next(1, 9);
                Random random2 = new Random();
                int randomNumber2 = random2.Next(0, 9);
                Random random3 = new Random();
                int randomNumber3 = random3.Next(0, 9);
                Random random4 = new Random();
                int randomNumber4 = random4.Next(0, 9);

                Console.WriteLine("Please enter the FIRST digit to your random 4 digit number: ");
                userGuess1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the SECOND digit to your random 4 digit number: ");
                userGuess2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the THIRD digit to your random 4 digit number: ");
                userGuess3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the FOURTH digit to your random 4 digit number: ");
                userGuess4 = Convert.ToInt32(Console.ReadLine());
                userAttempts = userAttempts + 1;
                while (userGuess1 > 1 & userGuess1 < 9 & userGuess2 > 0 & userGuess2 < 9 & userGuess3 > 1 & userGuess3 < 9 & userGuess4 > 1 & userGuess4 < 9)
                {
                    Console.WriteLine("Please make sure your number is 4 digits long and enter the FIRST digit: ");
                    userGuess1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the SECOND digit to your random 4 digit number: ");
                    userGuess2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the THIRD digit to your random 4 digit number: ");
                    userGuess3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the FOURTH digit to your random 4 digit number: ");
                    userGuess4 = Convert.ToInt32(Console.ReadLine());
                    
                    while (numberOfBulls != 4)
                    {
                        if (userGuess1 == randomNumber1)
                        {
                            numberOfCows = numberOfCows + 1;
                        }
                        if (userGuess1 == randomNumber2)
                        {
                            numberOfCows = numberOfCows + 1;
                        }
                        if (userGuess1 == randomNumber3)
                        {
                            numberOfCows = numberOfCows + 1;
                        }
                        if (userGuess1 == randomNumber4)
                        {
                            numberOfCows = numberOfCows + 1;
                        }
                        if (userGuess2 == randomNumber1)
                        {
                            numberOfCows = numberOfCows + 1;
                        }
                        if (userGuess2 == randomNumber2)
                        {
                            numberOfCows = numberOfCows + 1;
                        }
                        if (userGuess2 == randomNumber3)
                        {
                            numberOfCows = numberOfCows + 1;
                        }
                        if (userGuess2 == randomNumber4)
                        {
                            numberOfCows = numberOfCows + 1;
                        }
                        if (userGuess3 == randomNumber1)
                        {
                            numberOfCows = numberOfCows + 1;
                        }
                        if (userGuess3 == randomNumber2)
                        {
                            numberOfCows = numberOfCows + 1;
                        }
                        if (userGuess3 == randomNumber3)
                        {
                            numberOfCows = numberOfCows + 1;
                        }
                        if (userGuess3 == randomNumber4)
                        {
                            numberOfCows = numberOfCows + 1;
                        }
                        if (userGuess4 == randomNumber1)
                        {
                                numberOfCows = numberOfCows + 1;
                        }
                        if (userGuess4 == randomNumber2)
                        {
                            numberOfCows = numberOfCows + 1;
                        }
                        if (userGuess4 == randomNumber3)
                        {
                            numberOfCows = numberOfCows + 1;
                        }
                        if (userGuess4 == randomNumber4)
                        {
                            numberOfCows = numberOfCows + 1;
                            Console.WriteLine("You have" + numberOfCows + "cow(s).");
                        }
                        if (userGuess1 == randomNumber1)
                        {
                                numberOfBulls = numberOfBulls + 1;
                        }
                        if ((userGuess2 == randomNumber2)
                        {
                                numberOfBulls = numberOfBulls + 1;
                        }
                        if (userGuess3 == randomNumber3)
                        {
                                numberOfBulls = numberOfBulls + 1;
                        }
                        if (userGuess4 == randomNumber4)
                        {
                                numberOfBulls = numberOfBulls + 1;
                                Console.WriteLine("You have" + numberOfBulls + "bull(s)");
                        }
                            Console.WriteLine("Would you like to give up? (say Y for yes, N for no)");
                            string userGiveUp = Console.ReadLine();
                            if (userGiveUp == "Y" || userGiveUp == "y")
                            {
                                Console.WriteLine("Thank you for playing! You took an overall of: " + userAttempts);
                                break;
                            }
                            if (userGiveUp == "N" || userGiveUp == "n")
                            {
                                Console.WriteLine("Please enter the FIRST digit to your random 4 digit number: ");
                                userGuess1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Please enter the SECOND digit to your random 4 digit number: ");
                                userGuess2 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Please enter the THIRD digit to your random 4 digit number: ");
                                userGuess3 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Please enter the FOURTH digit to your random 4 digit number: ");
                                userGuess4 = Convert.ToInt32(Console.ReadLine());
                                userAttempts = userAttempts + 1;
                            }
                        }
                    }
                }
            }
        }
    }
}
    }
}
    }
}
