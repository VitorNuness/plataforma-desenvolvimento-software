namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do produto: ");
            string product_name = Console.ReadLine();
            Console.Write("Valor do produto: ");
            double product_value = Convert.ToDouble(Console.ReadLine());
            Console.Write("Quantidade do produto: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            double total = product_value * quantity;
            Console.WriteLine($"{total.ToString("c")} - {product_name}");
        }
    }
}
