using AulaModelo.Modelo.DB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AulaModelo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(Jogo.Jogos);
        }

        public ActionResult InserirJogo()
        {
            return View("AlterarJogo", new Jogo());
        }

        public ActionResult AlterarJogo(Guid id)
        {
            var jogo = Jogo.Jogos.FirstOrDefault(f => f.Id == id);

            if (jogo != null)
            {
                return View("AlterarJogo", jogo);
            }

            return RedirectToAction("Index");
        }

        public ActionResult GravarJogo(Jogo jogo)
        {
            if(jogo.Id.ToString() == "00000000-0000-0000-0000-000000000000")
            {
                jogo.Id = new Guid();
                Jogo.Jogos.Add(jogo);
            }
            else
            {
                var p = Jogo.Jogos.FirstOrDefault(f => f.Id == jogo.Id);
                p.Titulo = jogo.Titulo;
                p.DtLancamento = jogo.DtLancamento;
                p.Genero = jogo.Genero;
                p.Studio = jogo.Studio;
            }
                        
            return RedirectToAction("Index");
        }

        public ActionResult ApagarJogo(Guid id)
        {
            Jogo p = null;

            foreach (var jogo in Jogo.Jogos)
            {
                if(jogo.Id == id)
                {
                    p = jogo;
                    break;
                }
            }

            if(p != null)
            {
                Jogo.Jogos.Remove(p);
            }

            return RedirectToAction("Index");
        }

        public ActionResult DetalharJogo(Guid id)
        {
            var jogo = Jogo.Jogos.FirstOrDefault(f => f.Id == id);

            if (jogo != null)
            {
                return View("DetalharJogo", jogo);
            }

            return RedirectToAction("Index");
        }

    }

}