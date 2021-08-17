using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persona.Entidades
{
    class Clspersona
    {
        private String nombre;
        private String apellidos;
        private int edad;
        private String sexo;
        private String ablar;
        private String caminar;
        private String reir;
        private String observar;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Ablar { get => ablar; set => ablar = value; }
        public string Caminar { get => caminar; set => caminar = value; }
        public string Reir { get => reir; set => reir = value; }
        public string Observar { get => observar; set => observar = value; }
    }
}
