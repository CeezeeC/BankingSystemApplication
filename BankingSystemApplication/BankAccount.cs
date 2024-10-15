using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemApplication
{
    public class BankAccount
    {
        // CLASS FIELDS
        private string _accoutHolder;
        private double _balanceAmount = 0;
        private double _amount;
        private double _amountWithdraw;

        //PARAMETERIZED CONSTRCTORS
        public BankAccount( double balanceAmount , string name)
        {
            _accoutHolder = name;
            _balanceAmount = balanceAmount;

        }
        
        //DEFAULT CONTRUCTORS
        public BankAccount()
        {
            
        }
        public void create()
        {
           Console.Write(" Enter your name to create an account : ");
           _accoutHolder = Console.ReadLine();
            // CHECKING IF FIELD IS EMPTY OR NULL
            if (string.IsNullOrEmpty(_accoutHolder))
            {
                Console.WriteLine("This field cannot be empty");
            }
          
        }

        
        
        public void Deposit()
        {
            // TAKING INPUT FROM THE USER
            Console.Write(" Enter the amount to deposit :");
            _amount  = Convert.ToDouble(Console.ReadLine());
            try
            {
                // CHECK IF THE AMOUNT ENTERED IS POSITIVE
                if (_amount >= 0)
                {
                    _balanceAmount += _amount;
                    Console.WriteLine($" You have succefully deposited {_amount} on your account ");
                }
                else
                {
                    Console.WriteLine(" Your deposit should be positive");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($" error occured {ex.Message}");
            }
            
        }
        //FUNCTION TO DISPLAY BALANCE
        public void viewBalance() 
        {
            Console.WriteLine($" Name : {_accoutHolder} \n" +
                                $" Balance : {_balanceAmount }:C ");

        }
        //WITDRAWAL FUNCTION
        public void Withdraw()
        {
            Console.Write(" Enter the amount to withdraw :");
            _amountWithdraw = Convert.ToDouble(Console.ReadLine());

            // TRY CATCH TO HANDLE ERRORS
            try
            {
                if (_amountWithdraw <= _balanceAmount)
                {
                    _balanceAmount -= _amountWithdraw;
                    Console.WriteLine($" You have successfully withdraw {_amountWithdraw:C} from your account");
                }
                else
                {
                    Console.WriteLine(" You do  not have such amount on your account ");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($" error occured {ex.Message}");
            }
           
        }
        // DISPLAYING HISTORY
        public void TrasactionHistory()
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine($" ****************TRANSACTION HISTORY***************\n" +
                              $" Account Name : {_accoutHolder}\n" +
                              $" Deposit      : {_amount}\n" +
                              $" Withdrawal   : {_amountWithdraw}\n" +
                              $" Date         : {dateTime}");

        }
        

    }
}
