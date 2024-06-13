using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help_Jacob.Model
{
	public class Message
	{
		public string To { get; set; }
		public string From { get; set; }
		public string Body { get; set; }
		public string Subject { get; set; }
		public string Cc { get; set; }

		public Message(string to, string from, string body, string subject, string cc)
		{
			this.To = to;
			this.From = from;
			this.Body = body;
			this.Subject = subject;
			this.Cc = cc;
		}
	}
}
