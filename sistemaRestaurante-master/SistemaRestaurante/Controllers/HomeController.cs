using SistemaRestaurante.DAL;
using SistemaRestaurante.Models;
using System.Linq;
using System.Web.Mvc;

namespace SistemaRestaurante.Controllers
{
    /// <summary>
    /// Classe responsavel por controlar o que acontece na Home.
    /// </summary>
    public class HomeController : Controller
    {
        private Contexto db = new Contexto();

        /// <summary>
        /// Esse metodo faz com que a view principal seja renderizada.
        /// </summary>
        /// <returns> View Index. </returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Esse metodo faz com a a view Restaurantes seja renderizada.
        /// </summary>
        /// <returns> View Restaurantes. </returns>
        public ActionResult Restaurantes()
        {
            return View(db.Restaurantes.ToList());
        }

        /// <summary>
        /// Esse metodo faz com a a view Pratos seja renderizada.
        /// </summary>
        /// <returns> View Pratos. </returns>
        public ActionResult Pratos()
        {
            var pratos = from prt in db.Pratos
                         join rst in db.Restaurantes
                            on prt.RestauranteID equals rst.RestauranteID
                         select prt;

            return View(pratos.ToList());

        }

    }
}