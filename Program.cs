using System;

namespace Quiz
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("What is your name?");
                string userName = Console.ReadLine();
                Console.WriteLine("Hi " + userName + ", nice to meet you!");

                Console.WriteLine("Do you know how to calculate? Yes or No");

                string yesNo = (Console.ReadLine());

                if (yesNo == "Yes")
                {
                    Console.WriteLine("OK. What is 2+2?");

                    int firstQ = Convert.ToInt32(Console.ReadLine());

                    if (firstQ == 4)
                    {
                        Console.WriteLine("Great!"); // HERE

                        Console.WriteLine("What is 5+10?");

                        int secondQ = Convert.ToInt32(Console.ReadLine());

                        if (secondQ == 15)
                        {
                            Console.WriteLine("Great!"); // HERE

                            Console.WriteLine("What is 150 - 143?");

                            int thirdQ = Convert.ToInt32(Console.ReadLine());

                            if (thirdQ == 7)
                            {
                                Console.WriteLine("Great!"); // HERE

                                Console.WriteLine("What is 14 * 5 " + userName + "?");

                                int fourthQ = Convert.ToInt32(Console.ReadLine());
                            
                                if (fourthQ == 70)
                                {
                                    Console.WriteLine("Great!"); // HERE

                                    Console.WriteLine("What is 16 times 8?");

                                    int fifthQ = Convert.ToInt32(Console.ReadLine());

                                    if (fifthQ == 128)
                                    {
                                        Console.WriteLine("Great!");  // HERE

                                        Console.WriteLine("What is 200 divided by 50?");

                                        int sixthQ = Convert.ToInt32(Console.ReadLine());

                                        if (sixthQ == 4)
                                        {
                                            Console.WriteLine("Correct!"); // HERE

                                            Console.WriteLine("What is 2^10");

                                            int seventhQ = Convert.ToInt32(Console.ReadLine());

                                            if (seventhQ == 1024)
                                            {
                                                Console.WriteLine("Excellent!"); // HERE

                                                Console.WriteLine("What is ummm... 2(2x + 3y)? Don't take it to the simplest form :)");
                                                Console.WriteLine("Example answer: 1x + 1y");

                                                string eightQ = (Console.ReadLine());

                                                if (eightQ == "4x + 6y")
                                                {
                                                    Console.WriteLine("Splendid!"); // HERE

                                                    Console.WriteLine("What is the root of 25?");

                                                    int ninethQ = Convert.ToInt32(Console.ReadLine());

                                                    if (ninethQ == 5)
                                                    {
                                                        Console.WriteLine("Marvelous!"); // HERE

                                                        Console.WriteLine("And the time has come for the last question...");

                                                        Console.WriteLine("Are you ready for the  Yes or No");

                                                        string yesNo2 = (Console.ReadLine());

                                                        if (yesNo2 == "Yes")
                                                        {
                                                            Console.WriteLine("Well... What is 14 times 3 divided by 7 to the power of 2? ((14 * 3) / 7)^2");

                                                            int tenthQ = Convert.ToInt32(Console.ReadLine());

                                                            if (tenthQ == 36)
                                                            {
                                                                Console.WriteLine("OMG! YOU DID IT! YOU COMPLETED THE QUIZ!");
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Unfortnately, that is the wrong answer...");
                                                            }

                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("I'm sorry to hear that " + userName);
                                                        }

                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("No, That is the wrong answer " + userName);
                                                    }

                                                }
                                                else
                                                {
                                                    Console.WriteLine("No, That is the wrong answer " + userName);
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("No, That is the wrong answer " + userName);
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("No, That is the wrong answer " + userName);
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("No, That is the wrong answer " + userName);
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("No, That is the wrong answer " + userName);
                                }

                            }
                            else
                            {
                                Console.WriteLine("No, That is the wrong answer " + userName);
                            }

                        }
                        else
                        {
                            Console.WriteLine("No, That is the wrong answer " + userName);
                        }

                    }
                    else
                    {
                        Console.WriteLine("No, That is the wrong answer " + userName);
                    }

                }
                else
                {
                    Console.WriteLine("SAY GOODBYE!");
                }

            Console.ReadKey();
            
            }
        }
    }

    

