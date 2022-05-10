using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest.responsabilidadUnica
{
    public class Usuario
    {
        private string nombreUsuario;
        private int id;
        private string direccion;
        private static int num = 0;

        public string NombreUsuario { get { return nombreUsuario; } }
        public int Id { get { return id; } }
        public string Direccion { get { return direccion; } }
        private Usuario(string nombreUsuario,string direccion)
        {
            this.nombreUsuario = nombreUsuario;
            this.id = ++Usuario.num;
            this.direccion = direccion;
        }

        public static Usuario registrarse(string nombreUsuario,string direccion)
        {
            return new Usuario(nombreUsuario,direccion);
        }

    }

    public static class MostrarUsuario
    {
        public static void mostrar(Usuario usuario)
        {
            Console.WriteLine(usuario.Id + ": " + usuario.NombreUsuario + " direccion: " + usuario.Direccion);
        }

    }

}
