namespace Multifabriken
{
    class Pipe
    {
        public Pipe(string diameter, string length)
        {
            Diameter = diameter;
            Length = length;
        }

        public string Diameter { get; set; }
        public string Length { get; set;}
    }
}