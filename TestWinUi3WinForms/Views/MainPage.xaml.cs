using System.Windows.Forms;

using Microsoft.UI.Xaml.Controls;

using TestWinUi3WinForms.ViewModels;

namespace TestWinUi3WinForms.Views;

public sealed partial class MainPage : Page
{
	public MainViewModel ViewModel
	{
		get;
	}

	public MainPage()
	{
		ViewModel = App.GetService<MainViewModel>();
		InitializeComponent();
	}

	private void Button_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
	{
		MessageBox.Show("画面の数：" + Screen.AllScreens.Length);
	}
}
