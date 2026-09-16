using OnsdagÖvning16_9.Classes;
namespace OnsdagÖvning16_9
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Create instances of Husky and and Runs the methods
           // Husky husky = new Husky("Max", 3, 4, "Husky");
            Dog husky = new Dog("Max", 3, 4, "Husky");
            husky.MakeSound(true);
            husky.Move(true);
            husky.DisplayInfo();
            husky.FindLocation();

            // Create instances of Ford and Runs the methods
            //Ford ford = new Ford("Ford", "Mustang", 2022);
            Car ford = new Car("Ford", "Mustang", 2022);
            ford.Drive(false);
            ford.Brake(false);
            ford.DisplayInfo();
            ford.FindLocation();
        }
    }
}
