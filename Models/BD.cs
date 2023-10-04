using System.Data.SqlClient;
using Dapper;
namespace TP09;
class BD{
 private static string _connectionString=@"Server=.;DataBase=BaseTP09;Trusted_Connection=True;";


 public static bool VerificarDatos(string username,string contraseña){

    string query="SELECT * FROM Usuarios WHERE Username=@bUsername AND Contraseña=@bContraseña";
    Usuario result=null;

    using(SqlConnection BD=new SqlConnection(_connectionString)){
        result=BD.QueryFirstOrDefault<Usuario> (query,new{bContraseña=contraseña,bUsername=username});
    }

    if (result==null)
    {
        return false;
    }else {
        return true;

    }

 }

 public static void Registrarse(Usuario u){
    string query="INSERT INTO Usuarios(Username,Contraseña,fechaNacimiento,email,telefono) VALUES (@bUsername,@bContraseña,@bfechaNacimiento,@bemail,@btelefono)";
    using(SqlConnection BD=new SqlConnection(_connectionString)){
        BD.Execute(query,new{bContraseña=u.contraseña, bUsername=u.username, bfechaNacimiento=u.fechaNacimiento,bemail=u.email,btelefono=u.telefono});
    }
 }
 public static bool VerificarUsername(string username){

    string query="SELECT * FROM Usuarios WHERE Username=@bUsername";
    Usuario result=null;

    using(SqlConnection BD=new SqlConnection(_connectionString)){
        result=BD.QueryFirstOrDefault<Usuario> (query,new{bUsername=username});
    }

    if (result==null)
    {
        return false;
    }else {
        return true;
    }
 }

 public static void CambiarContraseña(string contraseña, string username){

    string query="UPDATE Usuarios SET Contraseña=@bContraseña WHERE Username=@bUsername";
    using(SqlConnection BD=new SqlConnection(_connectionString)){
        BD.Execute(query,new{bContraseña=contraseña, bUsername=username});
    }
 }
 
}