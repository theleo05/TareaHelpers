using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PruebaHelp.Models
{
	public class Datos
	{

		[Required(ErrorMessage = "Este campo es Obligatorio")]
		public string cedula { get; set; }

		[Required]
		[StringLength(50)]
		public string nombre { get; set; }

		[Required]
		[StringLength(50)]
		public string apellido { get; set; }

		[Range(15, 99)]
		public string edad { get; set; }

		public string telefono { get; set; }

		[EmailAddress]
		public string mail { get; set; }

		public string genero { get; set; }

		public string estado { get; set; }

		public string hobbys { get; set; }
	}
}