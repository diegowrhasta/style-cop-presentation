namespace Playground
{
    public class Person
    {
        public Person(string name, int jobs)
        {
            Name = name;
            Jobs = jobs;
        }

        public Person()
        {
        }

        public string Name { get; set; } = string.Empty;

        public int Age { get; set; }

        public bool IsAdult => Age > 18;

        public string Type { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public int Jobs { get; set; }

        public bool HasJob { get; set; }

        public string CurrentTask { get; set; } = string.Empty;
    }
}