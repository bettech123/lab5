using System;

namespace LAB5
{
    class Program
    {
        static void Main(string[] args)
        {
             Bank BankA = new BankA();
             Bank BankB = new BankB();
             Bank BankC = new BankC();

             BankA.getbalance();
             BankB.getbalance();
             BankC.getbalance();

             Console.WriteLine("Your Total Balance in BankA is :" + " " + BankA.getbalance() +"$");
             Console.WriteLine("Your Total Balance in BankB is :" + " " + BankB.getbalance() +"$");
             Console.WriteLine("Your Total Balance in BankC is :" + " " + BankC.getbalance() +"$");
        }
    }

    public abstract class Bank
    {
        public abstract double getbalance();
    }

    public class BankA : Bank
    {
        public override double getbalance()
        {      
            double depositedAmount = 100;     
            return depositedAmount;
        }
    }

    public class BankB : Bank
    {
        public override double getbalance()
        {
            int depositedAmount = 150;    
            return depositedAmount;
        }
    }
    public class BankC : Bank
    {
        public override double getbalance()
        {
            int depositedAmount = 200;    
            return depositedAmount;
        }
    }
}
