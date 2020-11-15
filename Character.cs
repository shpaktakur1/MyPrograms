using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public class Point2D
    {
        private int x; //поле экземпляра
        private int y;

        public Point2D(int x, int y)
        {
            this.x = x; //поле экземпляра класса
            this.y = y;
        }

    }
   public class Character
   {
        //свойство начинается с public

        private readonly int speed = 10; // readonly- дает присвоить значение переменной, позволяет инициализировать из конструктора, использовать для инстанции класса
        public int Health { get; set; } = 100; // обеспечивает доступ на чтение

        public Race Race { get; private set; }

        public int Armor { get; private set; }

        public string Name { get; private set; } // выбрасывание исключений

        public Character(Race race) 
        {
            Race = race;

            switch (race)
            {
                case Race.Elf:
                    Armor = 30;
                    break;
                case Race.Ork:
                    Armor = 40;
                    break;
                case Race.Terrain:
                    Armor = 20;
                    break;
                default:
                    throw new ArgumentException("Unknown race.");

            }

            if(race == Race.Terrain)
            {
                Armor = 20;
            }
            else if(race == Race.Ork)
            {
                Armor = 40;
            }
            else if(race == Race.Elf)
            {
                Armor = 30;
            }
            else
            {
                throw new ArgumentException("Unknown race.");
            }
        }

        public Character(string name, int armor)
        {
            if (name == null)
                throw new ArgumentNullException("Name arg can't be null"); // обработка исключения null

            if (armor < 0 || armor > 100)
                throw new ArgumentException("Armor can't be less than 0 or greater than 100"); //инкапсуляция класса Character(защитили инвариант - неизменное условие)

            Name = name;
            Armor = armor;
        }

        public Character(Race race, int armor) 
        {
            Race = race;
            Armor = armor;
        }
        //public Character(string race, int armor, int speed) // конструктор нужен для защиты состояния класса
        // {
        // Race = race;
        // Armor = armor;
        // this.speed = speed; // инициализация

        // }

        public void Hit(int damage) // класс внутри себя имеет доступ к членам
        {
            if (Health == 0)
                throw new InvalidOperationException("Can't hit a dead character.");

            if (damage > Health)
                throw new AggregateException("Damage can't be greater than current Health.");
            
            if (damage > Health)
                damage = Health;

            Health -= damage;
        }
        
        public int PrintSpeed()
        {
            return speed;
        }

        public void IncreaseSpeed()
        {
            //speed += 10;
        }
   }
}
