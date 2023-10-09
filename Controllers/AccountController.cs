using Microsoft.AspNetCore.Mvc;

namespace TP09.Controllers;

public class AccountController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Login(){
        ViewBag.Error="";
        return View();
    }
    public IActionResult Registrarse(){
        ViewBag.Error="";
        return View();
    }
    public IActionResult OlvidoContraseña(){
        ViewBag.Error="";
        return View();
    }
    public IActionResult VerificarLogin(string Username,string Contraseña){
        if(BD.VerificarDatos(Username,Contraseña)){
            return RedirectToAction("pagina");
        }else{
            ViewBag.Existe=true;
            return View("Login");
        }

    }
    public IActionResult VerificarRegistrarse(Usuario U){

        if(BD.VerificarUsername(U.username)){
        ViewBag.Error="Ese nombre de usuario ya está en uso, elegir otro";
            return View("Registrarse");
        }else{
            BD.Registrarse(U);
            return RedirectToAction("pagina");
        }

    }
    public IActionResult pagina(){
        return View();
    }
    public IActionResult ModificarContraseña(string Username, string Contraseña){
        if(BD.VerificarUsername(Username)){
            BD.CambiarContraseña(Contraseña,Username);
            Console.WriteLine("bien");
            ViewBag.Error="Contraseña modificada correctamente";
            return View("login");
        }else{
            Console.WriteLine("mal");
            ViewBag.Error="No existe un usuario con ese username";
            return RedirectToAction("OlvidoContraseña");

        }
    }

}
