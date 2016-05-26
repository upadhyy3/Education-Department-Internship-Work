using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EducationDepartmentV1.Models
{
    public class FlowChartContext :  DbContext
    {
        public DbSet<Example> Example { get; set; }
    }
}