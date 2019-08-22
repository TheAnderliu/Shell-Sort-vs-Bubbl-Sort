using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPUTACIONAL_WPF
{
    class CAlgoritmoShell
    {
        public int[] ArrShell;

       public void OrdenarShell(int []Arr, int N) {

           int pasos, i, temp;
           for (int cont = N / 2; cont != 0; cont /= 2)
           {
               for (pasos = 1; pasos != 0; )
               {
                   pasos = 0;
                   for (i = cont; i < N; i++)

                       if (Arr[i - cont] > Arr[i])
                       {
                           temp = Arr[i];
                           Arr[i] = Arr[i - cont];
                           Arr[i - cont] = temp;
                           pasos++;
                       }
               }
           }

           ArrShell = Arr;

        }
       
       public int[] arrShell
       {
           get { return ArrShell; }
           set { ArrShell = value; }
       }


    }
}
