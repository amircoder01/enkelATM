namespace enkelATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
             ATM aTM = new ATM(1000);
            Console.WriteLine("Hello, People!");
            Console.WriteLine("Välkommen till er ATM");
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Hello, People!");
                Console.WriteLine("Välkommen till er ATM");
                Console.WriteLine("Välja en altervativ");
                Console.WriteLine("1. Visa saldo");
                Console.WriteLine("2. Insättning");
                Console.WriteLine("3. Uttag");
                Console.WriteLine("4. Avsluta");
                Console.WriteLine("Välj ett alternativ");
                int alternativ = Convert.ToInt32(Console.ReadLine());
                if (alternativ == 4)
                {
                    isRunning = false;
                }

                switch (alternativ)
                {
                    case 1:
                        Console.WriteLine("Visa saldo");
                        Console.WriteLine("Ditt saldo är: " + aTM.ShowSaldo());
                        break;
                    case 2:
                        Console.WriteLine("Insättning");
                        Console.WriteLine("Hur mycket vill du sätta in?");
                        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                        aTM.Deposit(depositAmount);
                        break;
                    case 3:
                        Console.WriteLine("Uttag");
                        Console.WriteLine("Hur mycket vill du ta ut?");
                        decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                        aTM.Withdraw(withdrawAmount);
                        break;
                    case 4:
                        Console.WriteLine("Avsluta");
                        Console.WriteLine("Tack för att du använde vår ATM");
                        break;
                    default:
                        Console.WriteLine("Fel alternativ");
                        break;
                }
            }   
        }
    }
    class ATM
    {
        private decimal Saldo { get; set; }

        public ATM(decimal saldo)
        {
            Saldo = saldo;
        }
        public decimal ShowSaldo()
        {
            return Saldo;
        }
        public void Deposit(decimal amount)
        {
            Saldo += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount > 0)
            {
                Saldo -= amount;
                Console.WriteLine("Du har tagit ut " + amount + "kr");
            }
            else
            {
                Console.WriteLine("Du kan inte ta ut negativa belopp");
            }
        }
    }
}
