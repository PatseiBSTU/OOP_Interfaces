using System;


namespace Interfaces
{
    class Student : IPosebel
    {
        private int enegry = 100;
        private int posishion = 0;
        public int Energy => enegry;

        public void Count() => Console.WriteLine("Student count 1 2 3");
        public void Go() => Console.WriteLine("Student:I am going");
        public int Jump(int length)  
        {
            posishion +=length;
            return posishion;
        }

        public int Math() => (enegry);
        
        public void Sleep() =>  Console.WriteLine("Student:I am sleeping");
        

        public void WrigthCode() => Console.WriteLine("Student: static void Main(string[] args)");
        
    }
}
