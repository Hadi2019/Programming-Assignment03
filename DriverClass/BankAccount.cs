using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverClass
{
    class BankAccount
    {
        #region // Global Variables ======================================
        private double _balance;
        private string _owner;
        private string _accountNumber;
        protected int numberOfAccounts;
        #endregion

        #region // Properties  ==========================================
        public double Balance { set; get; }
        public string Owner { set; get; }
        public string AccountNumber { set; get; }
        #endregion

        #region // Constructors =========================================
        // Default Constructor
        public BankAccount ()
        {

        }

        // Parameterized Constructor
        public BankAccount(string name, double amount)
        {

        }
        #endregion

        #region // Public Methods ================================================
        public void deposit (double amount)
        {

        }

        public Boolean withdraw (double amount)
        {
            return true;
        }
        #endregion
        // public double getBalance ()
        // {
        //     return 0;
        // }
        //
        // public string getOwner ()
        // {
        //     return 0;
        // }
        //
        // public string getAccountNumber ()
        // {
        //     return 0;
        // }


    }
}
