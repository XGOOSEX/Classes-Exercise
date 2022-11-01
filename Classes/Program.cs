namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Car() is a constructor - special member method. Helps us create a new instance of the Car Class
            var myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "Focus";
            myCar.Year = "2013";

            var mazda = new Car()
            {
                Make = "Mazda", 
                Model = "CX-5", 
                Year = "2013"

            };
            var chevy = new Car("Chevy", "Impala", "2001");

            var carList = new List<Car>() { myCar, mazda, chevy, };//Constructor

            foreach(var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");

            }


        }
    }
}
