using System;
using System.Collections.Generic;

namespace Collections_Min_Max_Avg_Mode
{
    class Program
    {
        static void Main(string[] args)
        {

           

            string answer;

            //need a collection to hold exam scores and a data type, dont know how many exam scores so you need collection, Double because assumed you might get half a point

            //type of collection? List(keep adding all of the items to list), Dictionary, Array(have to know amount of items) 

            List<double> examScores = new List<double>();

            Dictionary<double, int> exams = new Dictionary<double, int>();

            do
            {
                Console.WriteLine("Enter your exam score: <<");
                answer = Console.ReadLine();

                double score = Convert.ToDouble(answer);
                examScores.Add(score); //store value in collection so we can access later

                Console.WriteLine("Do you have another exam score to enter yes or no?");
                answer = Console.ReadLine();

            } while (answer.ToLower() [0] == 'y');

            double min = examScores[0]; //make it a large number thatll change later, need context behind exam. Setting first exam as the minimum cuz it's at least in the data set

            double max = examScores[0];
            //is this value lower than my current minimum? if so make it new minimum and so on 

            double sum = 0;
            double avg;


            
            foreach (double score in examScores)
            {
                //if score is less than current MINIMUM than update minimum to value of score 
                if (score < min)
                {
                    min = score;
                }

                //if score is more than current MAXIMUM than update maximum to value of score
                if (score > max)
                {
                    max = score + score;
                }

                //sum stuff 

                sum = sum + score;

                //stupid mode stuff

                if (exams.ContainsKey(score) == true)
                {

                    exams[score] = exams[score] + 1;

                }
                else
                {
                    exams.Add(score, 1); 

                }
                //can just add additional if and repurpose same loop

            }
            //now we have the minimum value 

            avg = sum / examScores.Count;

            Console.WriteLine($"The average exam score is {avg.ToString("N2")}");
            Console.WriteLine($"The minimum exam score is {min.ToString("N2")}");
            Console.WriteLine($"The maxmimum exam score is {max.ToString("N2")}");

            //avg is aggregating all values in examScores with a variable sum, once youve added them up divide by number of items you have 



            //more mode stuff that sucks
            int mode = 0;

            foreach  (double scoreKey in exams.Keys)
            {
                if (exams[scoreKey] > mode)
                {
                    mode = exams[scoreKey];
                }
            }

            foreach (double scoreKey in exams.Keys)
            {
                if (exams[scoreKey] == mode)
                    
                {
                    Console.WriteLine($"{scoreKey} occurs the most");
                }
            }



           





        }
    }
}
