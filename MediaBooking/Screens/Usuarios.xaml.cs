using Android.Net.Wifi.Aware;
using System.Collections.ObjectModel;

namespace MediaBooking.Screens;

public partial class Usuarios : TabbedPage
{

    public ObservableCollection<Reservaciones> ListaReservaciones { get; set; }
    public Usuarios()
	{
        IniciarDatos();
        InitializeComponent();

        listaReservaciones.ItemsSource = ListaReservaciones;
       
        

       
    }


	public class Reservaciones
	{
		public string Nombre { get; set; }
		public string Correo { get; set; }

		public string Telefono { get; set; }
		public string Direccion { get; set; }
		public string Rol { get; set; }

	}

	private void IniciarDatos()
	{
		ListaReservaciones = new ObservableCollection<Reservaciones>
        {
            new() {
                Nombre = "Omar Urena",
                Correo = "example@gmail.com",
                Telefono = "8092692222",
                Direccion = "Santiago",
                Rol = "Administrador"

            },
            new ()
            {
                Nombre = "Miguel Tejada",
                Correo = "example@gmail.com",
                Telefono = "8092692222",
                Direccion = "Santiago",
                Rol = "Administrador"

            },
            new ()
            {
                Nombre = "Santo Susuki",
                Correo = "example@gmail.com",
                Telefono = "8092692222",
                Direccion = "Santiago",
                Rol = "Administrador"

            }
        };
      

    }


}