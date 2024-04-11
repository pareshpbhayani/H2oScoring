using H2oScoring.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseRouting();

//User minimal API

var userList = new List<User>
{
    new User
    {
        Id = 1, Name = "John", Email = "john@gmail.com", Phone = "+1 212 456 7890"
        , UserType = UserTypes.Admin, Competition = Competitions.Multimedia, Division = Divisions.HighSchool
        , Password = "@$$*F,))*()_)DFfjid", IsDeleted =false
    },
    new User
    {
        Id = 1, Name = "Mark", Email = "mark@gmail.com", Phone = "+1 212 987 7890"
        , UserType = UserTypes.Judge, Competition = Competitions.Multimedia, Division = Divisions.HighSchool
        , Password = "@$$*F,))*()_)DFfjid", IsDeleted =false
    },
    new User
    {
        Id = 1, Name = "Krisha", Email = "krisha@gmail.com", Phone = "+1 212 123 7890"
        , UserType = UserTypes.Admin, Competition = Competitions.Hackathon, Division = Divisions.College
        , Password = "@$$*F,))*()_)DFfjid", IsDeleted =false
    },
};


app.MapGet("api/users/get", () =>
{
    return Results.Ok(userList);
});

app.MapGet("api/users/get{id}", (int id) =>
{
    var user = userList.FirstOrDefault(i =>  i.Id == id);
    if (user is not null)
    {
        return Results.Ok(user);
    }

    return Results.NotFound("User not found.");
});

app.Run();