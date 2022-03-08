using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial;

namespace Parcial
{
    public class Crud
    {
        List<Users> listUsuario = new List<Users>();
        int id;
        string nombres;
        string apellidos;

        public void crearUsuario()
        {
            Console.WriteLine("--------> Agregar Usuario <-----------");



            Console.WriteLine("Ingrese identificacion: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese sus nombre");
            nombres = Console.ReadLine();
            Console.WriteLine("Ingrese sus apellidos: ");
            apellidos = Console.ReadLine();


            listUsuario.Add(new Users(id, nombres, apellidos));

            Console.WriteLine("\n");
            Console.WriteLine("Datos guardados");
        }
        private bool listaVacia()
        {
            if (listUsuario.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void lista()
        {
            if (listaVacia() == true)
            {
                Console.WriteLine("No se encuentra ningun dato en la lista");
            }
            else
            {
                Console.WriteLine("Total de registros estudiante: " + listUsuario.Count);
                Console.WriteLine("Lista");
                foreach (Users item in listUsuario)
                {
                    imprimir(item);
                }
            }
        }
        private void imprimir(Users dato)
        {
            
                
                Console.WriteLine("Identificacion : {0}  Nombres:  {1}  Apellidos {2} ", dato.id, dato.nombres, dato.apellidos );
            




            
        }

    } 
}

