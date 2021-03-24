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
            courseGrades["MIS3013"].Add(0.95);

            List<double> MIS3033Grades = new List<double>();
            MIS3033Grades.Add(0.70);

            courseGrades.Add("MIS3033", MIS3033Grades);

            foreach (string courseName in courseGrades.Keys)
            {
                List<double> grades = courseGrades[courseName];

                foreach (double grade in grades)
                {
                    Console.WriteLine($"{courseName} - {grade}");
                }
            }

            //output each grade one by one, like problem 2 average but per course instead of average for all courses 

        }
    }
}
