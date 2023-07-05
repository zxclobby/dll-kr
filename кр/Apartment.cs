using System;
using System.Collections.Generic;

namespace MyLibrary
{
    public class Apartment
    {
        public int Number { get; set; }
        public string Owner { get; set; }
        public List<Room> Rooms { get; set; }

        public Apartment(int number, string owner) //Студент Танашов Амир
        {
            Number = number;
            Owner = owner;
            Rooms = new List<Room>();
        }

        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }

        public void Show()
        {
            Console.WriteLine($"Apartment: Number={Number}, Owner={Owner}");
        }

        public void ShowAll()
        {
            foreach (Room room in Rooms)//Студент Танашов Амир
            {
                room.Show();
            }
        }
    }
}