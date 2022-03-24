using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using InvitacionsFesta.Models;

namespace InvitacionsFesta.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    //con HttpGet declaramos que o metodo RvspFormulario so aceptara peticions GET
    [HttpGet]
    public ViewResult RsvpFormulario()
    {
        return View();
    }

    //agora unha version overloaded que acepta un obxeto InvitacionResposta, e o atributo HttpPost que declara que manexara peticions POST
    [HttpPost]
    public ViewResult RsvpFormulario(InvitacionResposta invitacionResposta)
    {
        if (ModelState.IsValid)
        {
            Repositorio.AddResposta(invitacionResposta);
            return View("Gracinhas", invitacionResposta);
        }
        else
        {
            return View();
        }
    }

    /*usamos a propiedade Repositorio.Respostas como argumento, e filtramos os datos usando LINQ de maneira que so se mostran as respostas positivas*/
    public ViewResult ListaRespostas() => View(Repositorio.Respostas.Where(r => r.VaiAsistir == true));
    //equivalente a 
    /*
    public ViewResult ListaRespostas()
    {
        return View(Repositorio.Respostas.Where(r => r.VaiAsistir == true));
    }
    */

}
