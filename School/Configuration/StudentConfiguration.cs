using School.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Configuration
{
    public class StudentConfiguration : EntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
        {
            HasKey(s => s.StudentId);
            Property(s => s.StudentName).HasMaxLength(20).IsRequired();
            Property(s => s.StudentAge).IsRequired();
        }
    }
}
