// See https://aka.ms/new-console-template for more information


using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CourseManager courseManager = new CourseManager(new InMemoryCourseDal());
TeacherManager teacherManager = new TeacherManager(new InMemoryTeacherDal());

Teacher teacher = new Teacher();
string TeacherFullName = null;

foreach (var course in courseManager.GetAll())
{
    teacher = teacherManager.GetById(course.TeacherId);
    TeacherFullName = teacher.FirstName + " " + teacher.LastName;
    Console.WriteLine("Kurs Adı : {0}\nKurs Açıklaması : {1}\nEğitici : {2}\nÜcreti : {3}\n ---------------------------------------\n", course.Name, course.Description, TeacherFullName, course.Price);
}
