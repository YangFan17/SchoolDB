﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Model
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public virtual ICollection<Grade> Grade { get; set; }
    }
}
