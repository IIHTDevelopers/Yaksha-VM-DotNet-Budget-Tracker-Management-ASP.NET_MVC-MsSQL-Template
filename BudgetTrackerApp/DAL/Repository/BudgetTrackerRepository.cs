using BudgetTrackerApp.DAL.Interface;
using BudgetTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace BudgetTrackerApp.DAL.Repository
{
    public class BudgetTrackerRepository : IBudgetTrackerRepository
    {
        private BudgetTrackerDbContext _context;
        public BudgetTrackerRepository(BudgetTrackerDbContext Context)
        {
            this._context = Context;
        }
        public IEnumerable<Budget> GetBudgets()
        {
            //write your code here
            throw new NotImplementedException();
        }
        public Budget GetBudgetByID(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public Budget InsertBudget(Budget budget)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public int DeleteBudget(int budgetID)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public bool UpdateBudget(Budget budget)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Save()
        {
            //write your code here
            throw new NotImplementedException();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
