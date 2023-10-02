public class Usuario{
    public string username{get;set;}
    public string contraseña{get;set;}
    public DateTime fechaNacimiento{get;set;}
    public string email{get;set;}
    public string telefono{get;set;}

    public Usuario() {
    }

    public Usuario(string Username, string Contraseña, DateTime FechaNacimiento,string Email, string Telefono){
        username=Username;
        contraseña=Contraseña;
        fechaNacimiento=FechaNacimiento;
        email=Email;
        telefono=Telefono;
    }
}