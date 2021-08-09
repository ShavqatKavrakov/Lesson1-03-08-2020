using System;

namespace problems
{
    class Program
    {
        static void Main(string[] args)
        {
          // Задача 1
        double a=double.Parse(Console.ReadLine());
         double b=double.Parse(Console.ReadLine());
         double result1=Math.Sqrt(a*b);
         Console.WriteLine($"результат = {Math.Round(result1,2)}");
    {  
        // Задача 2
        Console.WriteLine();
     double A=double.Parse(Console.ReadLine());
     double B=double.Parse(Console.ReadLine());
     double C=double.Parse(Console.ReadLine());
     double AC=Math.Abs((A-C));
     double BC=Math.Abs((B-C));
     double result2=Math.Round((AC+BC),2);
     Console.WriteLine($"AC = {Math.Round(AC,2)}");
     Console.WriteLine($"BC = {Math.Round(BC,2)}");
     Console.WriteLine($"AC+BC = {result2}");
        }
      {    
      // Задача 3
      Console.WriteLine();
      double x1=double.Parse(Console.ReadLine());
      double y1=double.Parse(Console.ReadLine());
      double x2=double.Parse(Console.ReadLine());
      double y2=double.Parse(Console.ReadLine());
      double result3=Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
      Console.WriteLine($"результат = {Math.Round(result3,2)}");
      }
      { 
         // Задача 4
         Console.WriteLine();
         Console.Write("Число: "); 
          int cd=int.Parse(Console.ReadLine());
          int c=cd / 10;
          int d=cd % 10;
          int result4=d*10+c;
          Console.WriteLine($"Результат: {result4}");
     }
      {  
         // Задача 5
         Console.WriteLine();
          Console.Write("N = ");
       int N=int.Parse(Console.ReadLine());
       int result5=N / 60;
       Console.WriteLine($"Результат: {result5}");
      }
      {
          // Задача 6
          Console.WriteLine();
          Console.Write("K = ");
        int K=int.Parse(Console.ReadLine());
        int result6=K % 7 ;
        Console.WriteLine($"Номер дня недели: {result6}");
      }
    
    }
}
}