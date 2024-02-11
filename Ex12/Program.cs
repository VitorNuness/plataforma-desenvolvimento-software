namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Console.WriteLine("Digite o 1º número inteiro: ");
            list.Add(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Digite o 2º número inteiro: ");
            list.Add(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Digite o 3º número inteiro: ");
            list.Add(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Digite o método de ordenação: \n> C para crescente\n> D para decrescente");
            string sort_method = Console.ReadLine();

            switch (sort_method)
            {
                case "C":
                    list.Sort();
                    foreach (int number in list)
                    {
                        Console.WriteLine($"{number} ");
                    }
                    break;

                case "D":
                    foreach (int number in list.OrderDescending())
                    {
                        Console.WriteLine($"{number} ");
                    }
                    break;

                default:
                    Console.WriteLine("Ordenação inválida");
                    break;
            }
        }
    }
}
