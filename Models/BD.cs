using System.Data.SqlClient;
using Dapper;
namespace TP06;
class BD{
 private static string _connectionString=@"Server=.;DataBase=BaseTP09;Trusted_Connection=True;";


 public static bool VerificarDatos(string username,string contraseña){

    string query="SELECT * FROM Usuarios WHERE Username=@bUsername AND Constraseña=@bContraseña";
    string result=" ";

    using(SqlConnection BD=new SqlConnection(_connectionString)){
        result=BD.QueryFirstOrDefault<Partido> (query,new{bContraseña=contraseña});
    }

    if (result=" ")
    {
        return false;
    }else {
        return true;

    }

 }

 public static void Registrarse(Usuario u){
    

 }
}