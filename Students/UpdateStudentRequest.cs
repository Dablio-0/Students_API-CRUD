namespace API_CRUD.Students
{
    // In this case, the AddStudientRequest has the same code, but it's a good practice to create a dedicated class for Update the properties of student
    public record UpdateStudentRequest(string Name, int Age, bool Active);
}
