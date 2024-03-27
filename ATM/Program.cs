using System;
namespace ATM
{
    public struct Account
    {
        public string userName;
        public string userPin;
        public double totalAmount;

        public Account(string name, string pin, double amount)
        {
            userName = name;
            userPin = pin;
            totalAmount = amount;
        }
    }

    public struct AccountsDetails
    {
        Account[] userAccounts = new Account[10];

        public AccountsDetails()
        {

        }

        public Account this[int index]
        {
            get
            {
                return userAccounts[index];
            }
            set
            {
                userAccounts[index] = value;
            }
        }

        public void withdraw(int userId, double amount)
        {
            userAccounts[userId].totalAmount -= amount;
        }

        public void deposit(int userId, double amount)
        {
            userAccounts[userId].totalAmount += amount;
        }

        public void updateUserName(int userId, string userName)
        {
            userAccounts[userId].userName = userName;
        }
    }

    enum Operations
    {
        Withdraw, Deposit, Statement, EditMyName, Exit
    };

    class ATM
    {
        public void EditMyName(int userId, AccountsDetails accounts)
        {
            Console.Write("\nEnter new User Name: ");
            string userName = Console.ReadLine(); ;

            if (userName != null && userName.Length > 0 && userName != " ")
            {
                accounts.updateUserName(userId, userName);
                Console.WriteLine("\n\nUser Name Updated Successfully!");
            }
        }

        public void Statement(int userId, AccountsDetails accounts)
        {
            Console.Write("\n\n\t\t***Receipt print with no transactions***");
            Console.WriteLine($"\n{DateTime.Now.ToString("MM/dd/yyyy")}\t\tXYZ Bank");
            Console.WriteLine($"{accounts[userId].userName}\nAvailable Balance: {accounts[userId].totalAmount:C2}");
        }

        public void Deposit(int userId, AccountsDetails accounts)
        {
            Console.Write("\nEnter amount to Deposit: ");
            double amount;
            if (double.TryParse(Console.ReadLine(), out amount))
            {
                if (amount > 10000)
                {
                    accounts.deposit(userId, amount);
                    Console.WriteLine($"\n\nAvailable Balance : {accounts[userId].totalAmount:C2}");
                }
                else
                {
                    Console.WriteLine("Sorry! Maximum deposit value is $10,000. Please try again.");
                }
            }
        }

        public void Withdraw(int userId, AccountsDetails accounts)
        {
            Console.Write("\nEnter amount to be withdrawn: ");
            double amount;
            if (double.TryParse(Console.ReadLine(), out amount))
            {
                if (amount > accounts[userId].totalAmount)
                {
                    Console.WriteLine("Insufficient Balance! Cancelling Transaction...");
                }
                else if ((accounts[userId].totalAmount - amount) <= 500)
                {
                    Console.WriteLine("Sorry! Minimum Amount of 1000 Required. Cancelling Transaction...");
                }
                else
                {
                    accounts.withdraw(userId, amount);
                    Console.WriteLine($"\nAmount Withdrawn Successfully!\n\n\t\tYour Availabale Balance: {accounts[userId].totalAmount:C2}");
                }
            }
        }

        public int GetVerifiedUser(AccountsDetails accounts, int noOfAccounts, string pin)
        {
            int currentUserId = -1;

            for (int userId = 0; userId < noOfAccounts; userId++)
            {
                if (accounts[userId].userPin == pin)
                {
                    currentUserId = userId;

                }
            }

            return currentUserId;
        }
        public static void Main()
        {
            ATM myatm = new ATM();
            AccountsDetails accounts = new AccountsDetails();
            int noOfAccounts = 0;
            accounts[noOfAccounts++] = new Account("Karthi", "1234", 5000);
            accounts[noOfAccounts++] = new Account("Tharanya", "5678", 100000);
            accounts[noOfAccounts++] = new Account("Tharun", "1112", 600000);
            accounts[noOfAccounts++] = new Account("Vikram", "1314", 500000);
            accounts[noOfAccounts++] = new Account("Vidhya", "1516", 1000000);

            Console.WriteLine("Welcome!");
            Operations userAction;

            do
            {
                Console.Write("\n\n\t* Withdraw\n\t* Deposit\n\t* Statement\n\t* EditMyName\n\t* Exit");
                Console.Write("\nPlease select your option : ");
                if (Enum.TryParse(Console.ReadLine(), out userAction))
                {
                    if (userAction != Operations.Exit)
                    {
                        string pin;
                        Console.Write("\nPlease enter your 4-digit pin : ");
                        pin = Console.ReadLine();

                        int currentUserId = myatm.GetVerifiedUser(accounts, noOfAccounts, pin);

                        if (currentUserId != -1)
                        {
                            Console.WriteLine($"\nHello {accounts[currentUserId].userName.ToUpper()}");
                            switch (userAction)
                            {
                                case Operations.Withdraw:
                                    myatm.Withdraw(currentUserId, accounts);
                                    break;
                                case Operations.Deposit:
                                    myatm.Deposit(currentUserId, accounts);
                                    break;
                                case Operations.Statement:
                                    myatm.Statement(currentUserId, accounts);
                                    break;
                                case Operations.EditMyName:
                                    myatm.EditMyName(currentUserId, accounts);
                                    break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("Incorrect Pin! Please try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\n*****Thank you*****");
                    }

                }
            } while (userAction != Operations.Exit);

        }
    }
};


