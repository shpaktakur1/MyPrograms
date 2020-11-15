using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public struct EvilStruct
    {
        public int x;
        public int y;

        public PointRef PointRef; // структура содержит поле ссылочного типа
    }
    
    public struct PointVal // типы значений
    {
        public int X;
        public int Y;

        public void LogValues()
        {
            Console.WriteLine($"X = {X}; Y = {Y}");
        }
    }

    public class PointRef // ссылочный тип
    {
        public int X;
        public int Y;

        public void LogValues()
        {
            Console.WriteLine($"X = {X}; Y = {Y}");
        }
    }
}
