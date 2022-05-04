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
    /// Lógica de interacción para Docente.xaml
    /// </summary>
    public partial class Docente : Window
    {
        public Docente()
        {
            InitializeComponent();
        }
        static CapaNegocio.Docente docente = new CapaNegocio.Docente();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            docente.Apellidos = txtApellidos.Text.Trim();
            docente.Nombres = txtNombres.Text.Trim();
            docente.Codigo = txtCodigo.Text.Trim();
            docente.Domicilio = txtDomicilio.Text.Trim();
            docente.Correo = txtCorreo.Text.Trim();
            docente.FechaNac = (DateTime)dtpFechaNac.SelectedDate;

            if (cboLugarNac.SelectedIndex >= 0)
            {
                docente.LugarNac = cboLugarNac.Text;
            }
            else MessageBox.Show("Seleccione una ciudad correcta");

            if (cboFacultad.SelectedIndex >= 1)
            {
                docente.Facultad = cboFacultad.Text;
            }
            else MessageBox.Show("Seleccione una Facultad correcta");

            if (cboTemas.SelectedIndex >= 0)
            {
                docente.Temas = cboTemas.Text;
            }
            else MessageBox.Show("Seleccione un ambiente correcto");
            MessageBox.Show("Los datos del objeto docente fueron registrados correctamente", "Agregar alumno");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Apellidos: " + docente.Apellidos + "\nNombre: " + docente.Nombres
                            + "\nCodigo: " + docente.Codigo + "\nDomicilio: " + docente.Domicilio
                             + "\nCorreo: " + docente.Correo + "\nLugar de Nacimiento: " + docente.
                             LugarNac + "\nFacultad: " + docente.Facultad + "\nFecha de Nacimiento: " +
                             docente.FechaNac +  "\nTemas: " + docente.Temas, "Registro");
        }
    }
}
