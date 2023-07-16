using HotelABC.Context;
using HotelABC.Services;
using HotelABC.Vistas;
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
using static HotelABC.Services.Login;

namespace HotelABC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
   
    public partial class MainWindow : Window
    {
        private readonly AuthService _authService;

        public MainWindow()
        {
            InitializeComponent();

            // Crear una instancia del contexto de la base de datos
            var dbContext = new ApplicationDbContext();

            // Crear una instancia del servicio de autenticación
            _authService = new AuthService(dbContext);
        }
  
        RegistrarEmpleados ventanaregistrar = new RegistrarEmpleados();
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtusuario.Text;
            string password = txtcontraseña.Text;

            bool accesoValido = _authService.ValidarAcceso(username, password);

            if (accesoValido)
            {
                MessageBox.Show("Acceso correcto", "Inicio de sesión", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
                ventanaregistrar.Show();
                
            }
            else
            {
                MessageBox.Show("Acceso incorrecto", "Inicio de sesión", MessageBoxButton.OK, MessageBoxImage.Error);
                // Realizar las acciones adicionales después del inicio de sesión incorrecto
            }


        }
    }
}
