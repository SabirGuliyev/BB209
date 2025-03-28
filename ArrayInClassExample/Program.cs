using ArrayInClassExample.Models;

namespace ArrayInClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("BB209");
            Group group2 = new Group("Bf200");


            Student student = new Student("fatiME", "Qarayeva", 20);
            Student student2 = new Student("TuRane", "Qasimzade", 20);

            //Student student3 = new Student("Sexavet", "Agali", 19);
            //Student student4 = new Student("Rza", "Talibov", 21);

            group.AddStudent(student);
            group.AddStudent(student2);
            group.AddStudent(new Student("aLi", "Valiyev", 20));
            group.AddStudent(new Student("leman", "Zamanova", 20));





            group.ShowStudents();
            Console.WriteLine("after delete -----------------------------");



            group.DeleteStudent("alI");
            group.ShowStudents();







            //group2.AddStudent(student3);
            //group2.AddStudent(student4);




            //Student searched=group.GetStudent("turANE");

            //if (searched != null)
            //{
            //    Console.WriteLine(searched.Name);
            //}
            //else
            //{
            //    Console.WriteLine("Bu adli telebe movcud deyil");
            //}
            //group.ShowStudents();
            //Console.WriteLine("-----------------------------------");
            //group2.ShowStudents();
            //0 1 2 3


        }
    }
}
