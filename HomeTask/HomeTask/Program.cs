using Newtonsoft.Json;

namespace HomeTask
{
    internal class Program
    {
        public static string Path = @"C:\Users\sabir\Desktop\BB209\HomeTask\HomeTask\Files\names.json";
        static void Main(string[] args)
        {
            //Add("Ibrahim");
            //Delete("Ali");

        }

        public static void Add(string name)
        {
            List<string> names = Deserialize(Path);
            names.Add(name);
            Serialize(names, Path);

        }
        public static void Delete(string name)
        {

            List<string> names = Deserialize(Path);

            names.Remove(name);

            Serialize(names, Path);

        }


        public static bool Search(Predicate<string> predicate)
        {
            List<string> items=Deserialize(Path);
            return items.Exists(predicate);
        }


        public static List<string> Deserialize(string path)
        {
            string result;
            using (StreamReader sr = new(path))
            {
                result = sr.ReadToEnd();
            }
            List<string> names = JsonConvert.DeserializeObject<List<string>>(result);
            return names;
        }
        public static void Serialize(List<string> names,string path)
        {
            string json = JsonConvert.SerializeObject(names);
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(json);
            }
        }
       
    }
}
