using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using Fibonacci.Class;

namespace Fibonacci
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.txtnummin.PreviewTextInput += new TextCompositionEventHandler(txtnummin_PreviewTextInput);
            this.txtnummax.PreviewTextInput += new TextCompositionEventHandler(txtnummax_PreviewTextInput);
           
        }

        public Primenumbers primenumbers = new Primenumbers();
        List<int> ls = new List<int>();
        List<int> fib = new List<int>();

        private void btncom_Click(object sender, RoutedEventArgs e)
        {
            txtresult.Clear();
            int x = Convert.ToInt32(txtnummin.Text);
            int y = Convert.ToInt32(txtnummax.Text);
            ls.Clear();

            ////поиска значений во вторичном потоке
            //var thread = new Thread(() => primenumbers.Res(x, y));
            //thread.Start();
            //thread.Join();


            //----------------------------------------------------------------------------

            // System.PlatformNotSupportedException:“Operation is not supported on this platform.”

            //Func<int, int, List<int>> myFunc = new Func<int, int, List<int>>(primenumbers.Res);
            //IAsyncResult asyncResult = myFunc.BeginInvoke(x, y, null, null);

            //Получение результата асинхронной модели в контексте вторичного потока
            //ls = myFunc.EndInvoke(asyncResult);

            //----------------------------------------------------------------------------


            Task task = Task.Run(() => ls = primenumbers.Res(x, y));
            task.Wait();

            // поиска значений в первичном потоке
            //ls = primenumbers.Res(x, y);

            foreach (var list in ls)
            {
                txtresult.Text += list + " ";
            }
        }

        private void btnclr_Click(object sender, RoutedEventArgs e)
        {
            txtresult.Clear();
            txtnummax.Clear();
            txtnummin.Text = "2";
        }

        //проверка на ввод только чисел
        private void txtnummin_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text,0)) e.Handled = true;
        }

        private void txtnummax_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text,0)) e.Handled = true;
        }

        //private void txtnummin_MouseEnter(object sender, MouseEventArgs e)
        //{
            
        //}

        private void txtnummin_MouseLeave(object sender, MouseEventArgs e)
        {
            if (txtnummin.Text == string.Empty)
                txtnummin.Text = 2.ToString();
        }

        private void btncomfib_Click(object sender, RoutedEventArgs e)
        {
            
            txtresultfib.Clear();

            Class.Fibonacci fibonacci = new Class.Fibonacci();
            
            //ls.ForEach(delegate(int s)
            //{
            //    fib.Add(s);
            //    fibonacci.res.Add(s);
            //});


            int x = Convert.ToInt32(txtnumfib.Text);
           var thread = new Thread(() => fibonacci.Method(x)) { IsBackground = true };

            thread.Start();
            //thread.Join();

            //Task task = Task.Run(() => fibonacci.Method(x)) ;
            //task.Wait();

            foreach (var list in fibonacci.res)
            {
                txtresultfib.Text += list + " ";
            }
        }

        private void btnclrfib_Click(object sender, RoutedEventArgs e)
        {
            txtresultfib.Clear();
            txtnumfib.Clear();
        }
    }
}
