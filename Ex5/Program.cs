namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.Write($"Nome do produto {++i}: ");
            string name_product1 = Console.ReadLine();
            Console.Write($"Valor do produto {i}: ");
            double value_product1 = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Quantidade do produto {i}: ");
            int qtd_product1 = Convert.ToInt32(Console.ReadLine());
            double total1 = value_product1 * qtd_product1;
            Console.Write($"Nome do produto {++i}: ");
            string name_product2 = Console.ReadLine();
            Console.Write($"Valor do produto {i}: ");
            double value_product2 = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Quantidade do produto {i}: ");
            int qtd_product2 = Convert.ToInt32(Console.ReadLine());
            double total2 = value_product2 * qtd_product2;
            Console.Write($"Nome do produto {++i}: ");
            string name_product3 = Console.ReadLine();
            Console.Write($"Valor do produto {i}: ");
            double value_product3 = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Quantidade do produto {i}: ");
            int qtd_product3 = Convert.ToInt32(Console.ReadLine());
            double total3 = value_product3 * qtd_product3;
            double general_total = total1 + total2 + total3;
            Console.WriteLine($"{total1.ToString("c")} - {name_product1}");
            Console.WriteLine($"{total2.ToString("c")} - {name_product2}");
            Console.WriteLine($"{total3.ToString("c")} - {name_product3}");
            Console.WriteLine($"{general_total.ToString("c")} - Total da Compra");
        }
    }
}
