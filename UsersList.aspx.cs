using CarsAndTheirUsers.Models;
using System;
using System.Linq;
using System.Web.ModelBinding;

namespace CarsAndTheirUsers
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<User> GetUsers([QueryString("id")] int? carId)
        {
            var _db = new CarsAndTheirUsers.Models.MyDbContext();
            IQueryable<User> query = _db.Users;
            if (carId.HasValue && carId > 0)
            {
                query = query.Where(p => p.CarID == carId);
            }
            return query;
        }
    }
}