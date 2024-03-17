using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;

namespace MediaBooking.Screens;

public partial class Login : ContentPage
{

	public ObservableCollection<Usuarios> listaUsuarios;

	private readonly IFingerprint fingerprint;
	public Login()
	{
		InitializeComponent();
		this.fingerprint = CrossFingerprint.Current;
	}

	public string user;

	public string password;

	public class Usuarios
	{
		public string nombreUsuario { get; set; }
		public string password { get; set; }

		public bool administrador { get; set; }

	}
	private void ValidarUsuario(object sender, EventArgs e)
	{
		listaUsuarios = new ObservableCollection<Usuarios>
		{
			new()
			{
				nombreUsuario = "omarurena",
				password = "1234",
				administrador = true,
			},

			new()
			{
				nombreUsuario = "ramon",
				password = "1234",
				administrador = false,
			}
		};

		user = usuario.Text;
		password = psswd.Text;


		Usuarios usuarioEncontrado = listaUsuarios.FirstOrDefault(p => p.nombreUsuario == user);

		if (usuarioEncontrado != null)
		{
			if(password == usuarioEncontrado.password)
			{
				

                Application.Current.MainPage = new Screens.HomeAdmin();
            }
		}

	}

	private void OnToggleButtonClicked(object sender, EventArgs e)
	{
		psswd.IsPassword = !psswd.IsPassword;

	}


        private async void LoginBiometrics(object sender, EventArgs e)
	{
		var hasBiometric = await fingerprint.GetAvailabilityAsync();
		var bioType = await fingerprint.GetAuthenticationTypeAsync();

		if (hasBiometric == FingerprintAvailability.Available)
		{
			var request = new AuthenticationRequestConfiguration("Biometric Auth!", $"use {bioType} to grant access");
			var result = await fingerprint.AuthenticateAsync(request);
			if (result.Authenticated)
			{
				await DisplayAlert("Autheticated!", "Access Granted", "ok");

			}

			else
			{
				await DisplayAlert("Not authenticated!", "Access denied", "ok");
			}

		}
		else
		{

			await DisplayAlert("Info!", "No biometrics found", "ok");



		}




		
	}



}