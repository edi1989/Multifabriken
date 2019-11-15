namespace Multifabriken
{
    class Car
    {
        public Car(string color, string registrationNumber, string brand)
        {
            Color = color;
            RegistrationNumber = registrationNumber;
            Brand = brand;
        }

        public string Color { get; set; }
        public string RegistrationNumber { get; set;}
        public string Brand { get; set; }
        


    }
}