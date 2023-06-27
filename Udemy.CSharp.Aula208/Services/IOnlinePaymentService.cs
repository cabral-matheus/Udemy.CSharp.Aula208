namespace Udemy.CSharp.Aula208.Services
{
    internal interface IOnlinePaymentService
    {
        abstract double PaymentFee(double amount);
        abstract double Interest(double amount,  int months);
    }
}
