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


            do
            {
                Console.WriteLine("What type of calculation do you wish to perform? >>");
                string calculation = Console.ReadLine();

                if (calculation.ToLower() == "Addition")
                {
                    Console.WriteLine("What is the first number of the addition? >>");
                    string firstnumber = Console.ReadLine();
                    double firstdouble = Convert.ToDouble(firstnumber);

                    Console.WriteLine("What is the second number of the addition? >>");
                    string secondnumber = Console.ReadLine();
                    double seconddouble = Convert.ToDouble(secondnumber);

                   result = Add(firstdouble, seconddouble);

                    Console.WriteLine($"The result of your calculation is {result}");

                }

                else if (calculation.ToLower() == "Subtraction")
                {
                    Console.WriteLine("What is the first number of the subtraction? >>");
                    string firstnumber = Console.ReadLine();
                    double firstdouble = Convert.ToDouble(firstnumber);

                    Console.WriteLine("What is the second number of the subtraction? >>");
                    string secondnumber = Console.ReadLine();
                    double seconddouble = Convert.ToDouble(secondnumber);

                    result = Subtract(firstdouble, seconddouble);

                    Console.WriteLine($"The result of your calculation is {result}");

                }

                else if (calculation.ToLower() == "Multiplication")
                {
                    Console.WriteLine("What is the first number of the multplication? >>");
                    string firstnumber = Console.ReadLine();
                    double firstdouble = Convert.ToDouble(firstnumber);

                    Console.WriteLine("What is the second number of the multiplication? >>");
                    string secondnumber = Console.ReadLine();
                    double seconddouble = Convert.ToDouble(secondnumber);

                    result = Multiply(firstdouble, seconddouble);

                    Console.WriteLine($"The result of your calculation is {result}");

                }

               else if (calculation.ToLower() == "Division")
                {
                    Console.WriteLine("What is the first number of the division? >>");
                    string firstnumber = Console.ReadLine();
                    double firstdouble = Convert.ToDouble(firstnumber);

                    Console.WriteLine("What is the second number of the division? >>");
                    string secondnumber = Console.ReadLine();
                    double seconddouble = Convert.ToDouble(secondnumber);

                    result = Divide(firstdouble, seconddouble);

                    Console.WriteLine($"The result of your calculation is {result}");


                }


                Console.WriteLine("Would you like to stop? Y or N");
                answer = Console.ReadLine();



                

                if (answer.ToLower() == "N")
                {



                    Console.WriteLine("Would you like to use the result of the previous calculation as the first value in a follow-up calculation? Y or N");
                    string answer2 = Console.ReadLine();




                }


            } while (answer.ToLower()[0] != 'y');

            //3 and 4 are arguments 
            //double sum = Add(3, 4);

            

            //Calling a method for some Letter grade action!


            //string answer;
            //do
            //{
            //    Console.WriteLine("Please input your grade in the course");
            //    double grade = Convert.ToDouble(Console.ReadLine());

            //    string lg = ConvertGradeToLetterGrade(grade); //can also put a double value here as long as its a double doesnt have to be avariable

            //    Console.WriteLine($"Congratulations you have an {lg} in the course");

            //    Console.WriteLine("Do you want to convert another grade? Yes or No");
            //    answer = Console.ReadLine();
            //} while (answer.ToLower()[0] == 'y');

        }
        /// <summary>
        /// Converts a standard grade (98.5) to the appropriate letter grade (A, B, C)
        /// </summary>
        /// <param name="anyVariableNameWeWantThisBelongsToThisMethod">The grade to convert to a letter grade </param>
        /// <returns>A string that is the letter grade of the input. N/A if it is below 0 </returns>

        //static string ConvertGradeToLetterGrade(double anyVariableNameWeWantThisBelongsToThisMethod)
        //{
        //    string letterGrade;
        //    if (anyVariableNameWeWantThisBelongsToThisMethod >= 90)
        //    {
        //        letterGrade = "A";
        //    }
        //    else if (anyVariableNameWeWantThisBelongsToThisMethod >= 80)
        //    {
        //        letterGrade = "B";
        //    }
        //    else if (anyVariableNameWeWantThisBelongsToThisMethod >= 70)
        //    {
        //        letterGrade = "C";
        //    }
        //    else if (anyVariableNameWeWantThisBelongsToThisMethod >= 60)
        //    {
        //        letterGrade = "D";
        //    }
        //    else if (anyVariableNameWeWantThisBelongsToThisMethod >= 0)
        //    {
        //        letterGrade = "F";
        //    }
        //    else
        //    {
        //        letterGrade = "N/A";
        //    }


        //    return letterGrade;
        //}

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
