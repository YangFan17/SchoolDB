using School.DataAcess;
using School.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        private static void InsertDestination()
        {
            var student = new Student
            {
                StudentName = "张三",
                StudentAge = 20,
            };
            using (var context = new SchoolDB())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }
        static void Main(string[] args)
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<SchoolDB>());
            InsertDestination();
            Console.WriteLine("Done");
        }
    }
}
