using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace explicitInterfaceImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student devi = new Student();
            //   devi.Sleep(); //  нельзя вызвать метод интерфеса
           ((IDo)devi).Sleep();
            INotDo iNDDevi = devi as INotDo;
            iNDDevi.Sleep();
            devi.Play();

            INotDo isit = new Student();
            isit.Go();
            ((IDo)isit).Go();
            ((IDo)isit).Jump(6);
            isit.Play();

        }
    }
}
