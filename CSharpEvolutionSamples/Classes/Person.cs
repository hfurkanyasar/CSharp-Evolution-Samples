using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEvolutionSamples
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }



        public sealed override string ToString()
        {
            return $"{Name}, {Age} years old";
        }
    }
}
