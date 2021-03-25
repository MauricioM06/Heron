using System;

namespace Heron
{

    public class Program 
    {
        public static void Main(string [] args)
        {
			double LadoA;
			double LadoB;
			double LadoC;
			double SemiP;
			double Area;
			
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Heron");
			Console.WriteLine();
			Console.ResetColor();
			
			Console.WriteLine("Insira os lados do triângulo desejado:");
			Console.Write("Lado 1: ");
			LadoA = Convert.ToDouble(Console.ReadLine());
			
			Console.Write("Lado 2: ");
			LadoB = Convert.ToDouble(Console.ReadLine());
			
			Console.Write("Lado 3: ");
			LadoC = Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine();
			
			SemiP = (LadoA + LadoB + LadoC) / 2;
			Console.WriteLine("Semiperímetro: " + SemiP);
			
			Area = Math.Sqrt(SemiP * (SemiP - LadoA) * (SemiP - LadoB) * (SemiP - LadoC));
			Console.WriteLine("Área: " + Area);
        }
    }
}