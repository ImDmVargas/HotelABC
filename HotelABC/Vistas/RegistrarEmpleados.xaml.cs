using HotelABC.Context;
using HotelABC.Entieties;
using HotelABC.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para RegistrarEmpleados.xaml
    /// </summary>
    public partial class RegistrarEmpleados : Window
    {
        private ApplicationDbContext _dbContext;
        private CRUDEMPLEADO _crudEmpleado;
        public ObservableCollection<Empleado> Empleados { get; set; }


        public RegistrarEmpleados()
        {
            InitializeComponent();
            _dbContext = new ApplicationDbContext();
            _crudEmpleado = new CRUDEMPLEADO(_dbContext);

           
            ActualizarTabla();
        }
        
        private void ActualizarTabla()
        {
            _crudEmpleado.Actualizartabla();

            // Vincula la colección de empleados con el DataGrid
            DataGridEmpleados.ItemsSource = _crudEmpleado.Empleados;
        }

        private void BtnAgregarE_Click(object sender, RoutedEventArgs e)
        {
            AddEmp agregar = new AddEmp();

            this.Close();

            agregar.Show();
        }

        private void BtnModificarE_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEliminarE_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
