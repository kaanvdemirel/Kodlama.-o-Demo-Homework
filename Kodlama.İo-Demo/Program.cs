using Kodlama.İo_Demo.Business.Abstracts;
using Kodlama.İo_Demo.Business.Concretes;
using Kodlama.İo_Demo.Entities;


Category category1 = new Category();    
category1.CategoryId = 1;
category1.CategoryName = "Software";



Category category2 = new Category();
category2.CategoryId = 2;
category2.CategoryName = "Hardware";



Course course1 = new Course();

course1.CourseId = 1;
course1.CourseName = "C#";
course1.CoursePrice = 10;
course1.CourseInstructor = "Engin Demiroğ";

Course course2 = new Course();

course2.CourseId = 2;
course2.CourseName = "Python";
course2.CoursePrice = 120;
course2.CourseInstructor = "Kaan Demirel";








Instructor ınstructor1 = new Instructor();


ınstructor1.Id = 1;
ınstructor1.FirstName = "Engin";
ınstructor1.LastName = "Demiroğ";




Instructor ınstructor2 = new Instructor();


ınstructor2.Id = 2;
ınstructor2.FirstName = "Kaan";
ınstructor2.LastName = "Demirel";



IInstructorService ınstructorManager = new InstructorManager();
ICourseService courseManager = new CourseManager();
ICategoryService categoryManager = new CategoryManager();



courseManager.Delete(course2);
ınstructorManager.Add(ınstructor2);
categoryManager.Update(category2);


Console.ReadLine();
