namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor total do financiamento: ");
            double total = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o número total de parcelas: ");
            int installments = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o número de parcelas pagas: ");
            int installments_paid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Resumo do financiamento:");
            double installment_value = total / installments;
            Console.WriteLine($"Parcela mensal: {installment_value.ToString("c")}");
            double total_paid = installments_paid * installment_value;
            double total_remaining = total - total_paid;
            Console.WriteLine($"Valor total pago: {total_paid.ToString("c")} | Valor a pagar: {total_remaining.ToString("c")}");
            Console.WriteLine($"Valor total: {total.ToString("c")}");
            double progress_percentage =  (double)installments_paid / (double)installments;
            Console.WriteLine($"Progresso: {installments_paid}/{installments}({progress_percentage.ToString("0.00%")}) de parcelas pagas {installments_paid - installments} parcelas a pagar");
        }
    }
}
