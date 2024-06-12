using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competencia
{
    public class Competencia
    {
        public int Contador=0;
        public string[] Nombre = new string[50];
        public int[] Tiempo = new int[50];


        public void AgregarCompetidor(string nombre)
        {
            Nombre[Contador++] = nombre;
        }
        public void CargarTiempo(int i,int h,int m)
        {       
            Tiempo[i] = h * 60 + m;
        }
        static void OrdenarListado()
        {
            for(int act = 0; act < Contador - 1; act++)
            {
                for(int sig = act + 1; sig < Contador; sig++)
                {
                    if (Tiempos[act] > Tiempos[sig])
                    {

                    }
                }
            }
        }
    }
}
