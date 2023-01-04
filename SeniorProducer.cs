using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Practice
{
    internal class SeniorProducer : Producer
    {
        public void Custombeat()
        {
            Console.WriteLine("Producer creates a custom instrumental");
        }
    }
}
