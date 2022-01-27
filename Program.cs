using System;
using C_.src.Entities;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {

      Knight arus = new Knight("Arus", 23, "Kinght"); 
      Wizard wizard = new Wizard("Jennica", 23, "White Wizard");    

              Console.WriteLine(wizard.Attack(1));    
              Console.WriteLine(wizard.Attack(7));   
        }
    }
}
