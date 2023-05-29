
using ROLES.Models;

namespace ROLES.Data
{
    public class DA_Logica
    {
        public List<Usuario> ListaUsuarios() 
        {
            return new List<Usuario> {

                new Usuario{ Nombre = "Bryan", Correo= "BryanAdministrador@gmail.com", Clave = "123", Roles= new string[]{ "Administrador"} },
                new Usuario{ Nombre = "Manuel", Correo= "ManuelSupervisor@gmail.com", Clave = "123", Roles= new string[]{ "Supervisor"} },
                new Usuario{ Nombre = "Alejo", Correo= "AlejoEmpleado@gmail.com", Clave = "123", Roles= new string[]{ "Empleado"} },
                new Usuario{ Nombre = "Estefano", Correo= "superEmpleado@gmail.com", Clave = "123", Roles= new string[]{ "Supervisor","Empleado"} },


            };
        
        }


        public Usuario ValidarUsuario(string _correo,string _clave) {

            return ListaUsuarios().Where(item => item.Correo == _correo && item.Clave == _clave).FirstOrDefault();        
        
        }




    }
}
