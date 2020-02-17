using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Arreglo_ASP.Controllers
{
    public class Controlador_ArregloController : Controller
    {
        // GET: Controlador_Arreglo
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Enviar(int value0, int value1, int value2, int value3, int value4, int value5, int value6, int value7,
            int value8, int value9)
        {

            int[] numero;
            numero = new int[10];

            numero[0] = value0;
            numero[1] = value1;
            numero[2] = value2;
            numero[3] = value3;
            numero[4] = value4;
            numero[5] = value5;
            numero[6] = value6;
            numero[7] = value7;
            numero[8] = value8;
            numero[9] = value9;

           
            return Content("El numero mayor es " + numero.Max() + " y el numero menor es " + numero.Min());
        }

        
    }
}