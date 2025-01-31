using System.Globalization;
using ExerciseContractProcessing.Entities;
using ExerciseContractProcessing.Services;

namespace ExerciseContractProcessing;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateOnly contractDate = DateOnly.ParseExact(Console.ReadLine(), "dd/MM/yyyy");

            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Installmens: ");
            int contractInstallments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(contractNumber, contractDate, contractValue);
            PaymentService paymentService = new PaymentService(new TaxService());

            paymentService.ProcessingContract(contract, contractInstallments);

            Console.WriteLine();
            Console.WriteLine("Installments: ");

            foreach (var installment in contract.InstallmentsList)
            {
                Console.WriteLine(installment);
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine($"Format Error: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }


    }
}