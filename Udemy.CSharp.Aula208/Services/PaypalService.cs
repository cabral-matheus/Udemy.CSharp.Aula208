namespace Udemy.CSharp.Aula208.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MonthyInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * MonthyInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
    }
}
