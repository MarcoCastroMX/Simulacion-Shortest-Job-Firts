using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shortest_Job_First
{
    class Proceso
    {
        string Nombre;
        int Tiempo;

        public Proceso(string Nombre, int Tiempo)
        {
            this.Nombre = Nombre;
            this.Tiempo = Tiempo;
        }

        public Proceso()
        {

        }

        public string GetNombre()
        {
            return Nombre;
        }
        public int GetTiempo()
        {
            return Tiempo;
        }
        public void SetNombre(string name)
        {
             Nombre=name;
        }
        public void SetTiempo(int time)
        {
            Tiempo=time;
        }
    }
}
