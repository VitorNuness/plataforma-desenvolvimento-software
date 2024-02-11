namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string employer_name = "Tauste";
            Console.Write("Qual seu nome? ");
            string user_name = Console.ReadLine();
            Console.WriteLine($"Bem-vindo, {user_name} à {employer_name}.");
        }
    }
}
