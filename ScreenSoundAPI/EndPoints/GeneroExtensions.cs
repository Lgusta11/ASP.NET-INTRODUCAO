using Microsoft.AspNetCore.Mvc;
using ScreenSound.Banco;
using ScreenSound.Modelos;
using ScreenSound.Shared.Modelos.Modelos;
using ScreenSoundAPI.Requests;

namespace ScreenSoundAPI.EndPoints
{
    public static class GeneroExtensions
    {
        public static void AddEndPointsGenero(this WebApplication app)
        {
            #region Endpoint Genero
            app.MapGet("/Genero", ([FromServices] DAL<Genero> dal) =>
            {
                return Results.Ok(dal.Listar());
            });

            app.MapGet("/Genero/{nome}", ([FromServices] DAL<Genero> dal, string nome) =>
            {
                var genero = dal.RecuperarPor(a => a.Nome.ToUpper().Equals(nome.ToUpper()));
                if (genero is null)
                {
                    return Results.NotFound();
                }
                return Results.Ok(genero);

            });

            app.MapPost("/Genero", ([FromServices] DAL<Genero> dal, [FromBody] GeneroRequest generoRequest) =>
            {
                var genero = new Genero(generoRequest.nome, generoRequest.Descricao);
                dal.Adicionar(genero);
                return Results.Ok();
            });

            app.MapDelete("/Genero/{id}", ([FromServices] DAL<Genero> dal, int id) => {
                var genero = dal.RecuperarPor(a => a.Id == id);
                if (genero is null)
                {
                    return Results.NotFound();
                }
                dal.Deletar(genero);
                return Results.NoContent();

            });

            app.MapPut("/Genero", ([FromServices] DAL<Genero> dal, [FromBody] GeneroRequestEdit generoRequestEdit) => {
                var generoAAtualizar = dal.RecuperarPor(a => a.Id == generoRequestEdit.Id);
                if (generoAAtualizar is null)
                {
                    return Results.NotFound();
                }
                generoAAtualizar.Nome = generoRequestEdit.nome;
                generoAAtualizar.Descricao = generoRequestEdit.Descricao;


                dal.Atualizar(generoAAtualizar);
                return Results.Ok();




            });
            #endregion

        }
    }
}
