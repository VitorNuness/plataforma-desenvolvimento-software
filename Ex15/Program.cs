namespace Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do Etanol: ");
            double etanol = Convert.ToDouble(Console.Read());
            Console.WriteLine("Digite o cosumo do Etanol: ");
            double etanol_consume = Convert.ToDouble(Console.Read());

            Console.WriteLine("Digite o valor da Gasolina: ");
            double gasolina = Convert.ToDouble(Console.Read());
            Console.WriteLine("Digite o consumo da Gasolina: ");
            double gasolina_consume = Convert.ToDouble(Console.Read());

            if (etanol_consume > gasolina_consume)
            {
                Console.WriteLine("Etanol");
            } else if (etanol_consume < gasolina_consume)
            {
                Console.WriteLine("Gasolina");
            } else
            {
                if (etanol > gasolina)
                {
                    Console.WriteLine("Gasolina");
                } else
                {
                    Console.WriteLine("Etanol");
                }
            }
        }
    }
}
