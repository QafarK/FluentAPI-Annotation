using FluentAPI.DB;
using FluentAPI.Models;

Console.WriteLine("Hello, World!");
using (AcademyContext db = new())
{
    Teacher teacher = new Teacher()
    {
        FirstName = "asdsad1a",
        LastName = "asdasdsa",
        EmploymentDate = new DateTime(1999, 1, 1),
        Salary = 12,
        Premium = 0
    };
    Group group = new Group()
    {
        Name = "SADFSDF",
        Rating = 4,
        Year = 3
    };

    db.Groups.Add(group);
    db.Teachers.Add(teacher);
    db.SaveChanges();
}
Console.WriteLine("Hello, World!");
