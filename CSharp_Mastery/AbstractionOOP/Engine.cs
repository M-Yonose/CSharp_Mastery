using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionOOP
{
    public abstract class Engine : IEngine
    {
        private int _fuelSupply;
        private bool _isrunning;

        public string Model {  get; set; }

        public void start()
        {
            if(_fuelSupply > 0)
            {
                _isrunning = true;
                Console.WriteLine("Engine Started.");
            }
            else
            {
                Console.WriteLine("Can not start engine. Fuel supply is empty.");
            }
        }
        public abstract void ChangeGear();
    }
}
