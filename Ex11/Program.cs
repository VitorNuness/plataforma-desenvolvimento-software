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

            list.Sort();

            foreach (int number in list)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
