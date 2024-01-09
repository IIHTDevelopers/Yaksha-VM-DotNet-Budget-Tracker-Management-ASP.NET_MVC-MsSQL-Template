using BudgetTrackerApp.DAL.Interface;
using BudgetTrackerApp.DAL.Repository;
using BudgetTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BudgetTrackerApp.Controllers
{
    public class BudgetTrackerController : Controller
    {
        private readonly IBudgetTrackerInterface _Repository;
        public BudgetTrackerController(IBudgetTrackerInterface service)
        {
            _Repository = service;
        }
        public BudgetTrackerController()
        {
            // Constructor logic, if needed
        }
        // GET: BudgetTracker
        public ActionResult Index()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ViewResult Details(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ActionResult Create()
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult Create(Budget budget)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ActionResult EditAsync(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
        [HttpPost]
        public ActionResult Edit(Budget budget)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ActionResult Delete(int id, bool? saveChangesError)
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}