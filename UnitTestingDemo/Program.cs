namespace UnitTestingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount=new BankAccount("Arun",5000);

            bankAccount.Credit(3000);
            bankAccount.Debit(2000);

            Console.WriteLine("Bank Balance :{0}",bankAccount.Balance);

        }
    }
}