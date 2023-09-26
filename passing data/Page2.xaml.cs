namespace passing_data;

public partial class Page2 : ContentPage
{
	public Page2(string userName)
	{
		InitializeComponent();
        lblUserName.Text = userName;

    }
 //   private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
	//{
	//	Navigation.PopModalAsync();
	//}
}