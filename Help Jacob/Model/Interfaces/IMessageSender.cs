using Help_Jacob.Model;

public interface IMessageSender
{
	void SendMessage(Message message, bool isHTML);
	void SendMessageToAll(string[] to, Message message, bool isHTML);
}