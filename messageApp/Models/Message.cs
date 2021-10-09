using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace messageApp3.Models
{
    public class Message
    {
        public int id { set; get; }
        public string sentMessage { set; get; }
        public string replyMessage { set; get; }

        public Message()
        {

        }
    }
}
