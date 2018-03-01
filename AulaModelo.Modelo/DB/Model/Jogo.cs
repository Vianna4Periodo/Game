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
                Titulo = "Chrono Trigger",
                DtLancamento = new DateTime(),
                Genero = "RPG",
                Studio = "Square Enix"
            },
            new Jogo {
                Id = Guid.NewGuid(),
                Titulo = "Super Metroid",
                DtLancamento = new DateTime(),
                Genero = "Ação/Aventura",
                Studio = "Nintendo"
            },
            new Jogo {
                Id = Guid.NewGuid(),
                Titulo = "Donkey Kong",
                DtLancamento = new DateTime(),
                Genero = "Aventura",
                Studio = "Nintendo"
            },
            new Jogo {
                Id = Guid.NewGuid(),
                Titulo = "Zelda Breath Of The Wild",
                DtLancamento = new DateTime(),
                Genero = "Ação/Aventura/RPG",
                Studio = "Nintendo"
            },
        };

        public Guid Id { get; set; }
        public String Titulo { get; set; }
        public DateTime DtLancamento { get; set; }
        public String Genero { get; set; }
        public String Studio { get; set; }


    }
}
