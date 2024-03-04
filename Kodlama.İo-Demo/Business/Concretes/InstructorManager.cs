using Kodlama.İo_Demo.Business.Abstracts;
using Kodlama.İo_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.İo_Demo.Business.Concretes
{
    public class InstructorManager : IInstructorService
    {
        public void Add(Instructor ınstructor)
        {
            Console.WriteLine("{0} {1} isimli eğitmen eklendi", ınstructor.FirstName, ınstructor.LastName);
        }

        public void Delete(Instructor ınstructor)
        {
            Console.WriteLine("{0} {1} isimli eğitmen silindi",ınstructor.FirstName,ınstructor.LastName);
        }

        public void Update(Instructor ınstructor)
        {
            Console.WriteLine("{0} {1} isimli eğitmen güncellendi", ınstructor.FirstName, ınstructor.LastName);
        }
    }
}
