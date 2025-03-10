namespace OperacionesApp.Pages;

public partial class AreaCuadrado : ContentPage
{
	public AreaCuadrado()
	{
		InitializeComponent();
	}

    private void CalcularAreCuadrado_Clicked(object sender, EventArgs e)
    {
        if (txtLado.Text is null || txtLado.Text == "")
        {
            Alerta("Dato no ingresado o Nulo. Intente de Nuevo");
            txtLado.Focus();
        }
        else {
            double Lado1, calculo;

            Lado1 = Convert.ToDouble(txtLado.Text);
            calculo = Lado1 * Lado1;

            txtResultado.Text = calculo.ToString();
        }
    }

    private void LimpiarCalculoCuadrado_Clicked(object sender, EventArgs e)
    {
        txtLado.Text = "";
        txtResultado.Text = "";
        txtLado.Focus();
    }
    //Imprimiendo el Alerta
    private void Alerta(string mensaje) {
        DisplayAlert("Advertensia", mensaje, "Aceptar");
        
    }
}