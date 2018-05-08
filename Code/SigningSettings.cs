namespace Bulksign
{
	public static class SigningSettings
	{
		public const string PROTOCOL = "bulksign://";

		public const string ROOT_URL = "https://bulksign.com/";

		public static string AccessCodeUrl => ROOT_URL + "Public/AccessCode";
		public static string AccessCodeEnterUrl => ROOT_URL + "Public/AccessCode/?code=" + Argument ?? string.Empty + "&isMobile=true";
		public static string CreateAccountUrl => ROOT_URL + "Account/Register";

		public static string LaunchUri
		{
			get;
			set;
		}

		public static string Argument
		{
			get;
			set;
		}
	}
}