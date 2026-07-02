using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException2
{
    public class BankException : ApplicationException
    {
        int accno, balance, minbalance;
        public BankException(int accno, int balance, int minbalance)
        {
            this.accno = accno;
            this.balance = balance;
            this.minbalance = minbalance;

        }
        public void Inform()
        {
            Console.WriteLine("Account No  {0}, Balance  Rs:{1}", accno, balance);
            Console.WriteLine("please maintain minimum balance Rs:{0}", minbalance);

        }
    }
    public class Customer
    {
        int accno, balance;
        string name;
        public Customer(int accno, string name, int balance)
        {
            this.accno = accno;
            this.name = name;
            this.balance = balance;
        }
        public void WithDraw(int amt)
        {
            int minbalance = 500;
            if (balance - amt <= minbalance)
            {
                throw new BankException(accno, balance, minbalance);
            }
            else
            {
                balance = balance - amt;
                Console.WriteLine("your balance after withdrawal of Rs:{0} is Rs:{1}", amt, balance);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer(100, "Raju", 5000);
            try
            {
                c.WithDraw(5000);
                Console.WriteLine("your transaction completed");
            }
            catch (BankException ex)
            {
                ex.Inform();
                Console.WriteLine("your transaction is incompleted");
            }
        }
    }
}
