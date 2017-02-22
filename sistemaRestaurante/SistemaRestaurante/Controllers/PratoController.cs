using SistemaRestaurante.DAL;
using SistemaRestaurante.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace SistemaRestaurante.Controllers
{
    /// <summary>
    /// Classe responsavel por controlar o que acontece na Prato.
    /// </summary>
    public class PratoController : Controller
    {
        private Contexto db = new Contexto();

        /// <summary>
        /// Metodo responsavel por renderizar a view Index, e caso seja recebido os parametros.
        /// preenche os campos na tela.
        /// </summary>
        /// <param name="id"> Id do prato a ser procurado.</param>
        /// <param name="nome"> Nome do restaurante relacionado.</param>
        /// <returns> View Index.</returns>
        public ActionResult Index(int? id, string nome)
        {
            if (id == null)
            {
                return View();
                
            }

            Prato prato = db.Pratos.Find(id);
            prato.Restaurante.Nome = nome;
            if (prato == null)
            {
                return HttpNotFound();
            }

            return View(prato);

        }

        /// <summary>
        /// Salva o prato no banco de dados.
        /// </summary>
        /// <param name="prato"> Prato a ser salvo no banco de dados.</param>
        /// <returns> View Index.</returns>
        [HttpPost]
        public ActionResult SalvaPrato(Prato prato)
        {
            if (prato.PratoID > 0)
            {
                db.Entry(prato).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            db.Pratos.Add(prato);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Deleta prato do banco de dados.
        /// </summary>
        /// <param name="id"> ID do prato a ser removido.</param>
        /// <returns> View Index da Home.</returns>
        public ActionResult DeleteRestaurante(int? id)
        {
            Prato prato = db.Pratos.Find(id);
            db.Pratos.Remove(prato);
            db.SaveChanges();
            return RedirectToAction("Pratos", "Home");
        }

        /// <summary>
        /// Metodo reponsvel por trazer todos os restaurantes.
        /// </summary>
        /// <returns>JSON com todos os restaurantes</returns>
        [HttpPost]
        public JsonResult PegaRestaurantes()
        {
            return Json(db.Restaurantes);
        }
    }
}