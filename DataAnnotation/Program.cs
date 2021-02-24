using System;

namespace DataAnnotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data annotation attribute");
            //Calling the method using the class since it is a static method
            NewAttribute.AttributeDisplay(typeof(Employee));
            Console.WriteLine("----------------------------------------------------------");
            
            NewAttribute.AttributeDisplay(typeof(Employer));
            Console.ReadLine();
        }
    }
}
