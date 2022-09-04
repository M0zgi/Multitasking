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

        private void btncom_Click(object sender, RoutedEventArgs e)
        {
            txtresult.Clear();
            int x = Convert.ToInt32(txtnummin.Text);
            int y = Convert.ToInt32(txtnummax.Text);
            ls.Clear();


            ls = primenumbers.Res(x, y);

            foreach (var list in  ls)
            {
                txtresult.Text += list + " ";
            }
        }

        private void btnclr_Click(object sender, RoutedEventArgs e)
        {
            txtresult.Clear();
            txtnummax.Clear();
            txtnummax.Text = "2";
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
    }
}
