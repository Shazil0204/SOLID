using Help_Jacob.Model;

public class SmtpMessageSender : IMessageSender
{
	public void SendMessage(Message message, bool isHTML)
	{
		if (isHTML)
		{
			message.Body = MessageConverter.ConvertBodyToHTML(message.Body);
		}
		// Implement the code to send the message via SMTP
	}

	public void SendMessageToAll(string[] to, Message message, bool isHTML)
	{
		if (isHTML)
		{
			message.Body = MessageConverter.ConvertBodyToHTML(message.Body);
		}
		foreach (var recipient in to)
		{
			// Implement the code to send the message via SMTP to each recipient
		}
	}
}