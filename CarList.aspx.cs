using CarsAndTheirUsers.Models;
using System;
using System.Linq;
using System.Web.ModelBinding;

namespace CarsAndTheirUsers
{
    public partial class CarList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Car> GetCars()
        {
            var _db = new CarsAndTheirUsers.Models.MyDbContext();
            IQueryable<Car> query = _db.Cars;
            return query;
        }
    }
}