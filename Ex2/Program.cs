namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Peso da nota 1: ");
            double weight_grade1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nota 1: ");
            double grade1 = Convert.ToDouble(Console.ReadLine()) * weight_grade1;
            Console.Write("Peso da nota 2: ");
            double weight_grade2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nota 2: ");
            double grade2 = Convert.ToDouble(Console.ReadLine()) * weight_grade2;
            double average = (grade1 + grade2) / (weight_grade1 + weight_grade2);
            Console.Write($"Média: {average}");

        }
    }
}
