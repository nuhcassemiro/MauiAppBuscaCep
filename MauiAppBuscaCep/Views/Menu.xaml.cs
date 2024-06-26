namespace MauiAppBuscaCep.Views;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.BairroPorCidade());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BairroPorCidade());
    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BuscaCepPorLogradouro());
    }
}