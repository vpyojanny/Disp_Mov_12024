namespace MediaBooking.Screens;
using System.Collections.ObjectModel;

public partial class Productos : TabbedPage
{

    public ObservableCollection<DetProductos> ListaProductos { get; set; }
    public Productos()
	{
        IniciarDatos();
        InitializeComponent();

        listaProductos.ItemsSource = ListaProductos;
        
	}
    public class DetProductos
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public string Tipo { get; set; }

        public int Cantidad { get; set; }

    }

    private void IniciarDatos()
    {
        ListaProductos = new ObservableCollection<DetProductos>
        {
            new() {
                Nombre = "Proyector",
                Descripcion = "Proyector Epson 720p",
                Tipo = "Audiovisual",
                Cantidad = 10,


            },

            new() {
                Nombre = "Laptop",
                Descripcion = "Laptop Dell Latitude 16GB RAM",
                Tipo = "Audiovisual",
                Cantidad = 10,


            },
            new() {
                Nombre = "Cable HDMI",
                Descripcion = "Cable HDMI 2.3m",
                Tipo = "Conexión",
                Cantidad = 10,


            }


        };

        }
}