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


            double installment_value = total / installments;
            double total_paid = installments_paid * installment_value;
            double total_remaining = total - total_paid;
            double progress_percentage = (double)installments_paid / (double)installments;

            Console.WriteLine("Resumo do financiamento:");
            Console.WriteLine($"Parcela mensal: {installment_value.ToString("c")}");
            Console.WriteLine($"Valor total pago: {total_paid.ToString("c")} | Valor a pagar: {total_remaining.ToString("c")}");
            Console.WriteLine($"Valor total: {total.ToString("c")}");
            Console.WriteLine($"Progresso: {installments_paid}/{installments}({progress_percentage.ToString("0.00%")}) de parcelas pagas {installments_paid - installments} parcelas a pagar");
        
            const double percentage_50 = 0.5d;
            const double percentage_25 = 0.25d;
            double discount;

            if (progress_percentage < percentage_50 )
            {
                discount = 0.05;
            } else if (progress_percentage < percentage_25)
            {
                discount = 0.1;
            } else
            {
                discount = 0;
            }

            double discount_value = total * discount;
            total -= discount_value;

            if (discount != 0)
            {
                Console.WriteLine($"Oferta de quitãção à vista com {discount.ToString("0.00%")}: {total.ToString("c")}");
            }
        }
    }
}
