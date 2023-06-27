using System.Globalization;
using Udemy.CSharp.Aula208.Entities;
using Udemy.CSharp.Aula208.Services;

namespace Udemy.CSharp.Aula208
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int numberOfInstallments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(contractNumber, date, contractValue);

            ContractService contractService = new ContractService(new PaypalService());

            contractService.ProcessContract(contract, numberOfInstallments);

            Console.WriteLine("Installments:");
            foreach (Installment installment in contract.installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}