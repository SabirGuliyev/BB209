using EncapsulationExample.Models;
using EncapsulationExample.RecordExample;

namespace EncapsulationExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonClass person = new PersonClass {
            Name="Salam"
            
            };
           

            PersonRecord personRecord = new PersonRecord {
            Name= "Test"
            
            };

            //personRecord = personRecord with { Name="Salam"};
            


          

            Console.WriteLine(personRecord.Name);















            //User user = new User("Sabir","Guliyev","Sabir123");


            //Console.WriteLine(user);

            //user.Password = "Salam123";
            ////user.UserName = "killer71";

            //Console.WriteLine(user.Password);











            //user.SetName("ali");

            //Console.WriteLine(user.GetName());

            //user.Surname = "     ";





        }
    }
}
