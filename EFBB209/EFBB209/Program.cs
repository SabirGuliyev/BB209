using EFBB209.Data;
using EFBB209.Models;

namespace EFBB209
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new()
            {
                Name = "Fatime",
                Surname = "Qarayeva",
                Age = 20
            };
            using AppDbContext context = new AppDbContext();
            
                //context.Students.Add(student);
                //context.SaveChanges();
            










            //context.SaveChanges();



            Student? searched = context.Students.FirstOrDefault(s => s.Id == 3);

            searched.Surname = "Kazimbeyli";

            //context.Students.Update(searched);

            context.SaveChanges();













            // context.Students.Remove(searched);
            // context.SaveChanges();


            //if(searched is null)
            //{
            //    throw new Exception("Not Found");
            //}

            //Console.WriteLine(searched.Name+" "+searched.Surname);








            List<Student> students= context.Students.ToList();


            foreach (Student item in students)
            {
                Console.WriteLine(item.Name+" "+item.Surname+" "+item.Age);
            }





        }

    }
}
