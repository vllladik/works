using Planer_AspNet.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Planer_AspNet.Entities
{
    public class PlanContext :DbContext
    {
        public DbSet<Plan> Plans { get; set; }

    }
}