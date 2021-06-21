using System;

namespace testtest
{
public class Person
{
   public string Name;
   public string Race;
   public int Age;
   public int Height;
   public int Weight;

   public Person ()
   {
       Name = "N/A";
       Race = "N/A";
       Age = 0;
       Height = 0;
       Weight = 0;
   }

   public Person(string _Name, string _Race, int _Age, int _Height, int _Weight)
   {
       Name = _Name;
       Race = _Race;
       Age = _Age;
       Height = _Height;
       Weight = _Weight;
   }

    public void Introduce()
    {
        Console.WriteLine("Hello People");
    }

    public void Info()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Race: " + Race);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Height: " + Height);
        Console.WriteLine("Weight: " + Weight);
    }

}
}