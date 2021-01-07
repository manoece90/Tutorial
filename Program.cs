using System;
using System.IO;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] scores = new int[3, 5] { { 75, 76, 65, 87, 87 }, { 78, 76, 68, 56, 89 }, { 67, 87, 78, 77, 65 } };


            int[] finalscores = TotalMarksArray(3, 5, scores);

            Console.ReadLine();
        }

        static int[] TotalMarksArray(int n, int m, int[,] scores)
        {
            int[] subjectSum = new int[m];
            for (var i = 0; i < n; i++)
            {
                for (var sub = 0; sub < m; sub++)
                {
                    subjectSum[sub] += scores[i, sub];
                }
            }
            
            int lowestSubIndex = 0;
            //identify lowest subject score
            for (var i = 1; i < m; i++)
            {
                //compare current subject average with 
                if (subjectSum[i] < subjectSum[lowestSubIndex])
                {
                    lowestSubIndex = i;
                }
            }

            int[] studentScores = new int[n];
                        
            for (var stu = 0; stu < n; stu++)  //loop students score
            {
                for (var sub = 0; sub < m; sub++) //loop subject
                {
                    if (sub != lowestSubIndex) //Add only 
                    {
                        studentScores[stu] += scores[stu, sub];
                    }
                }
            }

            Array.Sort(studentScores);
            return studentScores;
        }
    }
}
