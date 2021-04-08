using System;
using System.Collections.Generic;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {

            string answer;

            DeveloperName("Dean", "MIS", "April 5th");

            double result = 0;
            string answer2 = "n";
           

            do
            {

               

                
                Console.WriteLine("What type of calculation do you wish to perform? 1 for Addition, 2 for Subtraction, 3 for Multiplication, and 4 for Division >>");
                string calculation = Console.ReadLine();

                if (calculation.ToLower() == "1")
                {
                    double firstdouble;
                    double seconddouble;
                    

                    if (answer2.ToLower() == "1")
                    {
                        firstdouble = result;
                    }
                    else
                    {
                        Console.WriteLine("What is the first number of the addition? >>");
                        string firstnumber = Console.ReadLine();
                        firstdouble = Convert.ToDouble(firstnumber);
                    }
                   


                    Console.WriteLine("What is the second number of the addition? >>");
                    string secondnumber = Console.ReadLine();
                    seconddouble = Convert.ToDouble(secondnumber);

                   result = Add(firstdouble, seconddouble);

                    Console.WriteLine($"The result of your calculation is {result}");

                    

                }

                else if (calculation.ToLower() == "2")
                {
                    double firstdouble;
                    double seconddouble;


                    if (answer2.ToLower() == "1")
                    {
                        firstdouble = result;
                    }
                    else
                    {
                        Console.WriteLine("What is the first number of the subtraction? >>");
                        string firstnumber = Console.ReadLine();
                        firstdouble = Convert.ToDouble(firstnumber);
                    }

                    Console.WriteLine("What is the second number of the subtraction? >>");
                    string secondnumber = Console.ReadLine();
                    seconddouble = Convert.ToDouble(secondnumber);

                    result = Subtract(firstdouble, seconddouble);

                    Console.WriteLine($"The result of your calculation is {result}");

                   

                }

                else if (calculation.ToLower() == "3")
                {
                    double firstdouble;
                    double seconddouble;


                    if (answer2.ToLower() == "1")
                    {
                        firstdouble = result;
                    }
                    else
                    {
                        Console.WriteLine("What is the first number of the multiplication? >>");
                        string firstnumber = Console.ReadLine();
                        firstdouble = Convert.ToDouble(firstnumber);
                    }

                    Console.WriteLine("What is the second number of the multiplication? >>");
                    string secondnumber = Console.ReadLine();
                    seconddouble = Convert.ToDouble(secondnumber);

                    result = Multiply(firstdouble, seconddouble);

                    Console.WriteLine($"The result of your calculation is {result}");

                    

                }

               else if (calculation.ToLower() == "4")
                {
                    double firstdouble;
                    double seconddouble;


                    if (answer2.ToLower() == "1")
                    {
                        firstdouble = result;
                    }
                    else
                    {
                        Console.WriteLine("What is the first number of the division? >>");
                        string firstnumber = Console.ReadLine();
                        firstdouble = Convert.ToDouble(firstnumber);
                    }

                    Console.WriteLine("What is the second number of the division? >>");
                    string secondnumber = Console.ReadLine();
                    seconddouble = Convert.ToDouble(secondnumber);

                    result = Divide(firstdouble, seconddouble);

                    Console.WriteLine($"The result of your calculation is {result}");


                   

                }


                Console.WriteLine("Would you like to stop? Y or N");
                answer = Console.ReadLine();


                if (answer.ToLower() == "n")
                {

                    Console.WriteLine("Would you like to use the result of the previous calculation as the first value in a follow-up calculation? 1 for Y or 2 for N");
                    answer2 = Console.ReadLine();
                }
                




            } while (answer.ToLower()[0] != 'y');

            

        }

        static void DeveloperName(string Name, string Class, string Date)
        {

            Console.WriteLine($" {Name}");
            Console.WriteLine($" {Class}");
            Console.WriteLine($" {Date}");


        }




        //class can have many methods a method only has one class

/// <summary>
/// sums up two values 
/// </summary>
/// <param name="val1">The left hand operand of the equation </param>
/// <param name="val2">The right hand operand of the equation </param>
/// <returns>The sum of the two numbers </returns>
        static double Add(double val1, double val2) //val1 and val2 are parameters 
        {
            double number = val1 + val2;

            return number;

            //return val1 + val2;

        }

        static double Subtract(double val1, double val2)
        {
            double number = val1 - val2;

            return number;

            //return val1 - val2;

        }

        static double Multiply(double val1, double val2)
        {
            double number = val1 * val2;

            return number;

            //return val1 * val2;

        }

        static double Divide(double val1, double val2)
        {
            double number = val1 / val2;

            return number;

            //return val1 / val2;

        }





    }
}
