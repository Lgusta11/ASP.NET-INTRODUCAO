using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json; // Adicionado para usar o Newtonsoft.Json
using ScreenSound.Banco;
using ScreenSound.Modelos;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ScreenSoundContext>();
builder.Services.AddTransient<DAL<Artista>>();

// Configuração do serviço de serialização JSON para usar Newtonsoft.Json
builder.Services.AddControllers().AddNewtonsoftJson();

var app = builder.Build();



app.MapGet("/Artistas", ([FromServices] DAL<Artista> dal) =>
{
    return Results.Ok(dal.Listar());
});

app.MapGet("/Artistas/{nome}", ([FromServices] DAL<Artista> dal, string nome) =>
{
    var artista = dal.RecuperarPor(a => a.Nome.ToUpper().Equals(nome.ToUpper()));
    if (artista is null)
    {
        return Results.NotFound();
    }
    return Results.Ok(artista);
});

app.MapPost("/Artistas", ([FromServices] DAL<Artista> dal, [FromBody] Artista artista) =>
{
    dal.Adicionar(artista);
    return Results.Ok();
});

app.MapDelete("/Delete/{id}", ([FromServices] DAL<Artista> dal,int id ) =>
{
    var artista = dal.RecuperarPor(a=>a.Id == id);
    if (artista is null)
    {
        return Results.NotFound();

    }
    dal.Deletar(artista);
    return Results.NoContent();
});

app.Run();
