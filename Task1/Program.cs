namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Islam's Carpet Cleaning Service");
            Console.WriteLine("--------------------------------------------------------");
            
            Console.WriteLine("Enter the number of small carpets: ");
            int smallCarpets = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of large carpets: ");
            int largeCarpets = int.Parse(Console.ReadLine());
            Console.WriteLine("Price per small room: $25\r\n");
            Console.WriteLine("Price per large room: $35\r\n");
            // Cost 
            int cost = smallCarpets*25 + largeCarpets*35;
            Console.WriteLine($"Cost: {cost}");
            // Tax
            double tax = cost * 0.06 ;
            Console.WriteLine($"Tax: {tax}");
            // Total cost
            double totalCost = cost + tax;
            Console.WriteLine($"Total estimate: ${totalCost}");
            Console.WriteLine("This estimate is valid for 30 days");



        }
    }
}
