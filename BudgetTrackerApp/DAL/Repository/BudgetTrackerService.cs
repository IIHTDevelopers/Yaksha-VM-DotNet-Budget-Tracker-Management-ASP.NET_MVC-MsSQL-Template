using BudgetTrackerApp.DAL.Interface;
using BudgetTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BudgetTrackerApp.DAL.Repository
{
    public class BudgetTrackerService : IBudgetTrackerInterface
    {
        private IBudgetTrackerRepository _repo;
        public BudgetTrackerService(IBudgetTrackerRepository repo)
        {
            this._repo = repo;
        }

        public int DeleteBudget(int budgetId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Budget GetBudgetByID(int budgetId)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Save()
        {
            //write your code here
            throw new NotImplementedException();
        }


        IEnumerable<Budget> IBudgetTrackerInterface.GetBudgets()
        {
            //write your code here
            throw new NotImplementedException();
        }

        Budget IBudgetTrackerInterface.InsertBudget(Budget budget)
        {
            //write your code here
            throw new NotImplementedException();
        }

        bool IBudgetTrackerInterface.UpdateBudget(Budget budget)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}