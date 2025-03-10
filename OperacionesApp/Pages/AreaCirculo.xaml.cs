namespace OperacionesApp.Pages;

public partial class AreaCirculo : ContentPage
{
	public AreaCirculo()
	{
		InitializeComponent();
	}

	
    private void CalcularAreaCirculo_Clicked(object sender, EventArgs e)
    {
		if (txtRadio.Text is null || txtRadio.Text == "")
		{
			Alerta("Dato no ingresado o Nulo. Intente de Nuevo");
		}
		else
		{

			double radio, calculo;
			radio = Convert.ToDouble(txtRadio.Text);
			calculo = 3.14 * Math.Pow(radio, 2);

			txtResultado.Text = calculo.ToString();
		}

    }

    private void CirculoLimpiarBtn_Clicked(object sender, EventArgs e)
    {
		txtRadio.Text = "";
		txtResultado.Text = "";
		txtRadio.Focus();
    }

	private void Alerta(string mensaje) {
		DisplayAlert("Advertensia", mensaje, "Aceptar");
	}
}