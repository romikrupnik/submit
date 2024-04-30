using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace פסח
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor originalForeground = Console.ForegroundColor; // keeping the original color
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\r\n    ~ ___       __   _______   ___       ________  ________  _____ ______   _______           _________  ________     ~\r\n    ~|\\  \\     |\\  \\|\\  ___ \\ |\\  \\     |\\   ____\\|\\   __  \\|\\   _ \\  _   \\|\\  ___ \\         |\\___   ___\\\\   __  \\    ~\r\n    ~\\ \\  \\    \\ \\  \\ \\   __/|\\ \\  \\    \\ \\  \\___|\\ \\  \\|\\  \\ \\  \\\\\\__\\ \\  \\ \\   __/|        \\|___ \\  \\_\\ \\  \\|\\  \\   ~\r\n    ~ \\ \\  \\  __\\ \\  \\ \\  \\_|/_\\ \\  \\    \\ \\  \\    \\ \\  \\\\\\  \\ \\  \\\\|__| \\  \\ \\  \\_|/__           \\ \\  \\ \\ \\  \\\\\\  \\  ~\r\n    ~  \\ \\  \\|\\__\\_\\  \\ \\  \\_|\\ \\ \\  \\____\\ \\  \\____\\ \\  \\\\\\  \\ \\  \\    \\ \\  \\ \\  \\_|\\ \\           \\ \\  \\ \\ \\  \\\\\\  \\ ~\r\n    ~   \\ \\____________\\ \\_______\\ \\_______\\ \\_______\\ \\_______\\ \\__\\    \\ \\__\\ \\_______\\           \\ \\__\\ \\ \\_______\\~\r\n    ~    \\|____________|\\|_______|\\|_______|\\|_______|\\|_______|\\|__|     \\|__|\\|_______|            \\|__|  \\|_______|~\r\n    ~                                                                                                                 ~\r\n    ~                                                                                                                 ~\r\n    ~                                                                                                                 ~\r\n    ~     ________ ________  ________  ________ _________  ___  ________  ________   ________                         ~\r\n    ~    |\\  _____\\\\   __  \\|\\   __  \\|\\   ____\\\\___   ___\\\\  \\|\\   __  \\|\\   ___  \\|\\   ____\\                        ~\r\n    ~    \\ \\  \\__/\\ \\  \\|\\  \\ \\  \\|\\  \\ \\  \\___\\|___ \\  \\_\\ \\  \\ \\  \\|\\  \\ \\  \\\\ \\  \\ \\  \\___|_                       ~\r\n    ~     \\ \\   __\\\\ \\   _  _\\ \\   __  \\ \\  \\       \\ \\  \\ \\ \\  \\ \\  \\\\\\  \\ \\  \\\\ \\  \\ \\_____  \\                      ~\r\n    ~      \\ \\  \\_| \\ \\  \\\\  \\\\ \\  \\ \\  \\ \\  \\____   \\ \\  \\ \\ \\  \\ \\  \\\\\\  \\ \\  \\\\ \\  \\|____|\\  \\                     ~\r\n    ~       \\ \\__\\   \\ \\__\\\\ _\\\\ \\__\\ \\__\\ \\_______\\  \\ \\__\\ \\ \\__\\ \\_______\\ \\__\\\\ \\__\\____\\_\\  \\                    ~\r\n    ~        \\|__|    \\|__|\\|__|\\|__|\\|__|\\|_______|   \\|__|  \\|__|\\|_______|\\|__| \\|__|\\_________\\                   ~\r\n    ~                                                                                  \\|_________|                   ~\r\n    ~                                                                                                                 ~\r\n    ~                                                                                                                 ~\r\n    ~ ________  ________  ___       ________  ___  ___  ___       ________  _________  ________  ________             ~\r\n    ~|\\   ____\\|\\   __  \\|\\  \\     |\\   ____\\|\\  \\|\\  \\|\\  \\     |\\   __  \\|\\___   ___\\\\   __  \\|\\   __  \\            ~\r\n    ~\\ \\  \\___|\\ \\  \\|\\  \\ \\  \\    \\ \\  \\___|\\ \\  \\\\\\  \\ \\  \\    \\ \\  \\|\\  \\|___ \\  \\_\\ \\  \\|\\  \\ \\  \\|\\  \\           ~\r\n    ~ \\ \\  \\    \\ \\   __  \\ \\  \\    \\ \\  \\    \\ \\  \\\\\\  \\ \\  \\    \\ \\   __  \\   \\ \\  \\ \\ \\  \\\\\\  \\ \\   _  _\\          ~\r\n    ~  \\ \\  \\____\\ \\  \\ \\  \\ \\  \\____\\ \\  \\____\\ \\  \\\\\\  \\ \\  \\____\\ \\  \\ \\  \\   \\ \\  \\ \\ \\  \\\\\\  \\ \\  \\\\  \\|         ~\r\n    ~   \\ \\_______\\ \\__\\ \\__\\ \\_______\\ \\_______\\ \\_______\\ \\_______\\ \\__\\ \\__\\   \\ \\__\\ \\ \\_______\\ \\__\\\\ _\\         ~\r\n    ~    \\|_______|\\|__|\\|__|\\|_______|\\|_______|\\|_______|\\|_______|\\|__|\\|__|    \\|__|  \\|_______|\\|__|\\|__|        ~\r\n    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.ReadLine();
            Console.Clear();

            Console.ForegroundColor = originalForeground; // back the original color



            Console.WriteLine("1 Reducing");
            Console.WriteLine("2 Adding");
            Console.WriteLine("3 subtracting");
            Console.WriteLine("4 multiplying");
            Console.WriteLine("5 dividing");
            Console.WriteLine("6 Exit");

            Console.WriteLine("Hello,please choose from the options");


            int lineToMark = int.Parse(Console.ReadLine());
            ConsoleColor originalForegroundColor = Console.ForegroundColor;
            ConsoleColor originalBackgroundColor = Console.BackgroundColor;
            int originalCursorLeft = Console.CursorLeft;
            int originalCursorTop = Console.CursorTop;

            while (lineToMark != 6)
            {

                originalForegroundColor = Console.ForegroundColor;

                // calculate cursor position

                int cursorTop = lineToMark;
                originalCursorLeft = Console.CursorLeft;
                originalCursorTop = Console.CursorTop;

                Console.SetCursorPosition(0, cursorTop - 1);

                originalBackgroundColor = Console.BackgroundColor;

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine($"{lineToMark}");


                // back to default values
                Console.ForegroundColor = originalForegroundColor;
                Console.BackgroundColor = originalBackgroundColor;
                Console.SetCursorPosition(originalCursorLeft, originalCursorTop);

                if (lineToMark == 1)
                {
                    Console.WriteLine("please enter nominator");
                    int nominator = int.Parse(Console.ReadLine());
                    Console.WriteLine("please enter denominator");
                    int denominator = int.Parse(Console.ReadLine());
                    Fraction frToReduce = new Fraction(nominator, denominator);

                    frToReduce.Reduce();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("********************");
                    Console.WriteLine("The result is: " + frToReduce.ToString());
                    Console.WriteLine("********************");
                    Console.ForegroundColor = originalForegroundColor;
                    Console.BackgroundColor = originalBackgroundColor;
                    Console.WriteLine("Press any key to continue . . .");
                    Console.ReadLine();
                }
                else if (lineToMark == 2)
                {
                    Console.WriteLine("Please enter the numerator of the first fraction:");
                    int nominator1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the denominator of the first fraction:");
                    int denominator1 = int.Parse(Console.ReadLine());
                    Fraction fraction1 = new Fraction(nominator1, denominator1);

                    Console.WriteLine("Please enter the numerator of the second fraction:");
                    int nominator2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the denominator of the second fraction:");
                    int denominator2 = int.Parse(Console.ReadLine());
                    Fraction fraction2 = new Fraction(nominator2, denominator2);

                    Fraction result = fraction1.Add(fraction2);
                    result.Reduce();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("********************");
                    Console.WriteLine("The result of adding the two fractions is: " + result.ToString());
                    Console.WriteLine("********************");
                    Console.ForegroundColor = originalForegroundColor;
                    Console.BackgroundColor = originalBackgroundColor;
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                }
                else if (lineToMark == 3)
                {
                    Console.WriteLine("Please enter the numerator of the first fraction:");
                    int nominator1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the denominator of the first fraction:");
                    int denominator1 = int.Parse(Console.ReadLine());
                    Fraction fraction1 = new Fraction(nominator1, denominator1);

                    Console.WriteLine("Please enter the numerator of the second fraction:");
                    int nominator2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the denominator of the second fraction:");
                    int denominator2 = int.Parse(Console.ReadLine());
                    Fraction fraction2 = new Fraction(nominator2, denominator2);

                    Fraction result = fraction1.Subtraction(fraction2);
                    result.Reduce();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("********************");
                    Console.WriteLine("The result of subtracting the two fractions is: " + result.ToString());
                    Console.WriteLine("********************");
                    Console.ForegroundColor = originalForegroundColor;
                    Console.BackgroundColor = originalBackgroundColor;
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    }
                else if (lineToMark == 4)
                {
                    Console.WriteLine("Please enter the numerator of the first fraction:");
                    int nominator1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the denominator of the first fraction:");
                    int denominator1 = int.Parse(Console.ReadLine());
                    Fraction fraction1 = new Fraction(nominator1, denominator1);

                    Console.WriteLine("Please enter the numerator of the second fraction:");
                    int nominator2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the denominator of the second fraction:");
                    int denominator2 = int.Parse(Console.ReadLine());
                    Fraction fraction2 = new Fraction(nominator2, denominator2);

                    Fraction result = fraction1.Multiplying(fraction2);
                    result.Reduce();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("********************");
                    Console.WriteLine("The result of multiplying the two fractions is: " + result.ToString());
                    Console.WriteLine("********************");
                    Console.ForegroundColor = originalForegroundColor;
                    Console.BackgroundColor = originalBackgroundColor;
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                }
                else if (lineToMark == 5)
                {
                    Console.WriteLine("Please enter the numerator of the first fraction:");
                    int nominator1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the denominator of the first fraction:");
                    int denominator1 = int.Parse(Console.ReadLine());
                    Fraction fra1 = new Fraction(nominator1, denominator1);

                    Console.WriteLine("Please enter the numerator of the second fraction:");
                    int nominator2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the denominator of the second fraction:");
                    int denominator2 = int.Parse(Console.ReadLine());
                    Fraction fra2 = new Fraction(nominator2, denominator2);
                    Fraction result = fra1.Division(fra2);
                    result.Reduce();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("********************");
                    Console.WriteLine("The result of dividing the two fractions is: " + result.ToString());
                    Console.WriteLine("********************");
                    Console.ForegroundColor = originalForegroundColor;
                    Console.BackgroundColor = originalBackgroundColor;
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();



                }


                    Console.Clear();
                    Console.WriteLine("1 Reducing");
                    Console.WriteLine("2 Adding");
                    Console.WriteLine("3 subtracting");
                    Console.WriteLine("4 multiplying");
                    Console.WriteLine("5 dividing");
                    Console.WriteLine("6 Exit");

                    Console.WriteLine("Hello,please choose from the options");


                    lineToMark = int.Parse(Console.ReadLine());


                }

                if (lineToMark == 6)
                {
                    Console.SetCursorPosition(0, 5);

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine($"{lineToMark}");
                    Console.ForegroundColor = originalForegroundColor;
                    Console.BackgroundColor = originalBackgroundColor;
                    Console.SetCursorPosition(originalCursorLeft, originalCursorTop);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("********************");
                Console.WriteLine("Hope you had a great experience!!!!");
                Console.WriteLine("********************");
                Console.ForegroundColor = originalForegroundColor;
                Console.BackgroundColor = originalBackgroundColor;
                }


            }

        }
    }
    
