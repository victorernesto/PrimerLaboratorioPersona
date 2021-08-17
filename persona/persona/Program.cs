using persona.Entidades;
using persona.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persona
{
    class Program
    {
        static void Main(string[] args)
        {
            Clspersona clspersona = new Clspersona();
            NClspersona nClspersona = new NClspersona();

            Console.WriteLine(nClspersona.ablando(clspersona));
            

            Console.ReadLine();
        }
    }
}
