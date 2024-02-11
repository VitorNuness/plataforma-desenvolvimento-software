namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do Etanol: ");
            double etanol = Convert.ToDouble(Console.Read());

            Console.WriteLine("Digite o valor da Gasolina: ");
            double gasolina = Convert.ToDouble(Console.Read());

            double gasolina_percentage = 0.7 * gasolina;

            if (etanol > gasolina_percentage)
            {
                Console.WriteLine("Gasolina");
            } else
            {
                Console.WriteLine("Etanol");
            }
        }
    }
}
