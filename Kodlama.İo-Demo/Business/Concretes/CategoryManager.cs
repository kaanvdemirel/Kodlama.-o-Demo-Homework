using Kodlama.İo_Demo.Business.Abstracts;
using Kodlama.İo_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.İo_Demo.Business.Concretes
{
    internal class CategoryManager : ICategoryService
    {
        public void Add(Category category)
        {
            Console.WriteLine("{0} isimli kategori eklendi.",category.CategoryName);
        }

        public void Delete(Category category)
        {
            Console.WriteLine("{0} isimli kategori silindi.", category.CategoryName);
        }

        public void Update(Category category)
        {
            Console.WriteLine("{0} isimli kategori güncellendi.", category.CategoryName);
        }
    }
}
