using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SchoolMVC.Models
{
    public class SqlStudentRepository
    {
        private readonly AppDbContext context;
        public SqlStudentRepository(AppDbContext context)
        {
            this.context = context;
        }



        public Student Add(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return student;
        }

        public Student GetStudent(int Id)
        {
            return context.Students.Find(Id);
        }

        public IEnumerable<Student> GetStudents()
        {
            return context.Students;
        }


        public void Delete(int Id)
        {

            Student student = context.Students.Find(Id);
            if (student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();

            }

        }

        public Student Update(Student studentChanges)
        {
            var temp = context.Students.Attach(studentChanges);
            temp.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return studentChanges;
        }
    }
}
