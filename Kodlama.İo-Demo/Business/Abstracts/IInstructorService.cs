using Kodlama.İo_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.İo_Demo.Business.Abstracts
{
    public interface IInstructorService
    {
         void Add(Instructor ınstructor);
        void Update(Instructor instructor);
        void Delete(Instructor instructor); 



    }
}
