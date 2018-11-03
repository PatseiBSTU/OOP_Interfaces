using System;


namespace Interfaces
{
    class Philosopher : IPosebel
    {
        private int enegry = 50;
        public int Energy => enegry;

        public void Count() => Console.WriteLine("Philosopher count : 1 7 2");
        public void Go() => Console.WriteLine("Philosopher go: I am goooooooing ");
        public int Jump(int length) => length / 2;
       public int Math() => 0;
        public void Sleep() => Console.WriteLine("Philosopher sleep: I am sleeping");
        public void WrigthCode() => Console.WriteLine("Philosopher: I can't coding");
        
    }
}
