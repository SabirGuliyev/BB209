using SolidExamples.DIP;
using SolidExamples.LSP;
using SolidExamples.OCP;

namespace SolidExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Knife knife = new Knife();  
            //Scissor scissor = new Scissor();    
            Paw paw = new Paw();
            Pizza pizza = new Pizza(paw);

            pizza.ServePizza();


















            //Eagle eagle = new Eagle();
            //Penguin penguin = new Penguin();


            //FlyShow<Eagle> flyShow = new FlyShow<Eagle>();

            //flyShow.Start();    



           //Chef chef = new Chef();


           // IMeal potato = new MushedPotato();
           // IMeal fries = new FrenchFries();
           // IMeal spage = new Spagetti();

           // chef.CookMeal(potato);
           // chef.CookMeal(fries);
           // chef.CookMeal(spage);

        }
    }
}
