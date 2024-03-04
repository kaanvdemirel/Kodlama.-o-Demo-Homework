using Kodlama.İo_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.İo_Demo.Business.Abstracts
{
    public interface ICourseService
    {

        void Add(Course course);
        void Delete(Course course);
        void Update(Course course); 

    }
}
