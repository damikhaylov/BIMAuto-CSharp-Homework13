using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задан класс Building, который описывает здание. Класс содержит следующие элементы:
                адрес здания;
                длина здания;
                ширина здания;
                высота здания.
            В классе Building нужно реализовать следующие методы:
                конструктор с 4 параметрами;
                свойства get/set для доступа к полям класса;
                метод Print(), который выводит информацию о здании.

            Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность. В классе MultiBuilding реализовать следующие элементы:
                конструктор с 5 параметрами – реализует вызов конструктора базового класса;
                свойство get/set доступа к внутреннему полю класса;
                метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
            Класс MultiBuilding сделать таким, что не может быть унаследован.
            */

            Console.WriteLine("Вывод информации о здании с использованием соответствующих классов\n");

            Console.WriteLine("Одноэтажное здание");
            Building building = new Building("ул. Ленина, 1", 60, 12, 15);
            building.Print();

            Console.WriteLine("\nМногоэтажное здание");
            MultiBuilding multiBuilding = new MultiBuilding("пл. Маркса, 1", 50, 15, 18, 6);
            multiBuilding.Print();

            Console.ReadKey();

        }

        class Building
        {
            public string Address { get; set; }
            public float Length { get; set; }
            public float Width { get; set; }
            public float Height { get; set; }

            public Building(string address, float length, float width, float height)
            {
                this.Address = address;
                this.Length = length;
                this.Width = width;
                this.Height = height;
            }

            public void Print()
            {
                PrintBaseProperties();
            }

            protected void PrintBaseProperties()
            {
                Console.WriteLine("Адрес: {0}", this.Address);
                Console.WriteLine("Длина здания: {0}", this.Length);
                Console.WriteLine("Ширина здания: {0}", this.Width);
                Console.WriteLine("Высота здания: {0}", this.Height);
            }
        }
        sealed class MultiBuilding : Building
        {
            public byte Floors { get; set; }
            public MultiBuilding(string address, float length, float width, float height, byte floors)
                : base(address, length, width, height)
            {
                this.Floors = floors;
            }

            public new void Print()
            {
                this.PrintBaseProperties();
                Console.WriteLine("Количество этажей: {0}", this.Floors);
            }
        }
    }
}
