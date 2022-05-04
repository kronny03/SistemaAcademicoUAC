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

namespace CapaPresentación
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            // Llamar al formulario Administrativo
            Mantenimiento.Administrativo frm = new Mantenimiento.Administrativo();
            frm.Show();
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            // Llamar al formulario Administrativo
            Mantenimiento.Docente frm = new Mantenimiento.Docente();
            frm.Show();
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            // Llamar al formulario Administrativo
            Mantenimiento.Alumno frm = new Mantenimiento.Alumno();
            frm.Show();
        }
    }
}
