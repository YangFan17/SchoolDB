using School.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Configuration
{
    public class ClassConfiguration : EntityTypeConfiguration<Class>
    {
        public ClassConfiguration()
        {
            HasKey(c => c.ClassId);
            Property(c => c.ClassName).HasMaxLength(50).IsRequired();
        }
    }
}
