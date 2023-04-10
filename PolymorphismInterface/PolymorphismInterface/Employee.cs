using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismInterface
{
    //2. Have your Employee class from the previous drill
    //inherit that interface and implement the Quit() method in any way you choose.

    class Employee : IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("I Quit");
        }
    }
}