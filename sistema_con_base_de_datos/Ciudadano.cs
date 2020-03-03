using System;
using System.Collections.Generic;
using System.Text;

namespace sistema_con_base_de_datos
{
    class Ciudadano
    {
        protected string name;
        protected int age;
        protected long dni;

        public Ciudadano(string name, int age, long dni)
        {
            this.name = name;
            this.age = age;
            this.dni = dni;
        }

        public void SetName(string newName)
        {
            this.name = newName;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetAge(int newAge)
        {
            this.age = newAge;
        }

        public int GetAge()
        {
            return this.age;
        }
        
        public void SetDni(long newDni)
        {
            this.dni = newDni;
        }

        public long GetDni()
        {
            return this.dni;
        }
    }
}
