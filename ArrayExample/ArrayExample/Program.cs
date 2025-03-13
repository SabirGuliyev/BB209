
#region Array basic example

/////////////////////   1         2       3         4
//string[] students = { "Fatima", "Ali", "Aysel", "Qadir" };
///////////////////////    0        1        2        3 


//for (int i = 0; i < students.Length; i++)
//{

//    Console.WriteLine(students[i]+" BB209");
//}

//Console.WriteLine(students[0]);

//Console.WriteLine(students[students.Length-1]); 
#endregion


#region String in loops
//string name = "Slmm elekum";
//bool result = true;

//for (int i = 0; i < name.Length; i++)
//{
//    if (name[i] == 'a')
//    {
//        result = true;
//        break;
//    }
//}

//if (result)
//{
//    Console.WriteLine("Movcuddur");
//}
//else
//{
//    Console.WriteLine("qoqku");
//}

#endregion


#region Array algorithms
//int[] arr = { 11, 8, 24, 55, 19 };

////int count = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 0)
//    {
//        Console.WriteLine(arr[i]);
//        //count++;
//    }
//}

//Console.WriteLine(count); 
#endregion


#region Multidimensional array
//int[,] nums =
//{
//    {1,2,3 },
//    {4,5,6 },
//    {5,6,7 }
//};

//Console.WriteLine(nums.Rank); 
#endregion


#region Big O Notation
//int num = 49;

//int step = 0;
//bool result = false;
//for (int i = 2; i*i <= num; i++)
//{
//    step++;
//    if (num % i == 0)
//    {
//        result = true;
//        break;
//    }
//}

//if (result)
//{
//    Console.WriteLine("Murekkeb");
//}
//else
//{
//    Console.WriteLine("Sadedir");
//}
//Console.WriteLine(step);



//Linear
//string[] names = { "Test", "Testov", "Testoglu", "Test junior","test3"};
//int step = 0;

//for (int i = 0;i< names.Length; i++)
//{
//    step++;
//    Console.WriteLine(names[i]);
//}

//Console.WriteLine(step);

#endregion