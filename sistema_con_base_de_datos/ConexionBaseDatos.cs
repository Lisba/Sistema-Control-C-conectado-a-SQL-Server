using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace sistema_con_base_de_datos
{
    class ConexionBaseDatos
    {
        public static void Create()
        {
            Console.WriteLine("Creando la tabla \"ciudadanos\"...");

            string create = @"CREATE TABLE ciudadanos (
                                id INT IDENTITY PRIMARY KEY ,
                                name VARCHAR(40) NOT NULL,
                                age INT NOT NULL,
                                dni INT NOT NULL
                                 )";

            SqlConnection conexion = new SqlConnection("server=DESKTOP-LOSRLP7; database=base1; integrated security=true");
            conexion.Open();
            
            SqlCommand comando = new SqlCommand(create, conexion);

            comando.ExecuteNonQuery();
            
            conexion.Close();
        }

        public static void Insert(string name, int age, long dni)
        {
            Console.WriteLine("Insertando datos en la tabla \"ciudadanos\"...");

            string insert = $"INSERT INTO ciudadanos VALUES ('{name}', {age}, {dni})";

            SqlConnection conexion = new SqlConnection("server=DESKTOP-LOSRLP7; database=base1; integrated security=true");
            conexion.Open();
            
            SqlCommand comando = new SqlCommand(insert, conexion);
            comando.ExecuteNonQuery();
            
            conexion.Close();
        }

        public static void Delete(string name)
        {
            Console.WriteLine("Eliminando datos de la tabla \"ciudadanos\"...");

            string insert = $"DELETE FROM ciudadanos WHERE name = '{name}'";

            SqlConnection conexion = new SqlConnection("server=DESKTOP-LOSRLP7; database=base1; integrated security=true");
            conexion.Open();

            SqlCommand comando = new SqlCommand(insert, conexion);
            comando.ExecuteNonQuery();

            conexion.Close();
        }

        public static void Delete(long dni)
        {
            Console.WriteLine("Eliminando datos de la tabla \"ciudadanos\"...");

            string insert = $"DELETE FROM ciudadanos WHERE dni = {dni}";

            SqlConnection conexion = new SqlConnection("server=DESKTOP-LOSRLP7; database=base1; integrated security=true");
            conexion.Open();

            SqlCommand comando = new SqlCommand(insert, conexion);
            comando.ExecuteNonQuery();

            conexion.Close();
        }

        public static void Update(long dni, long newDni)
        {
            Console.WriteLine("Eliminando datos de la tabla \"ciudadanos\"...");

            string insert = $"UPDATE ciudadanos SET dni = {newDni} WHERE dni = {dni}";

            SqlConnection conexion = new SqlConnection("server=DESKTOP-LOSRLP7; database=base1; integrated security=true");
            conexion.Open();

            SqlCommand comando = new SqlCommand(insert, conexion);
            comando.ExecuteNonQuery();

            conexion.Close();
        }

        public static void Update(string name, string newName)
        {
            Console.WriteLine("Actualizando datos en la tabla \"ciudadanos\"...");

            string insert = $"UPDATE ciudadanos SET name = '{newName}' WHERE name = '{name}'";

            SqlConnection conexion = new SqlConnection("server=DESKTOP-LOSRLP7; database=base1; integrated security=true");
            conexion.Open();

            SqlCommand comando = new SqlCommand(insert, conexion);
            comando.ExecuteNonQuery();

            conexion.Close();
        }
    }
}
