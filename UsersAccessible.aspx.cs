using CarsAndTheirUsers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarsAndTheirUsers
{
    public partial class UsersAccessible : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Accessibility> GetUsers([QueryString("id")] int? carId)
        {
            var _db = new CarsAndTheirUsers.Models.MyDbContext();
            IQueryable<Accessibility> query = _db.Accessibilities;
            if (carId.HasValue && carId > 0)
            {
                query = query.Where(p => p.CarID == carId);
            }
            return query;
        }


        


    }
}