using OnsdagÖvning16_9.Classes;
namespace OnsdagÖvning16_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Husky husky = new Husky("Max", 3, 4, "Husky");
            husky.MakeSound();
            husky.Move();
            husky.DisplayInfo();
            husky.FindLocation();

            Ford ford = new Ford("Ford", "Mustang", 2022);
            ford.Drive();
            ford.Brake();
            ford.DisplayInfo();
            ford.FindLocation();
        }
    }
}
