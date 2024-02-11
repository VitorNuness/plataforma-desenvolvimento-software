namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result;
            string signal = "";

            while (signal != "+" || signal != "-" || signal != "*" || signal != "/")
            {


                Console.WriteLine("Digite um número: ");
                double first_number = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o operador ( +, -, *, / ): ");
                signal = Console.ReadLine();

                Console.WriteLine("Digite outro número: ");
                double seccond_number = Convert.ToDouble(Console.ReadLine());

                switch (signal)
                {
                    case "+":
                        result = first_number + seccond_number;
                        Console.WriteLine($"{first_number} {signal} {seccond_number} = {result}\n");
                        break;

                    case "-":
                        result = first_number - seccond_number;
                        Console.WriteLine($"{first_number} {signal} {seccond_number} = {result}\n");
                        break;

                    case "*":
                        result = first_number * seccond_number;
                        Console.WriteLine($"{first_number} {signal} {seccond_number} = {result}\n");
                        break;

                    case "/":
                        result = first_number / seccond_number;
                        Console.WriteLine($"{first_number} {signal} {seccond_number} = {result}\n");
                        break;

                    default:
                        Console.WriteLine("Operador inválido!");
                        break;

                }
            }
        }
    }
}
