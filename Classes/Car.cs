using System;

namespace Classes
{
    public class Car
    {
        public Car()
        {

        }
        public Car(string makeInput, string modelInput, string yearInput)        {
            Make = makeInput;
            Model = modelInput;
            Year = yearInput;
        }
        public string Make { get; set; }
        public string Model { get; set; }   
        public string Year { get; set; }

        

    }
}
