using CarsAndTheirUsers.Models;
using System;
using System.Web.UI.WebControls;

namespace CarsAndTheirUsers
{
    public partial class AddUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void addUserForm_InsertItem()
        {
            var item = new User();

            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                using (MyDbContext db = new MyDbContext())
                {
                    db.Users.Add(item);
                    db.SaveChanges();
                }
            }
        }

        protected void cancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UsersList");
        }

        protected void addUserForm_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            Response.Redirect("~/UsersList");
        }
    }
}