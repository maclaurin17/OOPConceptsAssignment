namespace OOPConceptsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Oyingbo Automobile. Please enter your Full name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your customer ID: ");
            string id = Console.ReadLine();
            Console.WriteLine("Welcome " + " "+ name + " "+ id);
            Toyota corolla = new Toyota();
            corolla.color = "green";
            corolla.make = "bentley";
            corolla.Iscarkey = true;
            corolla.IsPainted = true;
            corolla.Isautomatic = true;
            Console.WriteLine(corolla.CarReadyTobeShipped());
        }
    }
}