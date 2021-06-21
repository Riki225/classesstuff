using System;

namespace testtest
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Person = new Person();
            Person.Introduce();
            Person.Info();

            Console.WriteLine();

            Person James = new Person("James", "Black", 32, 172, 67);
            James.Introduce();
            James.Info();         

            Console.WriteLine();

            Person Daniel = new Person("Daniel", "White", 24, 162, 53);
            Daniel.Introduce();
            Daniel.Info();         
            
            Console.WriteLine();      
        }
    }

}