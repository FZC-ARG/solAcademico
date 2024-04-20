using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Persona
    {
        //Constructores
        public Persona() //Constructor sin parametros
        { }

        public Persona(string Nombres)
        {
            this.nombres = Nombres;
        }

        public Persona(string Nombres,string Apellidos)
        {
            this.nombres = Nombres;
            this.apellidos = Apellidos;
        }

        public Persona(string Nombres,string Apellidos, int Edad)
        {
            this.nombres = Nombres;
            this.apellidos = Apellidos;
            this.edad = Edad;
        }   


        //Declarar Atributos
        private string nombres;
        private string apellidos;
        private int edad;

        //Declarar propiedades

        public string Nombres
        {
            get { return this.nombres; }
            set { this.nombres = value; }
        }

        public string Apellidos
        {
            get { return this.apellidos; }
            set { this.apellidos = value; }
        }

        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }

        //Metodos

        public string DevolverDatos()
        {
            return "Apellidos: " + this.apellidos + " \nNombres: " + this.nombres + " \nEdad: " + Convert.ToString(this.edad);
        }
    }   
}
