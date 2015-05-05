using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackAPI
{
	public interface IMessageSource
	{
		string id {get;set;}
		string name { get; }
		string display { get; }
	}
}
