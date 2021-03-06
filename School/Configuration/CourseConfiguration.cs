﻿using School.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Configuration
{
    public class CourseConfiguration : EntityTypeConfiguration<Course>
    {
        public CourseConfiguration()
        {
            HasKey(c => c.CourseId);
            Property(c => c.CourseName).HasMaxLength(50).IsRequired();
        }
    }
}
