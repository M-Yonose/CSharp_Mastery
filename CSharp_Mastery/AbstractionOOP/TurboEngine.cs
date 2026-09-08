using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionOOP
{
     public class TurboEngine : Engine
    {
        public override void ChangeGear()
        {
            Console.WriteLine("Gear change to turbo engine.");
        }
    }
}
