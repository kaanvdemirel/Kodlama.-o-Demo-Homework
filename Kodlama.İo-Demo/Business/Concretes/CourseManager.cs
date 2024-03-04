using Kodlama.İo_Demo.Business.Abstracts;
using Kodlama.İo_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.İo_Demo.Business.Concretes
{
    internal class CourseManager : ICourseService
    {
        public void Add(Course course)
        {
            Console.WriteLine("{0} isimli kurs eklendi.",course.CourseName);
        }

        public void Delete(Course course)
        {
            Console.WriteLine("{0} isimli kurs silindi.", course.CourseName);
        }

        public void Update(Course course)
        {
            Console.WriteLine("{0} isimli kurs güncellendi.", course.CourseName);
        }
    }
}
