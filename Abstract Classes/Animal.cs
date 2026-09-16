using OnsdagÖvning16_9.Interfaces;
namespace OnsdagÖvning16_9.Abstract_Classes
{
    public abstract class Animal : IBasicInfo // inherits from the interface IBasicInfo
    {
        // Attributes
        public string Name { get; set; }

        public int Age { get; set; }

        public int NumberOfLegs { get; set; }

        // Constructor

        public Animal(string name, int age, int numberOfLegs)
        {
            Name = name;
            Age = age;
            NumberOfLegs = numberOfLegs;
        }

        // Abstract method

        public abstract void MakeSound(bool isUnique);

        public abstract void Move(bool isUnique);

        // Abstract methods from interface IBasicInfo
        public abstract void DisplayInfo();

        public abstract void FindLocation();


    }
}
