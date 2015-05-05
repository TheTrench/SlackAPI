using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlackAPI
{
    public class ContextMessage : Message
    {
        /// <summary>
        /// Only contains partial channel data.
        /// </summary>
        public Message previous_2;
        public Message previous;
        public Message next;
        public Message next_2;
    }
}
