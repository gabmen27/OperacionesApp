namespace OperacionesApp.Pages;

public partial class AreaCirculo : ContentPage
{
	public AreaCirculo()
	{
		InitializeComponent();
	}

	private double CalcularArea(double radio) {
		radio = Convert.ToDouble(txtRadio.Text);

		Double calculo = 3.14 * Math.Pow(radio,2);

		return calculo;
	}
    private void CalcularAreaCirculo_Clicked(object sender, EventArgs e)
    {

    }

    private void CirculoLimpiarBtn_Clicked(object sender, EventArgs e)
    {

    }
}