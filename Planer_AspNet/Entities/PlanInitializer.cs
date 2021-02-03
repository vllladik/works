
using Planer_AspNet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Planer_AspNet.Entities
{
    public class PlanInitializer : DropCreateDatabaseAlways<PlanContext>
    {
        protected override void Seed(PlanContext db)
        {
            db.Plans.Add(new Plan {Title = "Naruto", Date =new DateTime(2007,06,12), Img = "https://i.gifer.com/4Kj3.gif", Description = "blablablabla", IsPriority = true }) ;
            db.Plans.Add(new Plan { Title = "Cat", Date = new DateTime(2012,08,21), Img = "https://i.gifer.com/Xuw0.gif", Description = "blablablabla", IsPriority = true });
            db.Plans.Add(new Plan { Title = "Crab", Date =  DateTime.Now.Date, Img = "https://i.gifer.com/H5KZ.gif", Description = "blablablabla", IsPriority = true });

            base.Seed(db);
        }


    }
}