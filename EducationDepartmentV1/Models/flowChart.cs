using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EducationDepartmentV1.Models
{
    [Table("FlowChartDataBase")]
    public class flowChart
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int id { get; set; }
        public String jsonDoc { get; set; }
    }

    //public class FlowchartDBContext : DbContext
    //{
    //    public DbSet<flowChart> flowchart { get; set; }

    //    public System.Data.Entity.DbSet<EducationDepartmentV1.Models.flowChart> flowCharts { get; set; }
    //}
}