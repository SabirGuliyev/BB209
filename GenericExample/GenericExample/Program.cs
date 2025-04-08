using GenericExample.Models;
using GenericExample.Models.Animals;
using GenericExample.Models.Foods;
using System.Collections;

namespace GenericExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Product<int> product = new Product<int>(75);
            //    Product<char> product2 = new Product<char>('A');
            //    Product<string> product3 = new Product<string>("High");

            #region Generic type
            //Student student = new Student { Name="Rena"};


            //Lion lion = new Lion {AvgLifetime=30,Name="Simba",IsPrime=true };
            //Lion lion2 = new Lion {AvgLifetime=30,Name="Alex",IsPrime=false };

            //Meat meat = new Meat();

            //ZooCage<Lion,Meat> zooCage = new ZooCage<Lion,Meat>(meat);

            //zooCage.Add(lion);
            //zooCage.Add(lion2);

            //zooCage.ShowAnimals();

            //Console.WriteLine("----------------");

            //Elephant elephant = new Elephant { AvgLifetime=50,Name="Pumba",TeethWeight=15.5};
            //Elephant elephant2 = new Elephant { AvgLifetime=50,Name="Timon",TeethWeight=15.5};

            //Grass grass=new Grass { IsLegal=true};

            //ZooCage<Elephant,Grass> zooCage2=new ZooCage<Elephant,Grass>(grass); 
            //zooCage2.Add(elephant);
            //zooCage2.Add(elephant2);

            //zooCage2.ShowAnimals();

            #endregion



            //ArrayList arrayList = new ArrayList();

            //arrayList.Add(5);
            //arrayList.Add(7m);
            //arrayList.Add("salam");
            //arrayList.Add('A');
            //arrayList.Remove('A');

            //foreach (int item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}


            //SortedList sortedList = new SortedList();
            //sortedList.Add(1,"Turane");

            //sortedList.Add('A', 78);


            //SortedList<int, string> students = new SortedList<int, string>();

            //students.Add(5, "Qedir");
            //students.Add(2, "Fatime");
            //students.Add(4, "Samire");
            //students.Add(1, "Turane");
            //Console.WriteLine(students.TryAdd(3, "Ali"));


            //foreach (var item in students)
            //{
            //    Console.WriteLine(item.Key+" "+item.Value);
            //}




            //Stack<string> names=new Stack<string>();

            //names.Push("Sexavet");
            //names.Push("Sunay");
            //names.Push("Ibrahim");
            //names.Push("Leman");
            //string test;
            //names.TryPop(out test);
            //names.Pop();
            //names.Pop();
            //names.Pop();
            //names.Pop();
            //names.Pop();

            ////string test=names.Pop();
            ////Console.WriteLine(test);

            //names.Peek();
            //names.Peek();

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}


            //Queue<string> names=new Queue<string>();

            //names.Enqueue("Ibrahim");
            //names.Enqueue("Aysel");
            //names.Enqueue("Rena");
            //names.Enqueue("Fatime");


            //Console.WriteLine(names.Peek());
            //Console.WriteLine(names.Dequeue());
            //Console.WriteLine(names.Dequeue());
            //Console.WriteLine(names.Dequeue());
            //Console.WriteLine(names.Dequeue());
            //Console.WriteLine(names.Dequeue());



            
            List<int> nums = new List<int>() { 1,2,3,4,5,1,1,1,1,1};
            nums.Capacity = 10;
            nums.Add(1);
            nums.Add(1);


            Console.WriteLine(nums.Capacity);



            //nums.Add(5);
            //nums.Add(3);
            //nums.Add(11);

            //for (int i = 0; i < nums.Count; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}






        }
    }
}
