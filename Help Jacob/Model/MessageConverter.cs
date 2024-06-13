public static class MessageConverter
{
	public static string ConvertBodyToHTML(string plainText)
	{
		return $"<html><body>{plainText}</body></html>";
	}
}