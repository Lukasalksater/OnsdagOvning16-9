using OnsdagÖvning16_9.Interfaces;
namespace OnsdagÖvning16_9.Abstract_Classes
{
    public abstract class Vehicle : IBasicInfo
    {

        // Attributes

        public string Make { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }


        // Constructor

        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        // Abstract method

        public abstract void Drive(bool isUnique);

        public abstract void Brake(bool isUnique);

        public abstract void DisplayInfo();

        public abstract void FindLocation();


    }
}
