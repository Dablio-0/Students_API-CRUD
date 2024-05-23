using API_CRUD.Data;
using Microsoft.EntityFrameworkCore;

namespace API_CRUD.Students
{
    public static class RoutesStudents
    {
        public static void AddRoutesStudents(this WebApplication app)
        {
            var routesStudents = app.MapGroup("Students"); // CREATE A GROUP OF ROUTES, AFTER THE URL WILL BE /Students + /{route}

            // Create a new student 

            routesStudents.MapPost("", async (AddStudentRequest request, AppDbContext context) =>
            {
                var newStudent = new Student(request.Name, request.Age);

                var alreadyExists = await context.Students.AnyAsync(student => student.Name == request.Name); // CHECK IF THE STUDENT ALREADY EXISTS

                if (alreadyExists)
                {
                    return Results.BadRequest("Student already exists");
                }

                await context.Students.AddAsync(newStudent);
                await context.SaveChangesAsync(); // SAVE CHANGES TO THE DATABASE

                var returnResponse = new StudentDto(newStudent.Id, newStudent.Name, newStudent.Age);
                return Results.Ok();
            });

            // Get all students

            routesStudents.MapGet("", async (AppDbContext context) =>
            {
                var students = await context.Students // IF YOU USE THE WHERE METHOD, YOU CAN FILTER THE STUDENTS BY A CONDITION
                    .Select(student => new StudentDto(student.Id, student.Name, student.Age)) // SELECT ONLY THE DATA YOU WANT TO RETURN TO THE CLIENT
                    .ToListAsync(); // CONVERT THE QUERY TO A LIST

                return Results.Ok(students);
            });

            // Get a student by id

            routesStudents.MapGet("/{id}", async (Guid id, AppDbContext context) =>
            {
                var student = await context.Students.FindAsync(id);

                if (student is null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(student);
            });

            // Update a student by id

            routesStudents.MapPut("/{id}", async (Guid id, UpdateStudentRequest request, AppDbContext context) =>
            {
                var student = await context.Students.FindAsync(id); // SEARCH FOR THE STUDENT

                if (student is null)
                {
                    return Results.NotFound();
                }

                student.Name = request.Name;
                student.Age = request.Age;

                context.Students.Update(student);
                await context.SaveChangesAsync();

                return Results.Ok(new StudentDto(student.Id, student.Name, student.Age));
            });

            // Delete a student by id

            routesStudents.MapDelete("/{id}", async (Guid id, AppDbContext context) =>
            {
                var student = await context.Students.FindAsync(id);

                if (student is null)
                {
                    return Results.NotFound();
                }

                context.Students.Remove(student);
                await context.SaveChangesAsync();

                return Results.NoContent();
            });
        }
    }
}
