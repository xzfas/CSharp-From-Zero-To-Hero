using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello please write down your name:");
            var name = Console.ReadLine();
            //Console.WriteLine(name);
            Console.WriteLine("Hello please write down your surname:");
            var surename = Console.ReadLine();
            //Console.WriteLine(surename);
            Console.WriteLine("Hello please write down your age:");
            var age = Console.ReadLine();
            //Console.WriteLine(age);
            Console.WriteLine("Hello please write down your weight (kg):");
            double weight = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(weight);
            Console.WriteLine("Hello please write down your height (cm):");
            double height = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(height);
            double heightCalc = height / 100;
            double heightSquare = heightCalc * heightCalc;
            //Console.WriteLine(heightSquare);
            double bmi = weight / heightSquare;
            bmi = Math.Round(bmi, 1);
            Console.WriteLine("Your bmi is: " + bmi);
            sdadadwa
        }
    }
}
