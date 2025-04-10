using Newtonsoft.Json;
using StreamExample.Models;

namespace StreamExample
{
    internal class Program
    {
        public static void Add()
        {

        }
        static void Main(string[] args)
        {


            #region File,Directory

            //if (!Directory.Exists(@"C:\Users\sabir\Desktop\Examples\Test"))
            //{
            //    Directory.CreateDirectory(@"C:\Users\sabir\Desktop\Examples\Test\");
            //}

            //Directory.Delete(@"C:\Users\sabir\Desktop\Examples\Test");


            //Directory.CreateDirectory(@"C:\Users\sabir\Desktop\Examples\Test\");


            //if (!File.Exists(@"C:\Users\sabir\Desktop\Examples\Test\text.txt"))
            //{
            //    File.Create(@"C:\Users\sabir\Desktop\Examples\Test\text.txt");
            //}

            //File.Delete(@"C:\Users\sabir\Desktop\Examples\Test\text.txt");


            //DirectoryInfo directory = new DirectoryInfo(@"C:\Users\sabir\Desktop\Examples\Test");
            //directory.Create();
            //directory.Exists;
            //directory.Delete();

            //FileInfo  
            #endregion



            #region Stream Writer/Reader

            //string result;

            //using StreamReader sr = new StreamReader(@"C:\Users\sabir\Desktop\Examples\Test\text.txt");
            //   result= sr.ReadToEnd();


            //Console.WriteLine(result);

            ////------------------------------------------


            //using (StreamWriter sw=new StreamWriter(@"C:\Users\sabir\Desktop\Examples\Test\text.txt",true))
            //{
            //    sw.WriteLine("Test");
            //} 




            //StreamWriter sw = new StreamWriter(@"C:\Users\sabir\Desktop\Examples\Test\text.txt", true);

            //sw.WriteLine("Fatime3\nTurane3\nSunay3");
            //sw.Close();
            #endregion





            Category category = new Category { Name = "SmartPhone" };
            //Category category2 = new Category { Name="TV"};


            //Product product = new Product { Id = 1, Name = "S22", Price = 2200, Category = category };
            //Product product2 = new Product { Id = 2, Name = "Iphone 15", Price = 1500, Category = category };

            //Product product3 = new Product { Id = 3, Name = "Toshiba", Price = 500, Category = category2 };
            //Product product4 = new Product { Id = 4, Name = "LG", Price = 4500, Category = category2 };


            //List<Product> products = new List<Product> {product,product2,product3,product4 };

            //string result=JsonConvert.SerializeObject(products);

            //Console.WriteLine(result);


            //using (StreamWriter sw = new StreamWriter(@"C:\Users\sabir\Desktop\BB209\StreamExample\StreamExample\Files\ProductsJson.json"))
            //{
            //    sw.WriteLine(result);
            //}

            string result;
            using (StreamReader sr = new(@"C:\Users\sabir\Desktop\BB209\StreamExample\StreamExample\Files\ProductsJson.json"))
            {
                result= sr.ReadToEnd();
            }

            Console.WriteLine(result);

           var products=  JsonConvert.DeserializeObject<List<Product>>(result);

            //products.RemoveAll(x => x.Id == 3);

            products.Add(new Product { Id = 6, Name = "POCO5", Price = 200, Category = category });

            string json=JsonConvert.SerializeObject(products);


            using (StreamWriter sw = new StreamWriter(@"C:\Users\sabir\Desktop\BB209\StreamExample\StreamExample\Files\ProductsJson.json"))
            {
                sw.WriteLine(json);
            }
        }
    }
}
