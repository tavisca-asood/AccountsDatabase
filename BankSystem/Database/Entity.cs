using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Database
{
    class Entity:Database.IDatabase
    {
        TrainingEntities Accounts = new TrainingEntities();

        public void AddAccount(string fName, string lName, AccountType accountType, double balance)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            throw new NotImplementedException();
        }

        public string GetAccountType(int ID)
        {
            throw new NotImplementedException();
        }

        public double GetBalance(int ID)
        {
            throw new NotImplementedException();
        }

        public void UpdateBalance(int ID, double balance)
        {
            throw new NotImplementedException();
        }
    }
}
