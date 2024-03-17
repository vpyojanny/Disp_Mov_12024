using MediaBooking.API;
using MediaBooking.Models;
using System.Collections.ObjectModel;

namespace MediaBooking.Screens;

public partial class Usuarios : ContentPage
{

    ApiService _apiService = new ApiService();

    public List<Usuario> listaUsuarios;

    public ObservableCollection<Reservaciones> ListaReservaciones { get; set; }
    public Usuarios()
	{
        IniciarDatos();
        InitializeComponent();

        

       
       
        

       
    }

  protected override async void OnAppearing()
    {
        base.OnAppearing();
        await LoadUsuarios();
        listaReservaciones.ItemsSource = listaUsuarios;
    }


    public class Reservaciones
	{
		public string Nombre { get; set; }
		public string Correo { get; set; }

		public string Telefono { get; set; }
		public string Direccion { get; set; }
		public string Rol { get; set; }

	}

    private async Task LoadUsuarios()
    {
        try
        {
            listaUsuarios = await _apiService.GetUsuariosAsync();

            if (listaUsuarios != null && listaUsuarios.Any())
            {
                
                Console.WriteLine("Conteo: " + listaUsuarios.Count);
            }
            else
            {
                Console.WriteLine(listaUsuarios);
                await DisplayAlert("Error", "No se encontraron usuarios", "Ok");
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", "Error al cargar usuarios: " + ex.Message, "Ok");
        }


    }

    public void OnClickAgregar()
    {

    }



	private void IniciarDatos()
	{
		ListaReservaciones = new ObservableCollection<Reservaciones>
        {
            new() {
                Nombre = "Omar Ureña",
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