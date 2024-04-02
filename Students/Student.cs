namespace API_CRUD.Students
{
    public class Student
    {
        public Guid Id { get; init; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Active { get; set; } = true;

        public Student(string name, int age)
        {
            Id = Guid.NewGuid(); // UNIQUE IDENTIFIER
            Name = name;
            Age = age;
        }
    }
}
