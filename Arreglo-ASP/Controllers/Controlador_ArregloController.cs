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
            ViewBag.Maxi = numero.Max();
            ViewBag.Mini = numero.Min();

            ViewBag.value0 = numero[0];
            ViewBag.value1 = numero[1];
            ViewBag.value2 = numero[2];
            ViewBag.value3 = numero[3];
            ViewBag.value4 = numero[4];
            ViewBag.value5 = numero[5];
            ViewBag.value6 = numero[6];
            ViewBag.value7 = numero[7];
            ViewBag.value8 = numero[8];
            ViewBag.value9 = numero[9];

            ViewBag.sum0 = numero[0] + numero[0];
            ViewBag.sum1 = numero[1] + numero[0];
            ViewBag.sum2 = numero[2] + numero[0];
            ViewBag.sum3 = numero[3] + numero[0];
            ViewBag.sum4 = numero[4] + numero[0];
            ViewBag.sum5 = numero[5] + numero[0];
            ViewBag.sum6 = numero[6] + numero[0];
            ViewBag.sum7 = numero[7] + numero[0];
            ViewBag.sum8 = numero[8] + numero[0];
            ViewBag.sum9 = numero[9] + numero[0];

            return View();
        }


    }
}