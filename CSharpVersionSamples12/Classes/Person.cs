using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpVersionSamples12.Classes
{
    public class Person
    {
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }


       
        public struct NumberList
        {
            public int Number1;
            public int Number2;
            public int Number3;
            public int Number4;
            public int Number5;
        }


        [MyInterceptor]
        public class Calculator
        {
            public int Add(int x, int y) => x + y;
        }

        // Source generator ile yeni kod ekleme
        public class MyInterceptorAttribute : Attribute
        {
            // Arabulucu işlevini burada uygula
        }




    }
}
