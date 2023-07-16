using HotelABC.Context;
using HotelABC.Services;
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

namespace HotelABC.Vistas
{
    /// <summary>
    /// Lógica de interacción para AddEmp.xaml
    /// </summary>
    public partial class AddEmp : Window
    {
        private CRUDEMPLEADO _crudEmpleado;
        public AddEmp()
        {
            InitializeComponent();
            _crudEmpleado = new CRUDEMPLEADO(new ApplicationDbContext());
        }
        
     RegistrarEmpleados registrar = new RegistrarEmpleados();

        private void BtnGuardar_Click_1(object sender, RoutedEventArgs e)
        {

            string pkEmpleado = TxtPkEmpleado.Text;
            string rfc = TxtRfc.Text;
            string nombre = TxtNombre.Text;
            string apellidoPat = TxtApellidoPat.Text;
            string apellidoMat = TxtApellidoMat.Text;
            double telefono = double.Parse(TxtTelefono.Text);
            string correo = TxtCorreo.Text;
            string password = TxtPassword.Password;

            // Guardar el empleado utilizando CRUDEmpleado
            bool resultado = _crudEmpleado.AgregarEmpleado(pkEmpleado, rfc, nombre, apellidoPat, apellidoMat, telefono, correo, password);

            if (resultado)
            {
                
                MessageBox.Show("Empleado agregado correctamente.");
                this.Close();
                registrar.Show();
            }
            else
            {
                MessageBox.Show("Usuario ya existente o error al agregar el empleado.");
                this.Close();
                registrar.Show();
            }

        }
    }
}
