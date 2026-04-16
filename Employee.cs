using System;

namespace MethodsAndObjectsAssignment
{
    //Employee inherits from Person and also inherits the IQuittable interface
    public class Employee : Person, IQuittable
    {
        //Give the Employee class a property called Id and have it be of data type int
        public int Id { get; set; }

        //Implement the Quit() method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine("Employee has quit the job.");
        }
    }
}
