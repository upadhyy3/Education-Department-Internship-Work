using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace EducationDepartmentV1.Models
{
    public class Example
    {
        [Required]
     //   public long id { get; set; }
        public long id { get; set; }
        public String contetn { get; set; }
     //   public DateTime lastDate { get; set; }
    }

    public class ExamplDBContext : DbContext
    {
        public DbSet<Example> Example { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.ForSqlServer().UseIdentity();

        //}
    }
}