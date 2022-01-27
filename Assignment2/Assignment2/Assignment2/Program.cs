﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class AccountDetails
    {
        static void Main(string[] args)
        {
            Account ac = new Account(45367875432, "praveen", "savings");
            ac.Show_AccountDetails();
            Console.ReadLine();
        }
    }
    class Account
    {
        long AccountNo;
        string CustomerName;
        string Accounttype;
        char Transactype;
        int amount;
        float balance=35000.0f;
        public Account(long Acc_no,string name,string acc_type)
        {
            AccountNo = Acc_no;
            CustomerName = name;
            Accounttype = acc_type;
        }
        public void TransactionType()
        {
            Console.WriteLine("enter the transaction type:W/D");
            var Transaction = Convert.ToChar(Console.ReadLine());
            if (Transaction == 'D' || Transaction == 'd')
            {
                Console.WriteLine("please enter");
                Credit(5000);
            }
            else
            {
                Debit(3000);
            }
        }
        public void Credit(int amount)
        {
            balance = balance + amount;
            Console.WriteLine("Account holder name:{0}\nAvailable Balance after deposite is : {1}", CustomerName, balance);
        }
        public void Debit(int amount)
        {
            balance = balance + amount;
            Console.WriteLine("Account Holder name:{0}\nAvailable Balance after withdrawal : {1}", CustomerName, balance);
        }
        public void Show_AccountDetails()
        {
            Console.WriteLine("The user account details:");
            Console.WriteLine("Account Number:" + AccountNo + "\n" + "Customer Name:" + CustomerName + "\n" + "Account Type" + Accounttype);
            Console.WriteLine("Initial Balance:{0}", balance);
            TransactionType();
        }
       
    }
}
