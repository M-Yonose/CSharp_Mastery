using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionOOP
{
    public class Car
    {
        private Engine _engine;
        
        public Car(Engine engine)
        {
            _engine = engine;
        }

        public void start()
        {
            _engine.start();
            _engine.ChangeGear();
        }
    }
}
