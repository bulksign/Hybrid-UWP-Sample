using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Bulksign
{
	public sealed partial class MainPage : Page
	{
		public MainPage()
		{
			this.InitializeComponent();
		}

		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			try
			{
				base.OnNavigatedTo(e);

				string url = e.Parameter.ToString();

				webView.Navigate(new Uri(url));
			}
			catch (Exception ex)
			{
				Logger.Error(ex);
			}
		}
	}
}