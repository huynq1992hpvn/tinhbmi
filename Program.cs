using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinhbmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chieucao;
            double cannang;
            Console.WriteLine("xin hay nhap chieu cao");
            chieucao = float.Parse(Console.ReadLine());
            Console.WriteLine("xin hay nhap can nang");
            cannang = float.Parse(Console.ReadLine());
            double bmi = cannang / Math.Pow(chieucao, 2);
            bmi = Math.Round(bmi, 1);
            Console.WriteLine("BMI: " + bmi);

            if (bmi < 18)
                Console.WriteLine("Underweight");
            else if (bmi < 25.0)
                Console.WriteLine("Normal");
            else if (bmi < 30.0)
                Console.WriteLine("Overweight");
            else
                Console.WriteLine("Obese");
            Console.ReadKey();
        }
    }
}
