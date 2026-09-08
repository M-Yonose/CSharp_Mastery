using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionOOP
{
    public interface IEngine
    {
        string Model {  get; set; }
        void start();

        void ChangeGear();
    }
}
