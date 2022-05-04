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
using System.Windows.Shapes;

namespace CapaPresentación.Mantenimiento
{
    /// <summary>
    /// Lógica de interacción para Administrativo.xaml
    /// </summary>
    public partial class Administrativo : Window
    {
        public Administrativo()
        {
            InitializeComponent();
        }
        // Declarar objeto
        static CapaNegocio.Administrativo administrativo = new CapaNegocio.Administrativo();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Asignar las propiedades al objeto administrativo
            administrativo.Apellidos = txtApellidos.Text.Trim();
            administrativo.Nombres = txtNombre.Text.Trim();
            administrativo.Codigo = txtCodigo.Text.Trim();
            administrativo.Domicilio = txtDomcilio.Text.Trim();
            administrativo.Correo = txtCorreo.Text.Trim();
            administrativo.FechaNac = (DateTime)dtpFechaNac.SelectedDate;

            if (cboLugarNac.SelectedIndex >= 0)
            {
                administrativo.LugarNac = cboLugarNac.Text;
            }
            else MessageBox.Show("Seleccione una ciudad correcta");

            if (cboAmbiente.SelectedIndex >= 0)
            {
                administrativo.Ambiente = cboAmbiente.Text;
            }
            else MessageBox.Show("Seleccione un ambiente correcto");

            if (cboSueldo.SelectedIndex >= 0)
            {
                administrativo.Sueldo = cboSueldo.Text;
            }
            else MessageBox.Show("Seleccione un sueldo correcto");
            MessageBox.Show("Los datos del objeto administrativo fueron registrados correctamente", "Agregar administrativo");
        }

        private void cboFacultad_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Apellidos: " + administrativo.Apellidos + "\nNombre: " + administrativo.Nombres
                            + "\nCodigo: " + administrativo.Codigo + "\nDomicilio: " + administrativo.Domicilio
                             + "\nCorreo: " + administrativo.Correo + "\nLugar de Nacimiento: " + administrativo.
                             LugarNac +  "\nFecha de Nacimiento: " + administrativo.FechaNac.ToString() + "\nAmbiente: " + 
                             administrativo.Ambiente + "\nSueldo: " + administrativo.Sueldo, "Registro");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}
