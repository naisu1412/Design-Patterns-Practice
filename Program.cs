using System;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Animal inu = new Dog();
            System.Console.WriteLine( inu.tryToFly() );


            Animal tori = new Bird();
            System.Console.WriteLine( tori.tryToFly() );
            
        }
    }
}
