namespace Multifabriken
{
    class Candy
    {
        public Candy(string taste, string amount)
        {
            Taste = taste;
            Amount = amount;
        }

        public string Taste { get; set; }
        public string Amount { get; set;}
    }
}