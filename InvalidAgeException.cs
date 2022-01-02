using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class InvalidAgeException : Exception
    {

        public InvalidAgeException()
            : base("L'age dois être entre 18 et 26")
            
            
            {

            }




    }
}
