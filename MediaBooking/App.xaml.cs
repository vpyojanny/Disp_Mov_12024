namespace MediaBooking
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Modificar este codigo a la ventana que quieren que se abra al compilar
            MainPage = new Screens.Usuarios();
        }
    }
}