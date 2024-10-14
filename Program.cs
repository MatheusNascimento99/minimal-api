var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "It's Works!");

app.MapPost("/login", (LoginDTO loginDTO) => {
    if (loginDTO.Email == "adm@teste.com" && loginDTO.Senha == "123456")
        return Results.Ok("Login realizado com sucesso!");
    else
        return Results.Unauthorized();
});

app.Run();

