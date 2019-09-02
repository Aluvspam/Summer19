using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ScissorsPaperRockGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            int count = 0;
            int count1 = 0;

            //ConsoleColor background = Console.BackgroundColor;
            //ConsoleColor foreground = Console.ForegroundColor;

            Console.WindowHeight = 30;
            Console.WindowWidth = 90;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine(Console.WindowHeight);
            //Console.WriteLine(Console.WindowWidth);

            Console.WriteLine("\t\t\t\tROCK-PAPER-SCISSORS GAME                                                                ");
            Console.WriteLine("\t\t\t\t\tWELCOME!                                                                        ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;


            while (answer != "N")
            {
                Console.WriteLine("Acestea sunt variantele:\n1->PIATRA\n2->HARTIE\n3->FOARFECA");
                string[] choices = new string[3] { "PIATRA", "HARTIE", "FOARFECA" };

                Random rnd = new Random();
                int n = rnd.Next(0, 3);

                Console.WriteLine();
                Console.Write("Introduceti o varianta:\t");

                string user = Console.ReadLine().ToUpper();

                if (user == "1")
                    user = "PIATRA";
                else if (user == "2")
                    user = "HARTIE";
                else if (user == "3")
                    user = "FOARFECA";
                else
                {
                    Console.WriteLine("Nu ati introdus o varianta corecta. \nJocul se va inchide.");
                    Console.ReadKey();
                    return;
                }


                if (user == "PIATRA" && choices[n] == "FOARFECA")
                {
                    Console.WriteLine();
                    Console.WriteLine("Tu ai ales: \t   " + user);
                    Console.WriteLine("Computerul a ales: " + choices[n]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t\t\t\tAi castigat runda!");
                    Console.ForegroundColor = ConsoleColor.Black;
                    count += 1;
                }
                else if (user == "PIATRA" && choices[n] == "HARTIE")
                {
                    Console.WriteLine();
                    Console.WriteLine("Tu ai ales: \t   " + user);
                    Console.WriteLine("Computerul a ales: " + choices[n]);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\tAi pierdut runda!");
                    Console.ForegroundColor = ConsoleColor.Black;
                    count1 += 1;
                }
                else if (user == "HARTIE" && choices[n] == "PIATRA")
                {
                    Console.WriteLine();
                    Console.WriteLine("Tu ai ales: \t   " + user);
                    Console.WriteLine("Computerul a ales: " + choices[n]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t\t\t\tAi castigat runda!");
                    Console.ForegroundColor = ConsoleColor.Black;
                    count += 1;
                }
                else if (user == "HARTIE" && choices[n] == "FOARFECA")
                {
                    Console.WriteLine();
                    Console.WriteLine("Tu ai ales: \t   " + user);
                    Console.WriteLine("Computerul a ales: " + choices[n]);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\tAi pierdut runda!");
                    Console.ForegroundColor = ConsoleColor.Black;

                    count1 += 1;
                }
                else if (user == "FOARFECA" && choices[n] == "PIATRA")
                {
                    Console.WriteLine();
                    Console.WriteLine("Tu ai ales: \t   " + user);
                    Console.WriteLine("Computerul a ales: " + choices[n]);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\tAi pierdut runda!");
                    Console.ForegroundColor = ConsoleColor.Black;
                    count1 += 1;
                }
                else if (user == "FOARFECA" && choices[n] == "HARTIE")
                {
                    Console.WriteLine();
                    Console.WriteLine("Tu ai ales: \t   " + user);
                    Console.WriteLine("Computerul a ales: " + choices[n]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t\t\t\tAi castigat runda!");
                    Console.ForegroundColor = ConsoleColor.Black;
                    count += 1;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Tu ai ales: \t   " + user);
                    Console.WriteLine("Computerul a ales: " + choices[n]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t\t\t\t(Remiza.)");
                    Console.ForegroundColor = ConsoleColor.Black;

                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                Console.Write("Vrei sa mai joci o runda? (apasa orice tasta pentru DA sau n pentru NU)                                                 ");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                answer = Console.ReadLine().ToUpper();
            } 

            Console.WriteLine("Tu ai castigat:        " + count + " runde");
            Console.WriteLine("Computerul a castigat: " + count1 + " runde");

            if (count > count1)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t\t\tFELICITARI, AI CASTIGAT MECIUL!  :)                           ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else if (count < count1)
                Console.WriteLine("\t\t\t\tMai invata.. ");
            else
                Console.WriteLine("Egalitate.");

            //Console.WriteLine("Consola se va inchide in 5 secunde");
            //Thread.Sleep(5000);
            Console.Write("Apasa enter pentru a inchide consola.");
            Console.ReadKey();


        }
    }
}
