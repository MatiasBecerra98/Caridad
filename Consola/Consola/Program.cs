using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            mostar();
        }

        private static void mostar()
        {
            Conexion conexion = new Conexion();
            List<User> listita = new List<User>();
            listita = conexion.Select("SELECT * FROM prueba");

            foreach (User item in listita)
            {
                Console.WriteLine("ID : {0} \nNombre : {1} \nApellido : {2} \n Rut : {3}",item.id,item.nombre,item.apellido,item.rut);
            }
            Console.ReadKey();
        }
    }
}
