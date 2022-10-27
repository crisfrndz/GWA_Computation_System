//Title: GWA Computation System
//Description: This system allows you to compute your grade and determine if you have passed or failed your studies! (Using StackPush, StackPop, Sorting and many more algorithms.)
//Programmers:
//1. Cristian Fernandez
//2. John Rambien Niebres
//3. Paolo Suiza
//4. Aleacel Postor
//Date Submitted: October 27 2022
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWA_System
{
    internal class Program
    {
       
        public void OurInfo()
        {
            Console.WriteLine("*DEVELOPERS*\nLeader: Cristian Fernandez\nMembers:\nPaolo Suiza\nJohn Rambien Niebres\nAleacel Postor");
        }
        public void MyOption()
        {
            Console.WriteLine("\nChoose operation: \n1.Compute\n2.Undo\n3.Sort\n4.Exit");
        }
        static void Main(string[] args)
        {
            try
            {
                Program met = new Program();
                Stack<double> grade = new Stack<double>();
                double sum = 0;
                int choice;
                double subjectq;
                string username;
                char replace;
                Console.WriteLine("===============================================================");
                Console.Write("                     GWA Compuation System\n");
                Console.WriteLine("===============================================================");
                Console.Write("To continue enter your name: ");
                username = Console.ReadLine();
                Console.WriteLine("===============================================================");
                Console.WriteLine($"Hello {username}, welcome to GWA Computation System.\nThis system allows you to compute your grade and \ndetermine if you have passed or failed your studies!");
                Console.WriteLine("================================================================");
                Console.Write("How many subjects?: ");
                subjectq = Convert.ToDouble(Console.ReadLine());

                for (int i = 0; i < subjectq; i++)
                {
                    int ptr = i + 1;
                    Console.Write($"Enter Grade({ptr}): ");
                    grade.Push(Convert.ToDouble(Console.ReadLine()));
                }

                do
                {

                    double[] gradearr = grade.ToArray();
                    double x = gradearr.Length - 1;
                    Console.WriteLine("\n================================================================");
                    met.MyOption();
                    Console.Write("=> ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1)
                    {
                        Console.WriteLine("*COMPUTE*");
                        for (int i = 0; i <= x; i++)
                        {
                            sum += gradearr[i];
                        }
                        double fGrade = sum / subjectq;

                        if (fGrade >= 50)
                        {
                            Console.WriteLine($"Final Grade is: {fGrade}\nRemarks: Passed");
                        }
                        else
                        {
                            Console.WriteLine($"Final Grade is: {fGrade}\nRemarks: Failed");
                        }
                        sum = 0;
                        Console.WriteLine("Press any key to continue..");
                        Console.ReadKey();
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("*UNDO*");
                        Console.WriteLine($"Removed last grade added ({grade.Peek()})");
                        grade.Pop();
                        gradearr = grade.ToArray();
                        Console.Write("Replace? [Y or N] ");
                        replace = Convert.ToChar(Console.ReadLine());
                        if (replace == 'y' || replace == 'Y')
                        {
                            Console.Write("Replace with: ");
                            grade.Push(Convert.ToDouble(Console.ReadLine()));
                            gradearr = grade.ToArray();
                        }
                        Console.Write("Your grades: ");
                        foreach (var item in gradearr)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine("\nPress any key to continue..");
                        Console.ReadKey();
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("*SORT*");
                        Array.Sort(gradearr);
                        Console.Write("Sorted Grade: ");
                        foreach (var item in gradearr)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine("\nPress any key to continue..");
                        Console.ReadKey();
                    }
                    else if(choice == 4)
                    {
                        Console.WriteLine("*EXIT*");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Operation, please try again.");
                    }
                } while (choice != 4);
                Console.WriteLine("\n================================================================");
                met.OurInfo();
                Console.WriteLine("\n================================================================");
                Console.WriteLine("Thank you for using the program.");
                Console.WriteLine("Press any key to exit..");
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Invalid Input, Please restart the program.");
                Console.WriteLine("Press any key to exit..");
                Console.ReadKey();

            }

        }
    }
}
