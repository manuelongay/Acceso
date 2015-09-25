using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Login.Models;

namespace Login.Controllers
{
    public class usuarioController : Controller
    {
        //
        // GET: /usuario/
        pruebasvsEntities1 bdusuario = new pruebasvsEntities1();
        public ActionResult Index()
        {
            var rsql= from r in bdusuario.catusuarios select new Usuario {
                          IdUsuario= r.IdUsuario,
                          NomUsuario= r.NomUsuario,
                          IdSociedad= r.IdSociedad
                      };
            return View(rsql.ToList());
        }

    }
}
