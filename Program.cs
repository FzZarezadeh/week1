using System;

namespace week1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of students in the class:");
            int NoS = int.Parse(Console.ReadLine());
            double[] grades = new double[NoS];
            double sum = 0, avg = 0;
            for (int i = 1; i <= NoS; i++)
            {
                Console.WriteLine("enter grade of student {0}:",i);
                grades[i - 1] = double.Parse(Console.ReadLine());
                sum += grades[i - 1];
            }
            avg = sum / NoS;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("average class grades: {0}", avg);
            Console.ReadKey();
        }
    }
}
