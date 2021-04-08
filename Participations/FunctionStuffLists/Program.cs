using System;

namespace FunctionStuffLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //    List<double> gpas = new List<double>();

            //    string answer;

            //    do
            //    {
            //        double gpa = ValidateDoubleInput("Please enter your GPA >>");
            //        gpas.Add(gpa);


            //        bool shouldContinue = AskUserToContinue();
            //        Console.WriteLine("Do you want to enter more numbers?");
            //        answer = Console.ReadLine();

            //    } while (AskUserToContinue() == true);


            //    //calling this method needs a string and then gives back a double 

            //    List<double> itemprices = new List<double>();





            //    static double ValidateDoubleInput(string message)
            //    {

            //        double value;
            //        string answer;

            //        do
            //        {
            //            Console.WriteLine(message);
            //            answer = Console.ReadLine();

            //            //bool isDouble = double.TryParse(answer, out value);


            //        } while (double.TryParse(answer, out value) == false);

            //        return value;






            //    }
            //}

            ////access modifier making your account private basically 
            //private static bool AskUserToContinue()
            //{
            //    Console.WriteLine("Do you want to go again? Yes or no. >>");
            //    string answer = Console.ReadLine().ToLower();

            //    while (answer != "yes" && answer != "no")
            //    {
            //        Console.WriteLine("Sorry, you must answer yes or no");

            //        Console.WriteLine("Do you want to go again? Yes or no. >>");
            //        answer = Console.ReadLine().ToLower();
            //    }

            //    if (answer == "yes")
            //    {
            //        return true; 

            //    }
            //    else
            //    {
            //        return false;
            //    }

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

            Console.WriteLine("Hello World!");
        }
    }
}
