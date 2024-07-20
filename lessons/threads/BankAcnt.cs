namespace lessons.threads;

public class BankAcnt
{
    private Object _acctLock = new Object();
    private string Owner { get; set; }
    private double Balance { get; set; }

    public BankAcnt(double bal)
    {
        Balance = bal;
    }

    public double Withdraw(double amt)
    {
        if (Balance - amt < 0)
        {
            Console.WriteLine("Sorry {0}, but you are short {1} ", Owner, Balance - amt);

            return Balance;
        }

        lock (_acctLock)
        {
            if (Balance >= amt)
            {
                Console.WriteLine("Removed {0} and {1} left in Account",
                    amt, (Balance - amt));
                Balance -= amt;
            }

            return Balance;
        }
        
    }
    
    public void issueWithdraw()
    {
        Withdraw(1);
    }
}