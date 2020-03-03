using System;
using System.Data.SqlClient;

namespace sistema_con_base_de_datos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************** SISTEMA DE CONTROL DE CIUDADANOS **********************");
            Console.WriteLine();

            string name;
            int age;
            long dni;

            Console.Write("INGRESE EL NOMBRE: ");
            name = Console.ReadLine();
            Console.Write("INGRESE LA EDAD: ");
            age = int.Parse( Console.ReadLine() );
            Console.Write("INGRESE EL DNI: ");
            dni = long.Parse( Console.ReadLine() );
            Ciudadano ciud1 = new Ciudadano(name, age, dni);

            name = "";
            age = 0;
            dni = 0;

            Console.WriteLine();
            Console.WriteLine("ALTA REALIZADA!!");
            Console.WriteLine();
            Console.WriteLine($"El ciudadano agregado recientemente es: {ciud1.GetName()} {ciud1.GetAge()} {ciud1.GetDni()}");
            Console.WriteLine();

            //ConexionBaseDatos.Insert(ciud1.GetName(), ciud1.GetAge(), ciud1.GetDni());

            //ConexionBaseDatos.Update("kEIMARLY", "KEIMARLY");

            /*Console.Write("Ingrese el nombre del ciudadano a eliminar:");
            ConexionBaseDatos.Delete( Console.ReadLine() );*/

            /*Console.Write("Ingrese el DNI del ciudadano a eliminar:");
            ConexionBaseDatos.Delete( long.Parse( Console.ReadLine() ) );*/
        }
    }
}
