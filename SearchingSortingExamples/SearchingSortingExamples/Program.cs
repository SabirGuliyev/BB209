#region Linear and Binary

//string[] names = { "Fatime", "Turane", "Sunay", "Ibrahim", "Rza" };
//string search = "Rza";

//int step = 0;
//for (int i = 0; i < names.Length; i++)
//{
//    step++;
//    if (names[i] == search)
//    {
//        Console.WriteLine(i);
//        break;
//    }
//}

//Console.WriteLine("Step: "+step);
//int step = 1;

//int[] arr = { 1, 4, 10, 26, 34, 55, 98, 122, 150, 200 };
////             L             M                     H

//int search = 122;
//int low = 0;
//int high=arr.Length - 1;
//int mid=(low + high)/2;

//while (arr[mid] != search)
//{
//    step++;
//    if (search > arr[mid])
//    {
//        low = mid + 1;
//    }
//    else
//    {
//        high = mid - 1;
//    }
//    mid= (low + high) / 2;
//}

//Console.WriteLine("Index of searched value:"+mid);
//Console.WriteLine("Searched value:" + arr[mid]);
//Console.WriteLine("Steps: "+step); 
#endregion

//save=11   
//int[] arr = { 11, 3, 27, -1, 5, 0, -10,4 , 8 };

//        //              4  -100 -1  3  5  8 11 27
//int step = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    for (int j = 0; j < arr.Length-1-i; j++)
//    {
//        step++;
//        if (arr[j] > arr[j + 1])
//        {
//            //int save = arr[j];
//            //arr[j] = arr[j + 1];
//            //arr[j + 1] = save;


//            arr[j] += arr[j + 1];
//            arr[j + 1] = arr[j]-arr[j+1];
//            arr[j] -= arr[j+1];
//        }
//    }
//}


//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}

//Console.WriteLine("Step: "+step);
//



int[] arr = { -5, 11, -7, 0, 3, 1, 27, 8, 6 };

int step = 0;

for (int i = 0; i < arr.Length-1; i++)
{
    step++;
    if (arr[i] > arr[i + 1])
    {
        int save = arr[i];
        arr[i]= arr[i + 1];
        arr[i+1]= save;
        i = -1;
    }

}


for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}

Console.WriteLine("Step:" +step);