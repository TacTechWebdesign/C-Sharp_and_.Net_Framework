using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassParameters
{

    //1. Create a class. create a method that takes two integers as parameters.
    //Make one of them optional. Have the method do a math operation and return an integer result.
    public class two_parameters
    {
        public int Add(int x, int y = 0)
        {
            int answer = x + y;
            return answer;
        }
    }
}