using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace explicitInterfaceImplementation
{
    class Student : INotDo, IDo
    {
        int IDo.Energy => 100;

        void INotDo.Go() => Console.WriteLine("Student I am not going");
       
        void IDo.Go() => Console.WriteLine("Student I am going");
        int IDo.Jump(int length) => 10+length;
        
        void INotDo.Sleep() => Console.WriteLine("Student I am not sleeping");
        void IDo.Sleep() => Console.WriteLine("Student I am  sleeping");
       
       public  void Play() => Console.WriteLine("I could play or not to play");
    }
}
