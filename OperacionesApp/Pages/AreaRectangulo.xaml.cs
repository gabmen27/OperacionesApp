namespace OperacionesApp.Pages;

public partial class AreaRectangulo : ContentPage
{
	public AreaRectangulo()
	{
		InitializeComponent();
	}

    private void CalcularAreaRectangulo_Clicked(object sender, EventArgs e)
    {

        if (txtBase.Text is null || txtBase.Text =="") {

            Alerta("Dato Nulo o Vacio, Ingrese de nuevo el dato");
            txtBase.Focus();

        }
        else if (txtAltura.Text is null || txtAltura.Text=="") {

            Alerta("Dato Nulo o Vacio, Ingrese de nuevo el dato");
            txtAltura.Focus();
        }
        else
        {
            double Base1, Altura1, calculo;
            Base1 = Convert.ToDouble(txtBase.Text);
            Altura1 = Convert.ToDouble(txtAltura.Text);

            calculo = Base1 * Altura1;

            txtResultado.Text = calculo.ToString();
        }

    }

    private void LimpiarRectangulo_Clicked(object sender, EventArgs e)
    {
        txtBase.Text = "";
        txtAltura.Text = "";
        txtResultado.Text = "";
        txtBase.Focus();
    }

    private void Alerta(string mensaje)
    {
        DisplayAlert("Advertensia", mensaje, "Aceptar");

    }
}