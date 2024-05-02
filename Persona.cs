using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrucoTrato
{
    internal class Persona
    {
        int age;
        string name;
        int height;
        string type;

        public Persona(int age, string name, int height , string type)
        {
            this.age = age;
            this.name = name;
            this.height = height;
            this.type = type.ToUpper();
        }




        public string getTipo()
        {
            return this.type;
        }
        public string getNombre()
        {
            return this.name;
        }

        public int getEdad()
        {
            return this.age;
        }

        public int getAltura()
        {
            return this.height;
        }

    }
}
