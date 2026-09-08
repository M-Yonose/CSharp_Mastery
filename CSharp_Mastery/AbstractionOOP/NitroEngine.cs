using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionOOP
{
    public class NitroEngine : Engine
    {
        public override void ChangeGear()
        {
            Console.WriteLine("Change gear for nitro engine.");
        }
    }
}
