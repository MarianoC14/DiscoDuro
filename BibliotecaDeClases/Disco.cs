using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Disco
    {
        public ArrayList Archivos1, Archivos2, Archivos3, Archivos4, Archivos5;
        public List<int> tamArch1 = new List<int>(), tamArch2, tamArch3, tamArch4, tamArch5;
        public int[] tamanio = new int[5];
        public int mochadas, tamanioDisco, tamanioArchivo, tamanioMochada, numPart;
        public int[] uso = new int[5];
        public int[] contador = new int[5] {0,0,0,0,0};
        public string nombreArchivo;
        public void Establecer_Partituras(int tamanioDD, int mochadas, int tamanio1, int tamanio2, int tamanio3, int tamanio4, int tamanio5)
        {
            this.tamanioDisco = tamanioDD;
            this.mochadas = mochadas;
            this.tamanio[0] = tamanio1;
            this.tamanio[1] = tamanio2;
            this.tamanio[2] = tamanio3;
            this.tamanio[3] = tamanio4;
            this.tamanio[4] = tamanio5;  
        }
        public void Guardar(object numPart, object Nombre, object TamArch)
        {
            this.tamanioArchivo = Convert.ToInt32(TamArch);
            this.numPart = Convert.ToInt32(numPart);
            this.nombreArchivo = Convert.ToString(Nombre);
            switch (numPart)
            {
                case 1: Archivos1.Add(nombreArchivo);tamArch1.Add(tamanioArchivo);contador[0]++;
                    break;
                case 2:
                    Archivos2.Add(nombreArchivo); tamArch2.Add(tamanioArchivo); contador[1]++;
                    break;
                case 3:
                    Archivos3.Add(nombreArchivo); tamArch3.Add(tamanioArchivo); contador[2]++;
                    break;
                case 4:
                    Archivos4.Add(nombreArchivo); tamArch4.Add(tamanioArchivo); contador[3]++;
                    break;
                case 5:
                    Archivos5.Add(nombreArchivo); tamArch5.Add(tamanioArchivo); contador[4]++;
                    break;
            }
 
        }
        public void Eliminar(int numPart, string nombreArch)
        {
            this.nombreArchivo = nombreArch;
            switch (numPart)
            {
                case 1:
                    for (int i = 0; i < contador [0]; i++)
                    {
                        if (Archivos1[i] == nombreArchivo)
                        {
                            Archivos1.Remove(i);
                            tamArch1.Remove(i);
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < contador[1]; i++)
                    {
                        if (Archivos1[i] == nombreArchivo)
                        {
                            Archivos2.Remove(i);
                            tamArch2.Remove(i);
                        }
                    }
                    break;
                case 3:
                    for (int i = 0; i < contador[2]; i++)
                    {
                        if (Archivos1[i] == nombreArchivo)
                        {
                            Archivos3.Remove(i);
                            tamArch3.Remove(i);
                        }
                    }
                    break;
                case 4:
                    for (int i = 0; i < contador[3]; i++)
                    {
                        if (Archivos1[i] == nombreArchivo)
                        {
                            Archivos4.Remove(i);
                            tamArch4.Remove(i);
                        }
                    }
                    break;
                case 5:
                    for (int i = 0; i < contador[4]; i++)
                    {
                        if (Archivos1[i] == nombreArchivo)
                        {
                            Archivos5.Remove(i);
                            tamArch5.Remove(i);
                        }
                    }
                    break;
            }
        }
        public void Mostrar()
        {

            int[] Tamanio1 = tamArch1.ToArray();

            //Partitura 1
            int uso = 0;
            for (int i = 0; i < contador[0]; i++)
            {
                uso = uso + tamArch1[i];
            }
            this.uso[0] = uso;
            //Partitura 2
            uso = 0;
            for (int i = 0; i < contador[1]; i++)
            {
                uso = uso + Convert.ToInt32(tamArch2[i]);
            }
            this.uso[1] = uso;
            //Partitura 3
            uso = 0;
            for (int i = 0; i < contador[2]; i++)
            {
                uso = uso + Convert.ToInt32(tamArch3[i]);
            }
            this.uso[2] = uso;
            //Partituras 4
            uso = 0;
            for (int i = 0; i < contador[3]; i++)
            {
                uso = uso + Convert.ToInt32(tamArch4[i]);
            }
            this.uso[3] = uso;
            //Partituras 5
            uso = 0;
            for (int i = 0; i < contador[4]; i++)
            {
                uso = uso + Convert.ToInt32(tamArch5[i]);
            }
            this.uso[4] = uso;
        }
        public Disco()
        {
            tamArch1 = new List <int>();
        }
    }
}
