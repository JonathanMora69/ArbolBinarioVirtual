using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinarioVirtual.clases
{
    internal class Context
    {
        public static Arbol estado_raiz;

        public static void agregarNodo( Arbol nodo , string nombre_archivo , decimal tamaño )
        {
            if( estado_raiz == null ) 
            {   
                estado_raiz.nombre_archivo = nombre_archivo;
                decimal size = tamaño / 512;
                int totalInstancias = (int)Math.Ceiling(size);
                
                List<Sector> lista = new List<Sector>();
                decimal contador = tamaño; // 600
                for( int i = 0; i < totalInstancias; i++ )
                {
                    Sector nuevo_secotr = new Sector();
                    nuevo_secotr.espacio = i;
                    lista.Add(nuevo_secotr );
                    if( contador >= 512 )
                    {
                        contador -= 512;
                    }
                }

                //estado_raiz.sectores.Add()
                return;
            }

            int comparacion = string.Compare(nombre_archivo, nodo.nombre_archivo);

            if( comparacion < 0 )
            {
                // nombre_archivo es menor al actual
                agregarNodo(nodo.izquierdo, nombre_archivo , tamaño);
            }
            if (comparacion > 0)
            {
                // nombre_archivo es mayor al actual
                agregarNodo(nodo.derecha, nombre_archivo, tamaño);
            }

        }
    }
}
