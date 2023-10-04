using Microsoft.AspNetCore.Mvc;

namespace TP09.Controllers;

public class AccountController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Login(){
        ViewBag.Existe=false;
        return View();
    }
    public IActionResult Registrarse(){
        ViewBag.Existe=true;
        return View();
    }
    public IActionResult OlvidoContraseña(){
        return View();
    }
    public IActionResult VerificarLogin(string Username,string Contraseña){
        if(BD.VerificarDatos(Username,Contraseña)){
            return RedirectToAction("pagina");
        }else{
            ViewBag.Existe=false;
            return View("Login");
        }

    }
    public IActionResult VerificarRegistrarse(Usuario U){

        if(BD.VerificarUsername(U.username)){
        ViewBag.Existe=true;
            return View("Registrarse");
        }else{
            BD.Registrarse(U);
            return RedirectToAction("pagina");
        }

    }
    public IActionResult pagina(){
        return View();
    }
}
