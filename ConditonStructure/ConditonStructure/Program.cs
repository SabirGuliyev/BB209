

using System.ComponentModel.Design;
using System.Runtime.InteropServices.Marshalling;




//ctrl+k+s
#region If_else

//if (age >= 18 && gender=="female")
//{
//    Console.WriteLine("Qebul olduz");
//}
//else
//{
//    Console.WriteLine("Yashiniz ve ya cinsiniz uygun");
//}
//if (age >= 18)
//{
//    if (gender == "female")
//    {
//        Console.WriteLine("Qebul olduz");
//    }
//    else
//    {
//        Console.WriteLine("Xanim ishci axtaririq");
//    }
//}
//else
//{
//    Console.WriteLine("Yashiniz uygun deyil");
//}







//Ctrl+k+c
//Ctrl+k+u
//int age = 17;

//if (age >= 18)
//{
//    Console.WriteLine("Ishe qebul olduz");
//}
//else if (age == 17)
//{
//    Console.WriteLine("Stajor ola bilersiz");
//}
//else if (age == 16)
//{
//    Console.WriteLine("1 il sonra gel");
//}
//else
//{
//    Console.WriteLine("Yashiniz uygun deyil");
//} 
#endregion


//int choice = 1;




//switch (choice)
//{
//    case 1:
//        Console.WriteLine("Ana dili secildi");
//        break;
//    case 2:
//        Console.WriteLine("Rus dili secildi");
//        break;
//    case 3:
//        Console.WriteLine("English secildi");
//        break;
//    default:
//        Console.WriteLine("Secim yanlishdir");
//        break;
//}


string month = "aprel";

switch (month)
{
	case "mart":  
    case "dekabr":  
    case "yanvar":  
    case "may":
        Console.WriteLine(31);
        break;
    case "aprel" or "noyabr":
        Console.WriteLine(30);
       break;
    case "fevral":
        Console.WriteLine(28);
        break;

    default:
        Console.WriteLine("wrong input");
        break;
}



