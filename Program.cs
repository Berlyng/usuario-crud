using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuariosCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menuPrincipal();

        }

        public static void menuPrincipal()
        {
            string opcion;
            var gestor = new ManagmentUsuario();

            do
            {
                Console.WriteLine("===== MENÚ PRINCIPAL =====");
                Console.WriteLine("1. Crear usuario");
                Console.WriteLine("2. Listar usuarios");
                Console.WriteLine("3. Editar usuario");
                Console.WriteLine("4. Eliminar usuario");
                Console.WriteLine("0. Salir");
                Console.Write("Selecciona una opción: ");

                opcion = Console.ReadLine();
                Console.WriteLine($"Elegiste: {opcion}\n");

                switch (opcion)
                {
                    case "1":
                        gestor.CrearUsuario();
                        break;

                    case "2":
                        gestor.ListarUsuarios();
                        break;

                    case "3":
                        gestor.EditarUsuario();
                        break;

                    default:
                        Console.WriteLine("Opción no implementada.\n");
                        break;
                }

            } while (opcion != "0");
        }

    }
}
