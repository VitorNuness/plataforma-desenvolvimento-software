namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nota 1: ");
            double grade1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nota 2: ");
            double grade2 = Convert.ToDouble(Console.ReadLine());
            double average = (grade1 + grade2) / 2;
            Console.WriteLine($"Media: {average}");
        }
    }
}
