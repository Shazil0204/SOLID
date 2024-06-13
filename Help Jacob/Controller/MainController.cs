using Help_Jacob.Model;

namespace Help_Jacob.Controller
{
	internal class MainController
	{
		Message message = new Message("to@example.com", "from@example.com", "Hello, World!", "Greetings", "cc@example.com");

		public void AllInOneController()
		{
			Message message = new Message("to@example.com", "from@example.com", "Hello, World!", "Greetings", "cc@example.com");

			IMessageSender smtpSender = new SmtpMessageSender();
			smtpSender.SendMessage(message, true);

			IMessageSender vMessageSender = new VMessageSender();
			vMessageSender.SendMessageToAll(new string[] { "recipient1@example.com", "recipient2@example.com" }, message, false);
		}
	}
}
