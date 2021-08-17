using persona.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persona.Negocio
{
    class NClspersona
    {
        public String observar(Clspersona persona)
        {
            persona.Nombre = "Martin";
            persona.Observar = "observar";
            return " la persona " + persona.Nombre + " esta " + persona.Observar;
        }

        public String reir(Clspersona persona)
        {
            persona.Reir = "si";
            persona.Edad = 30;
            persona.Nombre = "Martin";
            return "la persona" + persona.Nombre + "de edad" + persona.Edad + "se esta riendo:" + persona.Reir;

        }
        
        public String caminar(Clspersona persona)
        {
            persona.Caminar = "si";
            persona.Nombre = "Martin";

            return "la persona" + persona.Nombre + "puede caminar:" + persona.Caminar;

        }

        public String Ablar(Clspersona persona)
        {
            persona.Nombre = "Martin";

            return "la persona " + persona.Nombre + "esta ablando";

        }


    }
}
