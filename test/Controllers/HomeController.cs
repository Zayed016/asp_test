using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var context = new masterEntities();
            var able = new able()
            {
                name = "name2334",
            };
        context.ables.Add(able);
            context.SaveChanges();

            var blog = context.ables.ToList();
            ViewBag.first = blog;
            return View();
        }

        public ActionResult Delete()
        {
            var context = new masterEntities();
            
               
                var db = context.ables.Where(u => u.name.Equals("name2334")).FirstOrDefault();
                context.ables.Remove(db);
                context.SaveChanges();
                return null;
   }
        public ActionResult Edit(int Id)
        {
           
            var dbContext = new masterEntities();
            var customer = dbContext.ables.Where(e => e.Id == Id).First();

       
            customer.name = Request.QueryString["name"];
            System.Diagnostics.Debug.WriteLine(Request.QueryString["name"]);
            System.Diagnostics.Debug.WriteLine(customer.Id);
            dbContext.Entry(customer).State = System.Data.Entity.EntityState.Modified;
            try { 
            dbContext.SaveChanges();
        }
        catch (DbEntityValidationException dbEx)
        {
		    foreach (var validationErrors in dbEx.EntityValidationErrors)
		    {
		        foreach (var validationError in validationErrors.ValidationErrors)
		        {
                        System.Diagnostics.Debug.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
		        }
}
        }
            var db = dbContext.ables.Where(u => u.Id>Id).ToArray();
            dbContext.ables.RemoveRange(db);
            dbContext.SaveChanges();
            return null;
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}