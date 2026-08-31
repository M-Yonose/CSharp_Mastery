using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceOOP
{
    public class Car
    {
        protected int _speed;
        public string Model { get; protected set; }

        public Car()
        {
            _speed = 0;
            Model = string.Empty;
        }

        public void StartEngine()
        {
            Console.WriteLine("Car Engine Started");
        }

        public void IncreaseSpeed (int amount)
        {
            _speed += amount;
            Console.WriteLine($"Car current speed: {_speed}");
        }

    }
}
