using EnumExample.Models;
using EnumExample.Utilities.Enums;
using EnumExample.Utilities.Exceptions;

namespace EnumExample
{
    internal class Program
    {
        public static string SearchStudent(string[] arr,string search)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == search)
                {
                    return arr[i];
                }
            }
            throw new NotFoundException(search+" bu adli telebe tapilmada");
        }
        static void Main(string[] args)
        {

            #region Enum
            //Person perso=new Person("Ibrahim","Male"); 




            //foreach (var day in Enum.GetValues(typeof(WeekDay)))
            //{
            //    Console.WriteLine((int)day+"."+day);
            //}

            //int choice = int.Parse(Console.ReadLine());

            //switch (choice)
            //{
            //    case (int)WeekDay.Monday:
            //        Console.WriteLine(WeekDay.Monday);
            //        break;
            //    case (int)WeekDay.Tuesday:
            //        Console.WriteLine(WeekDay.Tuesday);
            //        break;
            //    case (int)WeekDay.Wednesday:
            //        Console.WriteLine(WeekDay.Wednesday);
            //        break;
            //    case (int)WeekDay.Thursday:
            //        Console.WriteLine(WeekDay.Thursday);
            //        break;
            //    case (int)WeekDay.Friday:
            //        Console.WriteLine(WeekDay.Friday);
            //        break;
            //    case (int)WeekDay.Saturday:
            //        Console.WriteLine(WeekDay.Saturday);
            //        break;
            //    case (int)WeekDay.Sunday:
            //        Console.WriteLine(WeekDay.Sunday);
            //        break;
            //}


            //switch (choice)
            //{
            //    case 10:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 20:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //} 
            #endregion

            string[] students = { "ali", "sunay", "fatime" };

            string result;
            try
            {
                result = SearchStudent(students, "alibaba");
            }
            catch (NotFoundException e)
            {
                
                result = students[0];   
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(result);

            //int num;
            //int num2;
            //try
            //{
            //    num = int.Parse(Console.ReadLine());
            //    num2 = int.Parse(Console.ReadLine());
            //    Console.WriteLine(num/num2);
            //}
            //catch (DivideByZeroException e)
            //{
            //    throw;
            //    num2 = 1;
            //    Console.WriteLine("0-a bolmeye cehd edildi");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    //    num = 1;
            //    //num2 = 1;

            //    throw new Exception("Yanlish melumat");
            //}
            //finally
            //{
            //    Console.WriteLine("finally kod bloku ishe dushdu");
            //}

            //Console.WriteLine(" xetadan sonra ishleyen kod program devam etdi");

        }
    }
}
