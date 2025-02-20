using Startly.Context;
using Startly.Domains;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("curso/listar", () =>
{
    using var context = new StartlyContext();
    var startup = context.StartupSet.ToList();
    return Results.Ok(startup);
});

app.MapGet("startup/obter/{id:int}", (int id) =>
{
    using var context = new StartlyContext();
    var startup = context.StartupSet.Find(id);
    return Results.Ok(startup);
});

app.MapPost("startup/adicionar", (Startup startup) =>
{
    using var context = new StartlyContext();
    context.StartupSet.Add(startup);    
    context.SaveChanges();
    return Results.Created("Created", "Startup Adicionada com sucesso");
});

app.MapPut("startup/atualizar", (Startup startup) =>
{
    using var context = new StartlyContext();
    context.StartupSet.Update(startup);
    context.SaveChanges();
    return Results.Ok("Curso Atualizado com sucesso");
});

app.MapDelete("startup/remover/{id:int}", (int id) =>
{
    using var context = new StartlyContext();
    var startup = context.StartupSet.Find(id);
    context.StartupSet.Remove(startup);
    context.SaveChanges();
    return Results.Ok("Startup deletada com sucesso");
});

app.Run();
