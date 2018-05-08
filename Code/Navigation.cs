using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Bulksign
{
	public class Navigation
	{
		public void NavigatetoUrl(string url)
		{
			Frame rootFrame = Window.Current.Content as Frame;

			if (rootFrame == null)
			{
				rootFrame = new Frame();
				Window.Current.Content = rootFrame;
			}

			rootFrame.Navigate(typeof(MainPage), url);

		}
	}
}