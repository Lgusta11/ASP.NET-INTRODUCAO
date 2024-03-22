using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Shared.Modelos.Modelos
{
    public class Genero
    {
        public Genero()
        {
        }

        public Genero(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }

        public int Id { get; set; }
            public string? Nome { get; set; } = string.Empty;
            public string? Descricao { get; set; } = string.Empty;
            public virtual ICollection<Musica> Musicas { get; set; }
        public override string ToString()
            {
                return $"Nome: {Nome} - Descrição: {Descricao}";
            }
        }
    }

