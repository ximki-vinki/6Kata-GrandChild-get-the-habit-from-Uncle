using System;

namespace _6Kata_GrandChild_get_the_habit_from_Uncle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Son : Mom
    {
        public new string TakeTheGarbageOut()
        {
            return new Uncle().TakeTheGarbageOut();

        }   


    }
}
