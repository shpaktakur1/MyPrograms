using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace D_OOP
{
    public class MyStack<T> : IEnumerable<T> // T and V(value), K(key) - обобщенные типы, записываются в <>
    {
        private T[] _items;

        public int Count { get; private set; } // Count -количество реальных храинмых объектов 
        public int Capacity // внешний код считает ёмкость
        {
            get
            {
                return _items.Length;
            }
        }

        
        public MyStack() // конструктор 1
        {
            const int defaultCapacity = 4; // размер array 
            _items = new T[defaultCapacity];
        }

        public MyStack(int capacity) // размерность стека
        {
            _items = new T[capacity];
        }
        
        public void Push(T item) // пуш элемента
        {
            if(_items.Length == Count)
            {
                T[] largerArray = new T[Count * 2]; // массив большего размера
                Array.Copy(_items, largerArray, Count); // копируем все элементы большего массива 

                _items = largerArray; // ссылка на только что созданный в памяти больший массив
            }
            _items[Count++] = item;
           
        }

        public void Pop() // Если человек пытается изъять элемент из пустого стека
        {
            if(Count == 0)
            {
                throw new InvalidOperationException(); // throw - бросить. Выбрасываем исключение
            }

            _items[--Count] = default; // Если выброшено исключение - дальше код исполнен не будет
        }

        public T Peek() // метод Peek - возвращает объект(последний элемент)
        {
            if (Count == 0)
            {
                throw new InvalidOperationException(); // throw - бросить. Выбрасываем исключение
            }

            return _items[Count - 1]; // чтобы взять элемент, нужно ( - 1 )
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new StackEnumerator<T>(_items, Count);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class StackEnumerator<T> : IEnumerator<T>
    {
        private readonly T[] array;
        private readonly int count;
        private int position;

        public StackEnumerator(T[] array, int count)
        {
            this.array = array;
            this.count = count;

            position = count;
        }
        public T Current // возвращает текущий элемент
        {
            get
            {
                return array[position];
            }
        } 


        object IEnumerator.Current // вовзращает результат текущего свойства
        {
            get
            {
                return Current;
            }
        }

        public void Dispose() // этот метод можно оставлять пустым
        {
            
        }

        public bool MoveNext() // возвращает bool, сдвигает указатель
        {
            position--;
            return position >= 0;
        }

        public void Reset() // должен устанавливать курсор в изначальную позицию
        {
            position = count;
        }
    }


}
