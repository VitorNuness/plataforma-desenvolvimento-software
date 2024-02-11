namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int grade_to_approved = 7;
            const int minimun_grade = 4;
            double grades_weight = 0;
            string situation = "";

            while (grades_weight != 100)
            {
                Console.Write("Peso da nota 1: ");
                double weight_grade1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Nota 1: ");
                double grade1 = Convert.ToDouble(Console.ReadLine()) * weight_grade1;

                Console.Write("Peso da nota 2: ");
                double weight_grade2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Nota 2: ");
                double grade2 = Convert.ToDouble(Console.ReadLine()) * weight_grade2;

                grades_weight = weight_grade1 + weight_grade2;

                if (grades_weight == 100)
                {
                    double average = (grade1 + grade2) / (weight_grade1 + weight_grade2);

                    if (average >= grade_to_approved)
                    {
                        situation = "Aprovado";
                    }
                    else if (grade_to_approved > average && average >= minimun_grade)
                    {
                        situation = "Exame";
                    }
                    else
                    {
                        situation = "Reprovado";
                    }

                    Console.WriteLine($"Situação final:\n {average} - {situation}");
                    break;
                }

                Console.WriteLine("ERRO: O total da soma dos pesos deve ser 100!\n");
            }
        }
    }
}
