using Kodlama.İo_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.İo_Demo.Business.Abstracts
{
    internal interface ICategoryService
    {
        void Add(Category category);

        void Delete(Category category);
        void Update(Category category); 
        
    }
}
