using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPUTACIONAL_WPF
{
    class CAlgoritmoInsercion
    {

        public int[] ArrInsercion;
        public void OrdenarInsercion(int[] Arr, int N)
        {

            int j = 0;
            int i = 0;
            int[] temp = new int[N];
            for (i = 1; i < N; i++)
            {
                temp[i] = Arr[i];
                j = i - 1;
                while ((Arr[j] > temp[i]) && (j >= 0))
                {
                    Arr[j + 1] = Arr[j];
                    j--;
                }
                Arr[j + 1] = temp[i];

            }

            ArrInsercion = Arr;

        }


        public int[] arrInsercion
        {
            get { return ArrInsercion; }
            set { ArrInsercion = value; }
        }


    }

    



}
