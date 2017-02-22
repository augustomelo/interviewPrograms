using SistemaRestaurante.DAL;
using SistemaRestaurante.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace SistemaRestaurante.Controllers
{
    /// <summary>
    /// Classe responsavel por controlar o que acontece na Restaurante.
    /// </summary>
    public class RestauranteController : Controller
    {
        private Contexto db = new Contexto();

        /// <summary>
        /// Metodo responsavel por renderizar a view Index, e caso seja recebido os parametros.
        /// preenche os campos na tela.
        /// </summary>
        /// <param name="id"> Id do restaurante a ser procurado.</param>
        /// <returns> View Index.</returns>
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return View();
            }

            Restaurante restaurante = db.Restaurantes.Find(id);
            
            if( restaurante == null)
            {
                return HttpNotFound();
            }

            return View(restaurante);
        }

        /// <summary>
        /// Salva o restaurante no banco de dados.
        /// </summary>
        /// <param name="restaurante"> Restaurante a ser salvo no banco de dados.</param>
        /// <returns> View Index.</returns>
        [HttpPost]
        public ActionResult SalvaRestaurante(Restaurante restaurante)
        {
            if (restaurante.RestauranteID > 0)
            {
                db.Entry(restaurante).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            db.Restaurantes.Add(restaurante);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Deleta restaurante do banco de dados.
        /// </summary>
        /// <param name="id"> ID do restaurante a ser removido.</param>
        /// <returns> View Index da Home.</returns>
        public ActionResult DeleteRestaurante(int? id)
        {
            Restaurante restaurante = db.Restaurantes.Find(id);
            db.Restaurantes.Remove(restaurante);
            //Falta remover registros dos pratos
            db.SaveChanges();
            return RedirectToAction("Restaurantes", "Home");
        }

        /// <summary>
        /// Metodo responsavel por filtrar os restaurantes da grid.
        /// </summary>
        /// <param name="form">Parametros passados no form.</param>
        /// <returns>View Index com os pratos que obedecem o filtro.</returns>
        [HttpPost]
        public ActionResult FiltraRestaurante(FormCollection form)
        {
            var restaurantes = from res in db.Restaurantes select res;
            var nome = form["nome"];

            if (!String.IsNullOrEmpty(nome))
            {
                restaurantes = restaurantes.Where(res => res.Nome.Contains(nome));
            }

            return View("../Home/Restaurantes", restaurantes.ToList());
            
        }
        
    }
}