using System;
using System.Collections.Generic;

namespace AllTypesofCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //problem 1 code here

            string[] courseNames = new string[3];

            string[] courseNumbers = new string[3];

            for (int i = 0; i < courseNames.Length; i++)
            {
                Console.WriteLine("Name your course");
                string CourseName = Console.ReadLine();

                courseNames[i] = CourseName;

                Console.WriteLine("Name your course number");
                string CourseNumber = Console.ReadLine();

                courseNumbers[i] = CourseNumber;
            }
            

            for (int i = 0; i < courseNames.Length; i++)
            {
                string output = courseNames[i] + courseNumbers[i];

                Console.WriteLine(output);
            }



            //problem 2 code here

            List<double> ClassGrades = new List<double>();

            string answer;
            do
            {
                Console.WriteLine("Enter your ClassGrade for your class");
                answer = Console.ReadLine();

                double score = Convert.ToDouble(answer);
                ClassGrades.Add(score);

                Console.WriteLine("Do you have any other class grades, yes or no?");
                answer = Console.ReadLine();



            } while (answer.ToLower() [0] != 'n');

            double sum = 0;
            double avg;

            foreach (double score in ClassGrades)
            {

                sum = sum + score;

            }

            avg = sum / ClassGrades.Count;

            Console.WriteLine($"The average of your class grades is {avg.ToString("N2")}");


            //problem 3 code here 
            Dictionary<string, List<double>> courseGrades = new Dictionary<string, List<double>>();
            courseGrades.Add("MIS3013", new List<double>());

            courseGrades["MIS3013"].Add(70);
            courseGrades["MIS3013"].Add(90);
            courseGrades["MIS3013"].Add(85);

            courseGrades.Add("MIS3033", new List<double>());
            courseGrades["MIS3033"].Add(80);
            courseGrades["MIS3033"].Add(85);
            courseGrades["MIS3033"].Add(90);

            courseGrades.Add("MATH2113", new List<double>());
            courseGrades["MATH2113"].Add(90);
            courseGrades["MATH2113"].Add(80);
            courseGrades["MATH2113"].Add(85);


            //List<double> MIS3013Grades = new List<double>();
            //MIS3013Grades.Add(92);
            //MIS3013Grades.Add(83);
            //MIS3013Grades.Add(63);


            //List<double> MIS3033Grades = new List<double>();
            //courseGrades.Add("MIS3033", MIS3033Grades);
            //MIS3033Grades.Add(70);
            //MIS3033Grades.Add(75);
            //MIS3033Grades.Add(80);

            //List<double> MATH2113Grades = new List<double>();
            //courseGrades.Add("MATH2113", MATH2113Grades);
            //MATH2113Grades.Add(80);
            //MATH2113Grades.Add(75);
            //MATH2113Grades.Add(90);


          
            foreach (string courseName in courseGrades.Keys)
            {
                double summ = 0;
                List<double> grades = courseGrades[courseName];
               

                foreach (double score in grades)
                {
                    summ = summ + score;
                    Console.WriteLine($"{courseName} - {score}");
                }

                double average = summ / grades.Count;
                double gradepercent = average / 100;
                Console.WriteLine($" Your average for {courseName} is {gradepercent.ToString("P2")}");

            }

            //output each grade one by one, like problem 2 average but per course instead of average for all courses 

        }
    }
}
