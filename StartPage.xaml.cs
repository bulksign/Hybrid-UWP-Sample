using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Bulksign
{
	public sealed partial class StartPage : Page
	{
		public StartPage()
		{
			this.InitializeComponent();
		}

		private void buttonCreateAccount_OnClick(object sender, RoutedEventArgs e)
		{
			try
			{
				new Navigation().NavigatetoUrl(SigningSettings.CreateAccountUrl);
			}
			catch (Exception ex)
			{
				Logger.Error(ex);
			}
		}

		private void ButtonAccessCode_OnClick(object sender, RoutedEventArgs e)
		{
			try
			{
				new Navigation().NavigatetoUrl(SigningSettings.AccessCodeUrl);
			}
			catch (Exception ex)
			{
				Logger.Error(ex);
			}

		}
	}
}