using Inheritance_2;

Manager manager = new Manager()
{
    Name = "Berkay",
    Surname = "Şimşek",
    Email = "berkayysimsekk@gmail.com",
    Salary = 90000,
    TeamCount = 6,
    Title = "CFO"
};

Programmer programmer = new Programmer()
{
    Name = "Ahmet",
    Surname = "Aksakal",
    Email = "aksakalahmet@gmail.com",
    Salary = 30000,
    Title = "Software Developer",
    ProgrammingLanguage = "C#"
};

Console.WriteLine(manager);
Console.WriteLine(programmer);