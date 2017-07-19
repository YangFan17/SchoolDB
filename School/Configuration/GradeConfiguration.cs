using School.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Configuration
{
    public class GradeConfiguration : EntityTypeConfiguration<Grade>
    {
        public GradeConfiguration()
        {
            HasKey(g => new { g.StudentId, g.CourseId });

            Property(g => g.GradeScore).IsRequired();
        }
    }
}
