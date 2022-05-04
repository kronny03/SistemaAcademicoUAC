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
    /// Lógica de interacción para Alumno.xaml
    /// </summary>
    public partial class Alumno : Window
    {
        public Alumno()
        {
            InitializeComponent();
        }
        // Declarar objeto
        static CapaNegocio.Alumno alumno = new CapaNegocio.Alumno();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Asignar las propiedades al objeto administrativo
            alumno.Apellidos = txtApellidos.Text.Trim();
            alumno.Nombres = txtNombres.Text.Trim();
            alumno.Codigo = txtCodigo.Text.Trim();
            alumno.Domicilio = txtDomicilio.Text.Trim();
            alumno.Correo = txtCorreo.Text.Trim();
            alumno.FechaNac = (DateTime)dtpFechaNac.SelectedDate;

            if (cboLugarNac.SelectedIndex >= 0)
            {
                alumno.LugarNac = cboLugarNac.Text;
            }
            else MessageBox.Show("Seleccione una ciudad correcta");

            if (cboEscuela.SelectedIndex >= 1)
            {
                alumno.Escuela = cboEscuela.Text;
            }
            else MessageBox.Show("Seleccione una escuela correcta");

            if (cboSeguro.SelectedIndex >= 0)
            {
                alumno.Seguro = cboSeguro.Text;
            }
            else MessageBox.Show("Seleccione un seguro correcto");

            MessageBox.Show("Los datos del objeto alumno fueron registrados correctamente", "Agregar alumno");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Apellidos: " + alumno.Apellidos + "\nNombre: " + alumno.Nombres
                + "\nCodigo: " + alumno.Codigo + "\nDomicilio: " + alumno.Domicilio
                 + "\nCorreo: " + alumno.Correo + "\nLugar de Nacimiento: " + alumno.
                 LugarNac + "\nEscuela Profesional: " + alumno.Escuela + "\nFecha de Nacimiento: " +
                 alumno.FechaNac.ToString() + "\nSeguro Estudiantil: " + alumno.Seguro + "Registro");
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // Llamar al método del objeto
            MessageBox.Show(alumno.Actualizar(). ToString()); 
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            // Llamar al método del objeto
            MessageBox.Show(alumno.Listar());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            // Llamar al método del objeto
            MessageBox.Show(alumno.Estudiar());
        }
    }
}
