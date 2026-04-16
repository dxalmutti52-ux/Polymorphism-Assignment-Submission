using System;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate and initialize an Employee object
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student", Id = 1 };

            //Use polymorphism to create an object of type IQuittable
            IQuittable quitter = employee;

            //Call the Quit() method on the interface-type object
            quitter.Quit();

            Console.ReadLine();
        }
    }
}
