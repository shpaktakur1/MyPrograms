using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public class Calculator
    {
        
        public static bool TryDivide(double divisible, double divisor, out double result)
        {
            result = 0; //значение по умолчанию
            if (divisor == 0) //реализация
            {
                return false;
            }
            result = divisible / divisor; // в противном случае
            return true;
        }
      
        public static double Average2(params int[] numbers)
        {
            // аргумент с модификатором params обязан быть последним в списке(используется для упрощения вызова)
            int sum = 0; 

            foreach (int n in numbers)
            {
                sum += n;
            }
            return (double)sum / numbers.Length;
        }
      
        public static double Average(int[] numbers)
        {
            double sum = 0;

            foreach (int n in numbers)
            {
                sum += n;
            }
            return (double)sum / numbers.Length;
        }   
  
        public static double CalcTriangleSquare(double ab, double bc, double ca)
        {
            double p = (ab + bc + ca) / 2;

            return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ca));
        }
      
        public static double CalcTriangleSquare(double b, double h)
        {
            // double - тип возвращаемого значения(перегрузка методов)
             // сигнатура - объявление метода
            {
                return 0.5 * b * h;
            }
        }

        public static double CalcTriangleSquare(double ab, double ac, int alpha, bool isInRadians = false) // IsInRadians - опциональный параметр
        {
            if (isInRadians)
            {

                return 0.5 * ab * ac * Math.Sin(alpha);
            }
            else
            {
                double rads = alpha * Math.PI / 180;
                return 0.5 * ab * ac * Math.Sin(rads);
            }
        }

    
    }
}
