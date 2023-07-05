using System;

namespace MyLibrary
{
    public class Room : IComparable<Room>
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public Room(string name, double area) //Студент Танашов Амир
        {
            Name = name;
            Area = area;
        }

        public void Show()
        {
            Console.WriteLine($"Room: Name={Name}, Area={Area}");
        }

        public int CompareTo(Room other)
        {1xz
            return Area.CompareTo(other.Area);//Студент Танашов Амир
        }
    }
}
