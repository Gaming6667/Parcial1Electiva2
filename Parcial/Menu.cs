using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    internal class Menu : Crud
    {
        string opcionMenu = "";
        public void iniciar()
        {
            //do
            //{
            principal();
            //} while (opcionMenu != "0");
        }
        private void principal()
        {
            Console.WriteLine("-----Menu Principal-------");
            Console.WriteLine("1 = Crear Usuario");
            Console.WriteLine("2 = Listar Usuario");
            Console.WriteLine("3 = Crear Blogs");
            Console.WriteLine("4 = Listar Blogs ");
            opcionMenu = Console.ReadLine();
            selectionMenu(opcionMenu);

        }
        public void selectionMenu(string op)
        {

            if (op == "")
                return;
            switch (op)
            {
                case "1":
                    Console.Clear();
                    crearUsuario();
                   Console.Clear();
                  
                    principal();
                    break;

                case "2":
                    Console.Clear();
                    lista();
                    principal();
                    break;
            }
          }
        private void retornarMenu()
        {
            string op;
            Console.WriteLine("Pressione r para retornar al menu principal");
            op = Console.ReadLine();
            selectionMenu(op);
        }

    }
}
