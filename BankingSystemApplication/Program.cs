using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankingSystemApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankObj = new BankAccount();// CREATING INSTANCE OF BANK ACCOUNT OBJECT 
            bool exit = false;// EXIT 
            

            while (!exit)
            {
                Console.WriteLine(" ********* WELCOME TO BANKING SYSTEM ********** ");
                Console.WriteLine(" Enter  1 to 5 Choose your option\n" +
                    " (1) to create your account.\n" +
                    " (2) to deposit money into your account.\n" +
                    " (3) to withdraw money from your account.\n" +
                    " (4) to display current balance\n" +
                    " (5) to view transcation history\n" +
                    " (6) to exit");
                int choice=Convert.ToInt32(Console.ReadLine());
                try
                {

                    if (!(choice < 1 || choice > 6))
                    {
                        switch (choice)
                        {
                            case 1:
                                bankObj.create();// CTREATE FUNCTION
                                break;

                            case 2:

                                bankObj.Deposit();// DEPOSIT FUNCTION
                                break;

                            case 3:
                                bankObj.Withdraw();// WITHDRAWAL FUNCTION
                                break;

                            case 4:

                                bankObj.viewBalance();// VIEW BALANCE FUNCTION
                                break;

                            case 5:
                                bankObj.TrasactionHistory();// TRANSACTION FUNCTION
                                break;
                            case 6:

                                exit = true; 
                                break;

                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid number has been entered !!!!");
                    }
                }
                catch (Exception exception)
                {

                    Console.WriteLine($" error occured {exception.Message}");
                }
                
            } 
            Console.ReadLine(); 
        }
    }
}
