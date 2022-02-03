using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asssignment3
{
        class AmountDueException : ApplicationException
        {
            public AmountDueException(string msg) : base(msg)
            {

            }
        }
        class LoanProcess
        {
            int Loan_No;
            string Customer_Name;
            double Loan_Amount;
            double EMI_Amount;
            double Account_Balance;
            public LoanProcess(int loan_no, string cust_name, double acc_blnc)
            {
                Loan_No = loan_no;
                Customer_Name = cust_name;
                Account_Balance = acc_blnc;
                Console.WriteLine("Loan Number:" + Loan_No + "\n" + "Customer name:" + Customer_Name + "\n" + "Account Balance:" + Account_Balance);
            }

            public void calculate_EMI()
            {
                Console.WriteLine("Enter Loan Amount");
                Loan_Amount = Convert.ToDouble(Console.ReadLine());
                EMI_Amount = Loan_Amount * 0.13 * 3;
                Console.WriteLine("EMI_Amount:" + EMI_Amount);
            }
            public void CheckBalance()
            {
                if (Account_Balance < EMI_Amount)
                {
                    throw (new AmountDueException("Unsufficient balance to repay loan"));
                }
                else
                {
                    Console.WriteLine("Loan Payment successfull!!!");
                }
            }
        }
        class LoanPayment
        {
            static void Main()
            {
                Console.WriteLine("The Account holder details are:");
                LoanProcess Lp = new LoanProcess(67592, "praveen", 30000.20);
                try
                {
                    Lp.calculate_EMI();
                    Lp.CheckBalance();
                }
                catch (AmountDueException ae)
                {
                    Console.WriteLine(ae.Message);

                }
                Console.Read();
            }
        }
}
