// See https://aka.ms/new-console-template for more information
using FluentAPI.DB;
using FluentAPI.Models;


Console.WriteLine("Hello, World!");
using (AcademyContext db = new())
{
    Teacher teacher = new Teacher()
    {
        FirstName = "asdsad1a",
        LastName = "asdasdsa",
        EmploymentDate = new DateTime(1980, 1, 1),
        Premium =0
    };
    Group group = new Group()
    {
        Name = "SADFSDF",
        Rating = 2,
        Year = 2
    };
    db.Teachers.Add(teacher);
    db.Groups.Add(group);
    db.SaveChanges();
}