using School.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Configuration
{
    public class TeacherConfiguration : EntityTypeConfiguration<Teacher>
    {
        public TeacherConfiguration()
        {
            HasKey(t => t.TeacherId);
            Property(t => t.TeacherAge).IsRequired();
            Property(t => t.TeacherName).HasMaxLength(10).IsRequired();
        }
    }
}
