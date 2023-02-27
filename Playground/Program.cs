using Playground;

var people = new List<Person>
{
    new() { Name = "John", Type = "Caucasian", Age = 21, },
    new("diego", 23),
};

people

    // .AsNoTracking()
    .OrderBy(p => p.Name)
    .Where(p =>
        p.Type == "Hello" && p.Age > 20 ||
        (p.Name == "Diego" ||
            string.IsNullOrEmpty(p.Address) && true))
    .OrderByDescending(p => p.CurrentTask)
    .Select(x => new
    {
        x.Address,
        x.CurrentTask,
        Hobbies = x.Hobbies
            .Where(x => x.True)
            .ToList(),
    });