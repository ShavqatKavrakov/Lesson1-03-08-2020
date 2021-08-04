using System;

namespace problems1
{
    class Program
    {
        
        // Задача 1
        static void Main(string[] args)
        {
        double a=double.Parse(Console.ReadLine());
         double b=double.Parse(Console.ReadLine());
         double result=Math.Sqrt(a*b);
         Console.WriteLine($"результат = {Math.Round(result,2)}");
        }
       /*
        // Задача 2
        static void Main(string[] args) 
        {
     double A=double.Parse(Console.ReadLine());
     double B=double.Parse(Console.ReadLine());
     double C=double.Parse(Console.ReadLine());
     double AC=Math.Abs((A-C));
     double BC=Math.Abs((B-C));
     double result=Math.Round((AC+BC),2);
     Console.WriteLine($"AC = {Math.Round(AC,2)}");
     Console.WriteLine($"BC = {Math.Round(BC,2)}");
     Console.WriteLine($"AC+BC = {result}");
        }*/

     /*
      // Задача 3
      static void Main(string[] args)
      {
      double x1=double.Parse(Console.ReadLine());
      double y1=double.Parse(Console.ReadLine());
      double x2=double.Parse(Console.ReadLine());
      double y2=double.Parse(Console.ReadLine());
      double result=Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
      Console.WriteLine($"результат = {Math.Round(result,2)}");
      }
      */
      /*
      // Задача 4
      static void Main(string[] args)
      {
         Console.Write("Число: "); 
          int ab=int.Parse(Console.ReadLine());
          int a=ab / 10;
          int b=ab % 10;
          int ba=b*10+a;
          Console.WriteLine($"Результат: {ba}");
      }
      */
      /*
      // Задача 5
      static void Main(string[] args)
      {
          Console.Write("N = ");
       int N=int.Parse(Console.ReadLine());
       int result=N / 60;
       Console.WriteLine($"Результат: {result}");

      }
      */
    /*
      // Задача 6
      static void Main(string[] args)
      {
          Console.Write("K = ");
        int K=int.Parse(Console.ReadLine());
        int result=K % 7 ;
        Console.WriteLine($"Номер дня недели: {result}");
      }
    */
    }
}
