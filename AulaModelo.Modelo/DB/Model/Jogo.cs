using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaModelo.Modelo.DB.Model
{
    public class Jogo
    {
        public static List<Jogo> Jogos = new List<Jogo>() {
            new Jogo {
                Id = Guid.NewGuid(),
                Titulo = "Jogo 1",
                DtLancamento = new DateTime(),
                Genero = "Genero 1",
                Estudio = "Estudio 1"
            },
            new Jogo {
                Id = Guid.NewGuid(),
                Titulo = "Jogo 2",
                DtLancamento = new DateTime(),
                Genero = "Genero 2",
                Estudio = "Estudio 2"
            },
            new Jogo {
                Id = Guid.NewGuid(),
                Titulo = "Jogo 3",
                DtLancamento = new DateTime(),
                Genero = "Genero 3",
                Estudio = "Estudio 3"
            },
            new Jogo {
                Id = Guid.NewGuid(),
                Titulo = "Jogo 4",
                DtLancamento = new DateTime(),
                Genero = "Genero 4",
                Estudio = "Estudio 4"
            },
            new Jogo {
                Id = Guid.NewGuid(),
                Titulo = "Jogo 5",
                DtLancamento = new DateTime(),
                Genero = "Genero 5",
                Estudio = "Estudio 5"
            },
            new Jogo {
                Id = Guid.NewGuid(),
                Titulo = "Jogo 6",
                DtLancamento = new DateTime(),
                Genero = "Genero 6",
                Estudio = "Estudio 6"
            },
            new Jogo {
                Id = Guid.NewGuid(),
                Titulo = "Jogo 7",
                DtLancamento = new DateTime(),
                Genero = "Genero 7",
                Estudio = "Estudio 7"
            },
        };

        public Guid Id { get; set; }
        public String Titulo { get; set; }
        public DateTime DtLancamento { get; set; }
        public String Genero { get; set; }
        public String Estudio { get; set; }


    }
}
