using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace COMPUTACIONAL_WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CAlgoritmoShell algoritmoShell = new CAlgoritmoShell();
        CAlgoritmoInsercion algoritmoInsercion = new CAlgoritmoInsercion();
        public MainWindow()
        {
           
            InitializeComponent();

           /*

            int[] arr = new int[10];

            for (int i = 0; i < 10; i++)
            {
                arr[i] = i * 2;
            }

           

            for (int i = 0; i < 10; i++)
            {
                lstShell.Items.Add((i+1)+") "+(arr[i]));
            }
            
            */
    
      

        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnEjecutar_Click(object sender, RoutedEventArgs e)
        {

            


            Stopwatch stopWatch = new Stopwatch();

           
            lstArregloOriginal.Items.Clear();
            lstArregloShell.Items.Clear();
            lstArregloInsercion.Items.Clear();
            
            int N;


            N = Convert.ToInt32(txtbxNArreglo.Text);

            int[] arr = new int[N];

            int[] ArregloShell = new int[N];

            int[] ArregloInsercion = new int[N];

            Random x=new Random();

            for (int i = 0; i < N; i++)
            {
                arr[i] = x.Next(0, N + 1);
                lstArregloOriginal.Items.Add((i + 1) + ") " + (arr[i]));
                
            }
            stopWatch.Start();
            algoritmoShell.OrdenarShell(arr, N);

            stopWatch.Stop();
            txtbTiempoShell.Text = stopWatch.Elapsed.ToString("fffffff");

            stopWatch.Start();
            algoritmoInsercion.OrdenarInsercion(arr, N);
            stopWatch.Stop();
            txtbTiempoInsercion.Text = stopWatch.Elapsed.ToString("fffffff");

            ArregloInsercion = algoritmoInsercion.ArrInsercion;
            ArregloShell = algoritmoShell.ArrShell;


            for (int i = 0; i < N; i++)
            {
                lstArregloInsercion.Items.Add((i + 1) + ") " + (ArregloInsercion[i]));
                lstArregloShell.Items.Add((i + 1) + ") " + (ArregloShell[i]));
            }
            
           


        }
    }
}
