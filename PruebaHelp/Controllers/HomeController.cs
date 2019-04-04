using PruebaHelp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaHelp.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Form()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Form(Datos persona)
		{
			

			if (ModelState.IsValid) {

				persona.cedula = Request.Form["cedula"].ToString();
				persona.nombre = Request.Form["nombre"].ToString();
				persona.apellido = Request.Form["apellido"].ToString();
				persona.edad = Request.Form["edad"].ToString();
				persona.telefono = Request.Form["telefono"].ToString();
				persona.mail = Request.Form["mail"].ToString();
				persona.genero = Request.Form["genero"].ToString();
				persona.estado = Request.Form["estado"].ToString();

				return RedirectToAction("Impresion", persona);
				
			}

			return View(persona);
		}
	
		public ActionResult Impresion(Datos persona)
		{	
			return View(persona);
		}


		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult Contat()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}