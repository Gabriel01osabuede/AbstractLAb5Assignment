using System;

namespace AbstractLAb5Assignment
{
    public abstract class Bank
    {
        public abstract int getbalance();
    }

    public class BankA : Bank
    {
        public override int getbalance()
        {      
            int depositedAmount = 100;     
            return depositedAmount;
        }
    }

    public class BankB : Bank
    {
        public override int getbalance()
        {
            int depositedAmount = 150;    
            return depositedAmount;
        }
    }
    public class BankC : Bank
    {
        public override int getbalance()
        {
            int depositedAmount = 200;    
            return depositedAmount;
        }
    }
}
