using CarsAndTheirUsers.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace CarsAndTheirUsers
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<User> GetUsers()
        {
            var _db = new CarsAndTheirUsers.Models.MyDbContext();
            IQueryable<User> query = _db.Users;
            return query;
        }


        public void usersGrid_UpdateItem(int userID)
        {
            using (MyDbContext db = new MyDbContext())
            {
                User item = null;
                item = db.Users.Find(userID);
                if (item == null)
                {
                    ModelState.AddModelError("",
                      String.Format("Item with id {0} was not found", userID));
                    return;
                }

                TryUpdateModel(item);
                if (ModelState.IsValid)
                {
                    db.SaveChanges();
                }
            }
        }

        public void usersGrid_DeleteItem(int userID)
        {
            using (MyDbContext db = new MyDbContext())
            {
                var item = new User { UserID = userID };
                db.Entry(item).State = EntityState.Deleted;
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    ModelState.AddModelError("",
                      String.Format("Item with id {0} no longer exists in the database.", userID));
                }
            }
        }
    }
}